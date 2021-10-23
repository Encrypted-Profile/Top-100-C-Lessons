using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomArrayClass_indexers
{
    class Data
    {
        public int[] list;
        public Data()
        {
            list = new int[10];
        }
        //Indexers make a class act like an actual array
        public int this[int index]{
            get{
                return list[index];
            }
            set{
                list[index]=value;
            } 
        }
    }
}
