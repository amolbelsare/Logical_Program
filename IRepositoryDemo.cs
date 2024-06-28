using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Program
{

    //Descrition
    //Generic interface is an interface that includes one or more type parameters
    //allowing you to create more flexible and reusable code.
    internal interface IRepositoryDemo<T>
    {
        void Add(T item);
        T getById(int id);
        IEnumerable<T> GetAll();
    }
}
