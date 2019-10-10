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
        private int count;
        
       

        public MyList()
        {
            items = new T[4];
            Capacity = 4;
    }

        public T this [int index]
        {
            get
            {
                if (index >= count)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    return items[index];
                }
                // check if 'index' is valid
                // throw an ArgumentOutOfRangeException

            }
            set
            {
                items[index] = value;
            }
        }
        public int Capacity { get; set; }
        public int Count { 
            get 
            {
                return count;
            }
        }

        public void Add(T itemToAdd)//we have to do a count get set somewhere
        {
            count++;

            
            if(Count == Capacity)
            {
                items = new T[Capacity *= 2];
            }

            items[0] = itemToAdd;//next is to write logic so you add to other indexes and not just the 0 one
            for(int i = 0; i > items; i++)
            {
                items[0+1] = itemToAdd;
            }
            //increase count for every item input
            //when count reaches capacity, create new array
            //add item to array
        }

        public void Remove(T itemToRemove)
        {

        }
    }
}
