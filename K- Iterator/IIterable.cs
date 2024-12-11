using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K__Iterator
{
    internal interface IIterable<T>
    {
        IIterator<T> CreateIterator();
    }
}
