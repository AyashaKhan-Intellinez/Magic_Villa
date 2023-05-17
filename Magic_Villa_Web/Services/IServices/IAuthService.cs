using Magic_Villa_Web.Models.DTO;

namespace Magic_Villa_Web.Services.IServices
{
    public interface IAuthService
    {
        Task<T> LoginAsync<T>(LoginRequestDTO objToCreate);
       // Task<T> RegisterAsync<T>(UserDTO objToCreate);
        Task<T> RegisterAsync<T>(RegistrationRequestDTO objToCreate);
    }
}
