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
        private T[] temp;


        public int Capacity { get; set; }
        public int Count
        {
            get
            {
                return count;
            }
        }


        public MyList()
        {
            items = new T[4];
            Capacity = 4;
            temp = new T[4];
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

            }
            set
            {
                items[index] = value;
            }
        }

        public void Add(T itemToAdd)
        {
            if(Count == Capacity)
            {
                items = new T[Capacity *= 2];
            }

            items[count] = itemToAdd;

            count++;
        }

        public void Remove(T itemToRemove)
        {
            //make a new temporary list to hold values you want, 2 counters to loop over
            temp = new T[Capacity];
            for (int i = 0, j = 0; i < count && j < count;)
            {
                if(!items[i].Equals(itemToRemove))
                {
                    //do not add to list or ignore number or skip number
                    temp[j] = items[i];
                    j++;
                    i++;
                }
                else if (items[i].Equals(itemToRemove))
                {
                    i++;
                    
                }
            }
            items = temp;

            count--;
            //right now, we have a count decrement, but we are not removing anything, it's actually adding items
        }
        public override string ToString()
        {
        
         return String.Concat (items[count]);
        }
    }
}
