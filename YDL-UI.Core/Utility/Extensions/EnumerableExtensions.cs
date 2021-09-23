namespace Maxstupo.YdlUi.Core.Utility.Extensions {
    using System;
    using System.Collections.Generic;

    public static class EnumerableExtensions {

        /// <summary>
        /// Invokes the specified action for every element in this enumerable. This method will evaluate the enumerable and does not yield.
        /// </summary>
        /// <returns>the enumerable for chaining</returns>
        public static IEnumerable<T> ForEach<T>(this IEnumerable<T> src, Action<T> action) {
            foreach (T item in src)
                action(item);

            return src;
        }

    }

}