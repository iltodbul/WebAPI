using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Services.Contracts
{
    public interface IBooksService
    {
        Task<IEnumerable<Book>> GetAllBooks();
        ICollection<Book> GetBooksByName(string name);
    }
}
