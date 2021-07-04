using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Services.Contracts
{
    public interface IAuthorService
    {
        Task<IEnumerable<Author>> GetAllAuthors();
        ICollection<Author> GetAuthorByName(string name);
    }
}
