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
        List<T> testList;
        
        

        public MyList()
        {
            items = new T[4];
            Capacity = 4;
            Count = 0;
        }

        
        public int Capacity { get; set; }

        public int Count { get; set; }

        public void Add(T itemToAdd)//we have to do a count get set somewhere
        {   
            foreach(T item in items)//just get this in we'll figure it out
            {
                Count++;
            }

            if(Count > Capacity)//no dot notation
            {
                items = new T[Capacity * 2];//do something like the item in teh constructor above, but we need to double the capacity
            }
            //increase count for every item input
            //when count reaches capacity, create new array
        }
    }
}
