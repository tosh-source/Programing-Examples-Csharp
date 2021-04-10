using MyCat;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementGetEnumerator_CatOwner
{
    class Owner : IEnumerable<Cat>
    {
        public List<Cat> ListOfCats { get; private set; }
        public string Name { get; private set; }

        public Owner(string ownerName, List<Cat> cats)
        {
            this.Name = ownerName;
            this.ListOfCats = cats;
        }

        public void Add(Cat addCat)
        {
            this.ListOfCats.Add(addCat);
        }

        public IEnumerator<Cat> GetEnumerator() //The case is anyone owner to provide every purchased cats (cat by cat).
        {
            return new OwnerEnumerator(this.ListOfCats);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
