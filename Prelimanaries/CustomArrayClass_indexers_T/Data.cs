using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomArrayClass_indexers_T
{
    class Data<T>
    {
        public T[] list;
        public Data()
        {
            list = new T[10];
        }
        //Indexers make a class act like an actual array
        public T this[int index]
        {
            get
            {
                return list[index];
            }
            set
            {
                list[index] = value;
            }
        }
    }
}
