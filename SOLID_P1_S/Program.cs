using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_P1_S
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkerOne<int> w = new WorkerOne<int>(100);
            w.add(23, 0);
            w.add(21, 1);
            w.add(230, 2);
            w.add(234, 3);
            w.add(133, 4);

            Console.WriteLine(w.get(2));

            Console.ReadLine();
        }
    }

    public class WorkerOne<T>
    {
        //private int[] xyz;
        private T[] myTypeArray;
        public WorkerOne(int size)
        {            
            myTypeArray = new T[size];
        }

        public void add(T myType, int index)
        {
            myTypeArray[index] = myType;
        }
        public T get(int index)
        {
            return myTypeArray[index];
        }
        public void aMethod(int k, int val)
        {
            //return k * xyz[val];
        }
    }
}
