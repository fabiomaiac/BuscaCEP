using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuscaCEP.Domain.Dtos;

namespace BuscaCEP.Service.Interfaces
{
    public interface IEnderecoService
    {
        Task<ResponseGenerico<EnderecoResponse>> BuscarEndereco(string cep);
    }
}