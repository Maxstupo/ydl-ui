using System;
using System.Collections.Generic;
using System.Text;

namespace Maxstupo.YdlUi.Utility {
    public sealed class StringPattern {
        public string Pattern { get; }

        private readonly List<Token> tokens = new List<Token>();
        public IReadOnlyList<Token> Tokens { get => tokens.AsReadOnly(); }

        private StringPattern(string pattern, List<Token> tokens) {
            Pattern = pattern ?? throw new ArgumentNullException(nameof(pattern));
            this.tokens.AddRange(tokens);
        }

        public bool IsMatch(string input) {
            return Match(input, this);
        }


        public static StringPattern Compile(string pattern) {
            StringBuilder sb = new StringBuilder();

            List<Token> tokens = new List<Token>();
            bool inGroup = false;
            bool escaped = false;
            for (int i = 0; i < pattern.Length; i++) {
                char c = pattern[i];

                if (escaped) {
                    escaped = false;
                    sb.Append(c);
                } else if (c == '\\') {
                    escaped = true;
                } else if (c == '[' && !escaped && !inGroup) {
                    inGroup = true;
                    if (sb.Length > 0) {
                        tokens.Add(new Token(TokenType.Required, sb.ToString()));
                        sb.Clear();
                    }
                } else if (c == ']' && !escaped && inGroup) {
                    inGroup = false;
                    tokens.Add(new Token(TokenType.Optional, sb.ToString()));
                    sb.Clear();
                } else if (c == '*' && !escaped && !inGroup) {
                    if (sb.Length > 0) {
                        tokens.Add(new Token(TokenType.Required, sb.ToString()));
                        sb.Clear();
                    }
                    tokens.Add(new Token(TokenType.AnyCnTkn, "*"));

                } else if (c == '?' && !escaped && !inGroup) {
                    if (sb.Length > 0) {
                        tokens.Add(new Token(TokenType.Required, sb.ToString()));
                        sb.Clear();
                    }
                    tokens.Add(new Token(TokenType.SngleTkn, "?"));

                } else {
                    sb.Append(c);
                }

            }
            if (sb.Length > 0)
                tokens.Add(new Token(TokenType.Required, sb.ToString()));
            return new StringPattern(pattern, tokens);
        }

        public static bool IsMatch(string pattern, string input) {
            StringPattern sp = Compile(pattern);
            return sp.IsMatch(input);
        }

        public static bool Match(string input, StringPattern pattern, bool debug = false) {
            if (debug) {
                Console.WriteLine($"Pattern: {pattern.Pattern}");
                Console.WriteLine($"Input: {input}\n");
            }
            for (int i = 0; i < pattern.tokens.Count; i++) {
                Token item = pattern.tokens[i];
                if (debug)
                    Console.WriteLine($"-> \"{input}\"");

                switch (item.Type) {
                    case TokenType.Required:
                        if (!input.StartsWith(item.Content))
                            return false;
                        input = input.Substring(item.Content.Length);
                        break;
                    case TokenType.Optional:
                        if (input.StartsWith(item.Content))
                            input = input.Substring(item.Content.Length);
                        break;
                    case TokenType.AnyCnTkn:
                        if (i < pattern.tokens.Count - 1) {
                            Token next = null;
                            for (int j = i + 1; j < pattern.tokens.Count; j++) {
                                next = pattern.tokens[j];
                                if (pattern.tokens[j].Type != TokenType.AnyCnTkn)
                                    break;
                            }
                            if (next != null) {
                                int startIndex = input.IndexOf(next.Content);
                                if (startIndex >= 0)
                                    input = input.Substring(startIndex);
                            }
                        } else {
                            input = string.Empty;
                        }
                        break;
                    case TokenType.SngleTkn:
                        if (input.Length == 0)
                            return false;
                        input = input.Substring(1);
                        break;
                    default:
                        throw new NotImplementedException($"The token \"{item.Type} ({item.Content})\" currently is not implemented!");
                }


            }

            bool match = input.Length == 0;

            if (debug)
                Console.WriteLine($"IsMatch: " + match + "\n--------------------------------------------------");
            return match;
        }

        public void PrintSchema() {
            PrintSchema(this);
        }

        public static void PrintSchema(StringPattern pattern) {
            Console.WriteLine($"Pattern: \"{pattern.Pattern}\"\n\n----- Tokens -----\n");
            foreach (Token item in pattern.Tokens)
                Console.WriteLine($"{item.Type.ToString().ToUpper()}: \"{item.Content}\"");
        }

        public enum TokenType {
            AnyCnTkn,
            SngleTkn,
            Optional,
            Required
        }

        public class Token {
            public TokenType Type { get; }
            public string Content { get; }

            public Token(TokenType type, string content) {
                Type = type;
                Content = content ?? throw new ArgumentNullException(nameof(content));
            }
        }
    }
}
