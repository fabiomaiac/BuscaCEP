using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuscaCEP.Domain.Dtos;
using BuscaCEP.Domain.Models;

namespace BuscaCEP.Service.Interfaces
{
    public interface IBrasilApi
    {
        Task<ResponseGenerico<EnderecoModel>> BuscarEnderecoPorCep(string cep);
    }
}