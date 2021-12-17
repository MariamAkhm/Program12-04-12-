using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program12_04_12_
{
    class BookList
    {
        public List<Books> books;
        public BookList(List<Books> books)
        {
            this.books = books;
        }
        public List<Books> SortByName()
        {
            return books.OrderBy(books => books.Name).ToList();
        }
        public List <Books> SortByAuthor()
        {
            return books.OrderBy(books => books.Author).ToList();
        }
        public List <Books> SortByPublishing()
        {
            return books.OrderBy(books => books.Publishing).ToList();
        }
    }
}
