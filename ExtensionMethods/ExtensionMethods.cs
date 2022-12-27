using System;
using System.Collections.Generic;
using System.Linq;


namespace ExtensionMethods
{
    public static class ExtensionMethods
    {
        public static void ForEach<T>(this IEnumerable<T> collection, Action<T> actionMethod)  //**
        {
            foreach (var currentItem in collection)
            {
                actionMethod(currentItem);
            }
        }
    }
}

//** -> По примера от видеото на Ивайло Кенов: "Разширяващи Методи, Делегати, Ламбда, Dynamic И Linq - 2015 (Ивайло)", време: 01:39:50