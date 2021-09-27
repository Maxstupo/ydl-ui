namespace Maxstupo.YdlUi.Core.Localization.Readers {
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using Maxstupo.YdlUi.Core.Utility.Extensions;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// Read the locale resource stream as JSON text. Specifically in the format of a tree.
    /// </summary>
    public sealed class JsonTreeReader : ILocaleReader {

        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        public Dictionary<string, string> Read(Stream stream) {
            Logger.Trace("Reading...");

            using (StreamReader streamReader = new StreamReader(stream)) {
                string text = streamReader.ReadToEnd();

                JObject json = JObject.Parse(text);

                Dictionary<string, string> translations = new Dictionary<string, string>();

                foreach (JToken token in FindTokens(json)) {
                    if (token.Type != JTokenType.String && token.Type != JTokenType.Object)
                        continue;

                    string value = null;

                    if (token.Type == JTokenType.Object) {
                        JToken valueSelf = token["$val"] ?? token["$value"];
                        if (valueSelf != null)
                            value = valueSelf.Value<string>().UnescapeLineBreaks();
                    } else {

                        string keyName = ((JProperty) token.Parent).Name.Trim();
                        if (keyName == "$val" || keyName == "$value")
                            continue;

                        value = token.Value<string>().UnescapeLineBreaks();
                    }

                    if (value != null) {
                        if (value.StartsWith("@"))
                            value = json.SelectToken($"$.{value.Substring(1)}")?.Value<string>() ?? value;

                        translations.Add(token.Path.Trim(), value);
                    }
                }

                return translations;
            }

        }

        private static IEnumerable<JToken> FindTokens(JToken containerToken) {
            return FindTokens(containerToken, Enumerable.Empty<JToken>());
        }

        private static IEnumerable<JToken> FindTokens(JToken containerToken, IEnumerable<JToken> matches) {
            if (containerToken.Type == JTokenType.Object) {
                foreach (JProperty child in containerToken.Children<JProperty>()) {

                    yield return child.Value;

                    foreach (JToken token in FindTokens(child.Value, matches))
                        yield return token;

                }
            } else if (containerToken.Type == JTokenType.Array) {

                foreach (JToken child in containerToken.Children()) {

                    foreach (JToken token in FindTokens(child, matches))
                        yield return token;

                }

            }
        }

    }

}