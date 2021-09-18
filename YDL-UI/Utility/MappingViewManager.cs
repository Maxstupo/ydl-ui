namespace Maxstupo.YdlUi.Utility {
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    using Stylet;

    /// <summary>
    /// A view manager responsible for locating, creating, and setting up views.
    /// Uses key-value pairs for mapping views to view models, and namespace regular expressions for finding valid view and view model types.
    /// </summary>
    public sealed class MappingViewManager : ViewManager {

        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        /// <summary>Namespace regex for all view models. Case insensitive.</summary>       
        public string ViewModelNamespacePattern { get; set; } = @"\.?ViewModel(?:s)?\.?";

        /// <summary>Namespace regex for all views. Case insensitive.</summary>
        public string ViewNamespacePattern { get; set; } = @"\.?View(?:s)?\.?";

        /// <summary>ViewModel to View class name suffixes. Case insensitive.</summary>
        public Dictionary<string, string> NameMappings { get; } = new Dictionary<string, string>{
            { "WindowViewModel", "Window" },
            { "DialogViewModel", "Dialog" },
            { "ViewModel" , "View" },
        };

        private readonly Dictionary<Type, Type> vmMappings = new Dictionary<Type, Type>();

        public MappingViewManager(ViewManagerConfig config) : base(config) {
            GenerateMappings();
        }

        /// <summary>Regenerate view to viewmodel mappings. Should be called when a property is changed.</summary>
        public void GenerateMappings() {
            vmMappings.Clear();

            HashSet<Type> viewModelTypes = GetTypesByNamespaceRegex(ViewModelNamespacePattern);
            HashSet<Type> viewTypes = GetTypesByNamespaceRegex(ViewNamespacePattern);

            foreach (Type viewModel in viewModelTypes) {


                KeyValuePair<string, string> pair = NameMappings.FirstOrDefault(x => viewModel.Name.EndsWith(x.Key, StringComparison.InvariantCultureIgnoreCase));
                if (pair.Key == null)
                    continue;

                string viewName = viewModel.Name.Replace(pair.Key, pair.Value);

                Type view = viewTypes.FirstOrDefault(x => x.Name.Equals(viewName, StringComparison.InvariantCultureIgnoreCase));
                if (view == null)
                    continue;

                if (!vmMappings.ContainsKey(viewModel)) {
                    vmMappings.Add(viewModel, view);

                    Logger.Debug("Mapped ViewModel {viewModel} to View {view}", viewModel.Name, view.Name);
                }
            }
        }

        private HashSet<Type> GetTypesByNamespaceRegex(string namespacePattern) {
            Regex regex = new Regex(namespacePattern, RegexOptions.IgnoreCase | RegexOptions.CultureInvariant);

            return ViewAssemblies.SelectMany(x => x.GetExportedTypes())
              .Where(x => x.IsClass && !x.IsInterface && !x.IsAbstract)
              .Where(x => regex.IsMatch(x.Namespace))
              .ToHashSet();
        }

        protected override Type LocateViewForModel(Type modelType) {
            if (modelType == typeof(MessageBoxViewModel))
                return typeof(MessageBoxView);
            return vmMappings.TryGetValue(modelType, out Type viewType) ? viewType : throw new Exception($"Could not find View for ViewModel '{modelType.FullName}'");
        }

    }

}
