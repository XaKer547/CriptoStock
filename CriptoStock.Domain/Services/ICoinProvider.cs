using CryptoStock.Domain.Models;

namespace CryptoStock.Domain.Services
{
    public interface ICoinProvider
    {
        Task<IReadOnlyCollection<CoinDTO>> GetCoinTypesAsync();
    }
}
