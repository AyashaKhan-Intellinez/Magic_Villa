using Magic_Villa_Web.Models;
using Magic_Villa_Web.Models.DTO;
using Magic_Villa_Web.Services.IServices;
using MagicVilla_Utility;
using Newtonsoft.Json.Linq;

namespace Magic_Villa_Web.Services
{
    public class VillaNumberService : BaseService, IVIllaNumberService
    {
        private readonly IHttpClientFactory _clientFactory;
        private string villaUrl;
        public VillaNumberService(IHttpClientFactory clientFactory, IConfiguration configuration) : base(clientFactory)
        {
            _clientFactory = clientFactory;
            villaUrl = configuration.GetValue<string>("ServiceUrls:VillaAPI");
        }

        public Task<T> CreateASync<T>(VillaNumberCreateDTO dto, string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.POST,
                Data = dto,
                URL = villaUrl + "/api/v1/villaNumberAPI",
                Token = token

            });
        }

        public Task<T> DeleteASync<T>(int id , string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.DELETE,
                URL = villaUrl + "/api/v1/villaNumberAPI/" +id,
                Token = token
            }) ;
        }

        public Task<T> GetAllASync<T>(string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.GET,
                URL = villaUrl + "/api/v1/villaNumberAPI",
                Token = token

            });
        }

        public Task<T> GetASync<T>(int id, string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.GET,
                URL = villaUrl + "/api/v1/villaNumberAPI/" + id,
                Token = token

            });
        }

        public Task<T> UpdateASync<T>(VillaNumberUpdateDTO dto, string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.PUT,
                Data = dto,
                URL = villaUrl + "/api/v1/villaNumberAPI/" + dto.VillaNo,
                Token = token

            }) ;
        }
    }
}
