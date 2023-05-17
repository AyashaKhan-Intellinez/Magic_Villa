using Magic_Villa_Web.Models;
using Magic_Villa_Web.Models.DTO;
using Magic_Villa_Web.Services.IServices;
using MagicVilla_Utility;

namespace Magic_Villa_Web.Services
{
    public class VillaService : BaseService, IVIllaService
    {
        private readonly IHttpClientFactory _clientFactory;
        private string villaUrl;
        public VillaService(IHttpClientFactory clientFactory, IConfiguration configuration) : base(clientFactory)
        {
            _clientFactory = clientFactory;
            villaUrl = configuration.GetValue<string>("ServiceUrls:VillaAPI");
        }

        public Task<T> CreateASync<T>(VillaCreateDTO dto, string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.POST,
                Data = dto,
                URL = villaUrl + "/api/v1/villaAPI",
                Token = token

            });
        }

        public Task<T> DeleteASync<T>(int id, string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.DELETE,
                URL = villaUrl + "/api/v1/villaAPI/" + id,
                Token = token

            }) ;
        }

        public Task<T> GetAllASync<T>(string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.GET,
                URL = villaUrl + "/api/v1/villaAPI",
                Token = token

            });
        }

        public Task<T> GetASync<T>(int id, string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.GET,
                URL = villaUrl + "/api/v1/villaAPI/" + id,
                Token = token

            });
        }

        public Task<T> UpdateASync<T>(VillaUpdateDTO dto, string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.PUT,
                Data = dto,
                URL = villaUrl + "/api/v1/villaAPI/" + dto.Id,
                Token = token
            }) ;
        }
    }
}
