namespace Maxstupo.YdlUi.Core.YoutubeDl.Binaries.Readers {
    using System;
    using System.Collections.Generic;
    using System.IO.Abstractions;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public sealed class JsonBinaryReader : IYdlBinaryReader {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        private readonly IFileSystem fileSystem;

        public JsonBinaryReader(IFileSystem fileSystem) {
            this.fileSystem = fileSystem;
        }

        public void Read(IYdlBinaryLibrary library, string filepath) {
            Logger.Info("Loading...");

            Logger.Debug("Reading binary definitions file from {filepath}", filepath);
            string json = fileSystem.File.ReadAllText(filepath, Encoding.UTF8);

            JToken root = JToken.Parse(json);


            foreach (JToken item in root) {

                string id = item.Value<string>("id") ?? null;
                string name = item.Value<string>("name") ?? null;
                string description = item.Value<string>("description") ?? null;

                JToken repoToken = item["repository"];
                if (repoToken == null || repoToken.Type != JTokenType.Object) {
                    Logger.Warn("Failed to find repository information for binary definition {id} (name). Ignoring this definition entry!", id, name);
                    continue;
                }

                string username = repoToken.Value<string>("username") ?? null;
                string project = repoToken.Value<string>("project") ?? null;
                string assetMatch = repoToken.Value<string>("asset_match") ?? null;
                string targetFilename = repoToken.Value<string>("target_name") ?? null;


                JToken argumentsToken = item["arguments"];
                if (argumentsToken == null || argumentsToken.Type != JTokenType.Array) {
                    Logger.Warn("Failed to find arguments information for binary definition {id} (name). Ignoring this definition entry!", id, name);
                    continue;
                }


                YdlBinaryDefinition def = new YdlBinaryDefinition(id, name, description, username, project, assetMatch, targetFilename, new List<Arguments.ArgumentDefinition>() { });

                library.Add(def);
            }

        }

    }

}