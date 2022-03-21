using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaS1
{
    public class Set<T>
    {
        public Set()
        {
            myList = new List<T>();
        }

        private List<T> myList;
        public T this[int index]
        {
            get { return myList[index]; }
            set
            {
                if ((Contains(value) == true) && !myList[index].Equals(value))
                {
                    throw new Exception("Numarul exista deja.");
                }
                myList[index] = value;
            }
        }
        public void Insert(T item)
        {
            if (Contains(item) == true)
            {
                throw new Exception("Avem dublura!");
            }
            myList.Add(item);
        }

        public void Remove(T item)
        {
            myList.Remove(item);
        }
        public bool Contains(T item)
        {
            for (int i = 0; i < myList.Count; i++)
            {
                if (myList[i].Equals(item))
                {
                    return true;
                }
            }
            return false;
        }
        public Set<T> Merge(Set<T> other)
        {
            Set<T> mergedlSet = new Set<T>();
            for (int i = 0; i < other.myList.Count; i++)
            {
                try
                {
                    if (Contains(this.myList[i]) == false)
                    {
                        mergedlSet.Insert(other.myList[i]);
                    }
                    else
                    {
                        throw new Exception($"Elementul {myList[i]} exista deja"); //pentru a-ti spune exact care este elementul
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
           
            return mergedlSet;
        }
        public Set<T> Filter(Predicate<T> filtredLogic)
        {
            var mySubSet = new Set<T>();
            for (int i = 0; i < myList.Count; i++)
            {
                if (filtredLogic.Invoke(myList[i]))
                {
                    mySubSet.Insert(myList[i]);
                }

            }
            return mySubSet;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var mySet = new Set<string>();
            mySet.Insert("Ana");
            mySet.Insert("Ilinca");
            mySet.Insert("Georgiana");
            var newSet = new Set<string>();
            //mySet[0] = 1;
            var filtredResult = mySet.Filter((x) => x.Length <= 6);
            //Set<int> mySet2;
            //mySet2 = new Set<int>();
            //mySet2.Insert(3);
            //var result = mySet2.Contains(3);
            //Console.WriteLine(result);
        }
    }
}
