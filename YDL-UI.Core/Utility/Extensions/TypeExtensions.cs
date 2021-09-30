namespace Maxstupo.YdlUi.Core.Utility.Extensions {
    using System;

    public static class TypeExtensions {

        /// <summary>
        /// Returns the default value for this type. Equivalent to using default(T).
        /// </summary>
        public static object GetDefaultValue(this Type type) {
            return typeof(TypeExtensions).GetMethod(nameof(GetDefaultGeneric)).MakeGenericMethod(type).Invoke(null, null);
        }

        /// <summary>Returns the default value for the given generic.</summary>
        private static T GetDefaultGeneric<T>() => default;

    }

}