using System.Collections.Generic;
using WebAPI.Models;

namespace WebAPI.Services.Contracts
{
    public interface IBooksService
    {
        ICollection<Book> GetAllBooks();
        ICollection<Book> GetBooksByName(string name);
    }
}
