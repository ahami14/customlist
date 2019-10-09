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
        new Array array;

        public MyList()
        {
            items = new T[4];
        }

        public void Add(T itemToAdd)
        {   
            foreach(Item item in items)//just get this in we'll figure it out
            {
                Count++;
            }

            if(items.Count > items.Capacity)
            {
                Array array = new array;
            }
            //increase count for every item input
            //when count reaches capacity, create new array
        }
    }
}
