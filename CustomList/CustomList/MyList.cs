using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class MyList<T>
    {
        private T[] items;

        public MyList()
        {
            items = new T[4];
        }

        public void Add(T itemToAdd)
        {

        }
    }
}
