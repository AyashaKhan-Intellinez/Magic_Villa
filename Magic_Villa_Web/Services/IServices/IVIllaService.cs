using Magic_Villa_Web.Models.DTO;

namespace Magic_Villa_Web.Services.IServices
{
    public interface IVIllaService
    {

        Task<T> GetAllASync<T>(string token);
        Task<T> GetASync<T>(int  id, string token);
        Task<T> CreateASync<T>(VillaCreateDTO dto, string token);
        Task<T> UpdateASync<T>(VillaUpdateDTO dto, string token);
        Task<T> DeleteASync<T>(int id, string token);

    }
}
