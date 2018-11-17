using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Maxstupo.YdlUi.Utility {
    public class ResourceExtractor {

        /// <summary>
        /// Returns embedded resources, with the specified namespace prefix.
        /// </summary>
        /// <param name="resourceNamespacePrefix">The namespace prefix that returned resources must have. If null, namespace prefix will be ignored.</param>
        /// <param name="name">The name of the resource to return, if null ignore resource names. Using the pipe (|) character as a prefix will negate.</param>
        /// <returns>An array of embedded resources.</returns>
        public static Resource[] GetEmbeddedResources(string resourceNamespacePrefix = null, string name = null) {
            bool hasPrefix = !string.IsNullOrWhiteSpace(resourceNamespacePrefix);
            bool hasName = !string.IsNullOrWhiteSpace(name);
            bool isNameInverted = name?.StartsWith("|") ?? false;

            string cleanedName = hasName ? name.Replace("|", "") : null;

            List<Resource> resources = new List<Resource>();



            Assembly assembly = Assembly.GetEntryAssembly();
            foreach (string resourceName in assembly.GetManifestResourceNames()) {
                if (hasPrefix && !resourceName.StartsWith(resourceNamespacePrefix))
                    continue;

                if (hasName) {
                    bool endsWithName = resourceName.EndsWith($".{cleanedName}");

                    if ((!endsWithName && !isNameInverted) || (endsWithName && isNameInverted))
                        continue;
                }

                string filename = hasPrefix ? resourceName.Replace(resourceNamespacePrefix, string.Empty) : resourceName;
                if (filename.StartsWith("."))
                    filename = filename.Remove(0, 1);

                resources.Add(new Resource(assembly, resourceName, filename));
            }

            return resources.ToArray();
        }

        /// <summary>
        /// Extract embedded resources to directory.
        /// </summary>
        /// <param name="directoryInfo">The directory to extract resources into.</param>
        /// <param name="resourceNamespacePrefix">The namespace prefix that extracted resources must have. If null, namespace prefix will be ignored.</param>
        /// <param name="name">The name of the resource(s) to extract - if null, ignore resource names. Using the pipe (|) character as a prefix will negate.</param>
        /// <returns>An array of descriptors specifying the full path to each extracted resource.</returns>
        public static ResourceDescriptor[] ExtractTo(DirectoryInfo directoryInfo, string resourceNamespacePrefix = null, string name = null) {
            Resource[] resources = GetEmbeddedResources(resourceNamespacePrefix, name); // Find our embedded resources.

            List<ResourceDescriptor> descriptors = new List<ResourceDescriptor>();

            foreach (Resource resource in resources) {
                FileInfo file = resource.ExtractTo(directoryInfo);
                descriptors.Add(new ResourceDescriptor(file, resource));
            }

            return descriptors.ToArray();
        }

        /// <summary>
        /// Extract embedded resources to a temp directory.
        /// </summary>
        /// <param name="tempDirectory">The temp directory to extract resources into.</param>
        /// <param name="resourceNamespacePrefix">The namespace prefix that extracted resources must have. If null, namespace prefix will be ignored.</param>
        /// <param name="name">The name of the resource(s) to extract - if null, ignore resource names. Using the pipe (|) character as a prefix will negate.</param>
        /// <returns>An array of descriptors specifying the full path to each extracted resource.</returns>
        public static ResourceDescriptor[] ExtractTo(TempDirectory tempDirectory, string resourceNamespacePrefix = null, string name = null) {
            return ExtractTo(tempDirectory.Info, resourceNamespacePrefix, name);
        }

        /// <summary>
        /// Returns the full path of a extracted resource based of its filename and descriptor.
        /// </summary>
        /// <param name="descriptors">An array of descriptors to find the full filepath of the specified resource filename.</param>
        /// <param name="filename">The filename of the extracted resource to find.</param>
        /// <returns></returns>
        public static string GetFullPath(ResourceDescriptor[] descriptors, string filename) {
            return descriptors.Where(d => d.File.Name == filename).FirstOrDefault()?.File?.FullName;
        }
    }

    public class ResourceDescriptor {
        /// <summary>
        /// The location this resource was written to.
        /// </summary>
        public FileInfo File { get; }

        /// <summary>
        /// The object representing the embedded resource that has been extracted.
        /// </summary>
        public Resource Resource { get; }

        public ResourceDescriptor(FileInfo file, Resource resource) {
            File = file;
            Resource = resource;
        }
    }

    /// <summary>
    /// A class that represents an embedded resource. Provides common methods to extract the resource.
    /// </summary>
    public class Resource {
        /// <summary>
        /// The full resource name including namespace.
        /// </summary>
        public string ResourceName { get; }

        /// <summary>
        /// The filename of this resource.
        /// </summary>
        public string FileName { get; }

        /// <summary>
        /// The file extension of this resource.
        /// </summary>
        public string Extension { get => Path.GetExtension(FileName); }

        private readonly Assembly assembly;

        /// <summary>
        /// The stream for this resource. Must be disposed after use. 
        /// </summary>
        public Stream Stream { get => assembly.GetManifestResourceStream(ResourceName); }

        public Resource(Assembly assembly, string resourceName, string filename) {
            this.assembly = assembly;
            this.ResourceName = resourceName;
            this.FileName = filename;
        }

        /// <summary>
        /// Extracts this resource to the specified <paramref name="directory"/>. Overwrites if file already exists.
        /// </summary>
        /// <param name="directory">The directory this resource will be extracted into.</param>
        /// <returns>A <see cref="FileInfo"/> object representing this resource at the extracted location.</returns>
        public FileInfo ExtractTo(DirectoryInfo directory) {
            FileInfo file = new FileInfo(Path.Combine(directory.FullName, FileName));
            try {
                ExtractTo(file);
            } catch (Exception e) {
                Logger.Instance.Error(nameof(ResourceExtractor), "Error while extracting to directory '{0}' -\n{1}", file.FullName, e.ToString());
            }
            return file;
        }

        /// <summary>
        /// Extracts this resource to the specified file. Overwrites if file already exists.
        /// </summary>
        /// <param name="fileInfo">The file location to write to.</param>
        public void ExtractTo(FileInfo fileInfo) {
            if (fileInfo == null)
                throw new ArgumentNullException(nameof(fileInfo));

            using (FileStream fileStream = fileInfo.Create()) {
                using (Stream stream = Stream)
                    stream.CopyTo(fileStream);
            }
        }
    }

}
