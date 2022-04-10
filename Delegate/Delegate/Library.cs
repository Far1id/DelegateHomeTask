using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate
{
    internal class Library
    {
        public List<Book> Books = new List<Book>();
        public void AddBook(Book book)
        {
            Books.Add(book);
        }
        public List<Book> FilterByPrice(double minPrice, double maxPrice)
        {
            List<Book> FilteredBooksByPrice = new List<Book>();

            foreach (var item in Books)
            {
                if (item.Price >= minPrice && item.Price <= maxPrice)
                    FilteredBooksByPrice.Add(item);
            }

            return FilteredBooksByPrice;
        }
        public List<Book> FilterByGenre(BookGenre genre)
        {
            List<Book> FilteredBooksByGenre = new List<Book>();

            foreach (var item in Books)
            {
                if (item.Genre == genre)
                    FilteredBooksByGenre.Add(item);
            }

            return FilteredBooksByGenre;
        }
        public Book FindBookByNo(int no)
        {
            foreach (var item in Books)
            {
                if (item.No == no)
                    
                    return item;
            }

            return null;
        }
        public bool IsExistBookByNo(int no)
        {
            foreach (var item in Books)
            {
                if (item.No == no)
                    return true;
            }

            return false;
        }
        public List<Book> RemoveAll(Predicate<Book> predicate)
        {
            List<Book> RemovedBooks = new List<Book>();
            foreach (var item in Books)
            {
                if (!predicate(item))
                    RemovedBooks.Add(item);
            }
            Books = RemovedBooks;
            return Books;
        }
    }
}
