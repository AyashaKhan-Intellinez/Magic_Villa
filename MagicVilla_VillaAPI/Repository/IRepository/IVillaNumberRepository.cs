using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Repository.IRepository;
using System.Linq.Expressions;

namespace MagicVilla_VillaAPI.Repository.IRepostiory
{
    public interface IVillaNumberRepository : IRepository<VillaNumber>
    {

        Task<VillaNumber> UpdateAsync(VillaNumber entity);

    }
}
