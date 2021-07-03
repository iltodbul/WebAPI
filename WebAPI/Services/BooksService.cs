using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAPI.Data;
using WebAPI.Models;
using WebAPI.Services.Contracts;

namespace WebAPI.Services
{
    public class BooksService : IBooksService
    {
        private readonly BookShopDbContext _db;

        public BooksService(BookShopDbContext db)
        {
            this._db = db;
        }

        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            var books = await this._db.Books.ToListAsync();
            return books;
        }

        public ICollection<Book> GetBooksByName(string name)
        {
            var books = this._db.Books
                .Where(x => x.Name.Contains(name))
                .ToList<Book>();
            return books;
        }
    }
}
