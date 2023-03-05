using System.Dynamic;
using System.Text.Json;
using BuscaCEP.Domain.Dtos;
using BuscaCEP.Domain.Models;
using BuscaCEP.Service.Interfaces;

namespace BuscaCEP.Data.Rest
{
    public class BrasilApiRest : IBrasilApi
    {
        public async Task<ResponseGenerico<EnderecoModel>> BuscarEnderecoPorCep(string cep)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api#tag/CEP/cep/v1/{cep}");

            var response = new ResponseGenerico<EnderecoModel>();
            using (var client = new HttpClient()) {
                var responseBrasilApi = await client.SendAsync(request);
                var contentResp = await responseBrasilApi.Content.ReadAsStringAsync();
                var objResponse = JsonSerializer.Deserialize<EnderecoModel>(contentResp);

                if (responseBrasilApi.IsSuccessStatusCode)
                {
                    response.CodigoHttp = responseBrasilApi.StatusCode;
                    response.DadosRetorno = objResponse;
                }
                else
                {
                    response.CodigoHttp = responseBrasilApi.StatusCode;
                    response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(contentResp);
                }
                return response;
            }
        }
    }

}