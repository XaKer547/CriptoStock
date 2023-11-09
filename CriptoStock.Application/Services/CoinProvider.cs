using CryptoStock.Domain.Models;
using CryptoStock.Domain.Services;
using System.Net.Http.Json;

namespace CryptoStock.Application.Services
{
    public class CoinProvider : ICoinProvider
    {
        private const string API_BASE = "https://api.pro.coinbase.com/";
        private readonly HttpClient _client;
        public CoinProvider()
        {
            _client = new HttpClient()
            {
                BaseAddress = new Uri(API_BASE)
            };
        }

        public async Task<IReadOnlyCollection<CoinDTO>> GetCoinTypesAsync()
        {
            return await _client.GetFromJsonAsync<IReadOnlyCollection<CoinDTO>>("currencies");
        }
    }
}
