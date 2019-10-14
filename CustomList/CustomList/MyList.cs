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
            
            temp = new T[Capacity];
            for (int i = 0, j = 0; i < count && j < count;)
            {
                if(!items[i].Equals(itemToRemove))
                {
                    
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
            
        }
        public override string ToString()
        {
        
         return String.Concat (items[count]);
        }
    }
}
