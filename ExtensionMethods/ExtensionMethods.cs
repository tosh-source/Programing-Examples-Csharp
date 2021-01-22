using System;
using System.Collections.Generic;
using System.Linq;


namespace ExtensionMethods
{
    public static class ExtensionMethods
    {
        public static void ForEach<T>(this IEnumerable<T> collection, Action<T> actionMethod)
        {
            foreach (var currentItem in collection)
            {
                actionMethod(currentItem);
            }
        }
    }
}
