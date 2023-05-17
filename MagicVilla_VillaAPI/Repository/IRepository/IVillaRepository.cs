using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Repository.IRepository;
using System.Linq.Expressions;

namespace MagicVilla_VillaAPI.Repository.IRepostiory
{
    public interface IVillaRepository : IRepository<Villa>
    {
        Task CreateAsync(Villa villa);
        Task<Villa> UpdateAsync(Villa entity);

    }
}
