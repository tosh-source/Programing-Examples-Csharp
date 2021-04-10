using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCat;

namespace ImplementGetEnumerator_CatOwner
{
    class OwnerEnumerator : IEnumerator<Cat> //Implement Enumerator logic.
    {
        public List<Cat> ListOfCats { get; private set; }
        public int Index { get; private set; }

        public OwnerEnumerator(List<Cat> listOfCats)
        {
            this.ListOfCats = listOfCats;
            this.Index = -1;
        }

        public Cat Current
        {
            get
            {
                return this.ListOfCats[this.Index];
            }
        }

        object IEnumerator.Current //Implementation of non-generic types. This also is needed for backward compatibility with old .NET version 1.
        {
            get
            {
                return this.Current;
            }
        }

        public void Dispose()
        {
        }

        public bool MoveNext() //MoveNext() is called FIRST! So this can generate +1 index. So this.Index is set to -1;
        {
            if (this.Index >= this.ListOfCats.Count -1)
            {
                return false;
            }
            else
            {
                this.Index++;
                return true;
            }
        }

        public void Reset()
        {
            this.Index = -1;
        }
    }
}

//IEnumerable<T>.GetEnumerator Method --> https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1.getenumerator?view=net-5.0
//Best Practices Implementing the IEnumerable Interface --> https://codinghelmet.com/articles/best-practices-implementing-ienumerable-interface-in-cs
//Cached IEnumerable Implementation --> https://www.domysee.com/blogposts/cached-ienumerable/
