﻿using Magic_Villa_Web.Models;
using Magic_Villa_Web.Models.DTO;
using Magic_Villa_Web.Services.IServices;
using MagicVilla_Utility;

namespace Magic_Villa_Web.Services
{
    public class AuthService : BaseService, IAuthService
    {
        private readonly IHttpClientFactory _clientFactory;
        private string villaUrl;
        public AuthService(IHttpClientFactory clientFactory, IConfiguration configuration) : base(clientFactory)
        {
            _clientFactory = clientFactory;
            villaUrl = configuration.GetValue<string>("ServiceUrls:VillaAPI");
        }

        public Task<T> LoginAsync<T>(LoginRequestDTO obj)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.POST,
                Data = obj,
                URL = villaUrl + "/api/v1/UsersAuth/login"

            });
        }

        public Task<T> RegisterAsync<T>(RegistrationRequestDTO obj)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.POST,
                Data = obj,
                URL = villaUrl + "/api/v1/UsersAuth/register"

            });
        }
    }
}
