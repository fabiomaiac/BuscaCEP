using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BuscaCEP.Domain.Dtos;
using BuscaCEP.Domain.Models;

namespace BuscaCEP.Data.Mapping
{
    public class EnderecoMapping : Profile
    {
       public EnderecoMapping()
       {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<EnderecoResponse, EnderecoModel>();
            CreateMap<EnderecoModel, EnderecoResponse>();
        } 
    }
}