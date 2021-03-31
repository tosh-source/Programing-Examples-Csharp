using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ImplementGetEnumeratorWithYield
{
    class CatsEnumerator<T> : IEnumerable<T>
    {
        public T[] GetCats { get; set; }

        public CatsEnumerator()
        {
        }
        public CatsEnumerator(T[] setT)
        {
            this.GetCats = setT;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.GetCats.Length; i++)
            {
                yield return this.GetCats[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}

//See video in time: |2:09:50| "Обща система от типове в .NET (CTS) - 25 март 2015 - Ивайло"