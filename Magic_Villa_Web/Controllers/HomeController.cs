using AutoMapper;
using Magic_Villa_Web.Models;
using Magic_Villa_Web.Models.DTO;
using Magic_Villa_Web.Services.IServices;
using MagicVilla_Utility;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;

namespace Magic_Villa_Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IVIllaService _villaService;
        private readonly IMapper _mapper;

        public HomeController(IVIllaService villaService, IMapper mapper)
        {
            _villaService = villaService;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            List<VillaDTO> list = new();
            var response = await _villaService.GetAllASync<APIResponse>(HttpContext.Session.GetString(SD.SessionToken));
            if (response != null && response.IsSuccess)
            {
                list = JsonConvert.DeserializeObject<List<VillaDTO>>(Convert.ToString(response.Result));

            }
            return View(list);
        }


    }
}