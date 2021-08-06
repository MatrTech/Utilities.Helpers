using System;
#if NETCOREAPP3_1
using System.Diagnostics.CodeAnalysis;
#endif

namespace Matr.Utilities.Helpers
{
    public static class ActivatorHelper
    {
#if NETCOREAPP3_1
        [return: MaybeNull]
        public static T CreateInstance<T>(params object?[]? parameters)
            where T : class
        {
            return ((T?)Activator.CreateInstance(typeof(T), parameters))!;
        }
#else

        public static T? CreateInstance<T>(params object?[]? parameters)
        {
            return (T?)Activator.CreateInstance(typeof(T), parameters);
        }

#endif
    }
}