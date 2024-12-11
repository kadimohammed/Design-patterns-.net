using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K__Iterator
{
    internal class BookCollection : IIterable<string>
    {
        private List<string> _books = new();

        // ajout un livre a la collection
        public void AddBook(string book)
        {
            _books.Add(book);
        }

        // Creation de l'iterator
        public IIterator<string> CreateIterator()
        {
            return new BookIterator(this);
        }

        // methode pour get a un livre par index 
        public string GetBook(int index)
        {
            return _books[index];
        }

        // nombre de livres dans la collection
        public int Count => _books.Count;
    }
}
