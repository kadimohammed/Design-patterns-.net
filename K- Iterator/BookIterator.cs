using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K__Iterator
{
    internal class BookIterator : IIterator<string>
    {
        private readonly BookCollection _collection;
        private int _currentIndex = 0;

        public BookIterator(BookCollection collection)
        {
            _collection = collection;
        }

        // Verifie sil reste des elements
        public bool HasNext()
        {
            return _currentIndex < _collection.Count;
        }

        // Retourne l'element suivant
        public string Next()
        {
            return _collection.GetBook(_currentIndex++);
        }
    }
}
