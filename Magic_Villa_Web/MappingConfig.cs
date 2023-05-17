﻿using AutoMapper;
using Magic_Villa_Web;
using Magic_Villa_Web.Models.DTO;

namespace Magic_Villa_Web
{
    public class MappingConfig : Profile
    {
        public MappingConfig() {

            //CreateMap<Villa, VillaDTO>().ReverseMap();
            //CreateMap<VillaDTO, Villa>().ReverseMap();

            CreateMap<VillaDTO, VillaCreateDTO>().ReverseMap();
            CreateMap<VillaDTO, VillaUpdateDTO>().ReverseMap();

           
            CreateMap<VillaNumberDTO, VillaNumberCreateDTO>().ReverseMap();
            CreateMap<VillaNumberDTO, VillaNumberUpdateDTO>().ReverseMap();
          //  CreateMap<ApplicationUser, UserDTO>().ReverseMap();

        }
    }
}
