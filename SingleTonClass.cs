using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Program
{
    public sealed class SingleTonClass
    {
        private static SingleTonClass instance;
        private static object locker = new object();

        private SingleTonClass() { } 

        public static SingleTonClass GetInstance()
        {
            if(instance == null)
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new SingleTonClass();
                    }
                }
            }                      
            return instance;
        }
    }
}
