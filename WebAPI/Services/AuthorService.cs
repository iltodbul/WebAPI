using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAPI.Data;
using WebAPI.Models;
using WebAPI.Services.Contracts;

namespace WebAPI.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly BookShopDbContext _db;

        public AuthorService(BookShopDbContext db)
        {
            this._db = db;
        }

        public async Task<IEnumerable<Author>> GetAllAuthors()
        {
            var authors = await this._db.Authors.ToListAsync();
            return authors;
        }

        public ICollection<Author> GetAuthorByName(string name)
        {
            var author = this._db.Authors
                .Where(x => x.FirstName.Contains(name) || x.LastName.Contains(name))
                .ToList();
            return author;
        }
    }
}
