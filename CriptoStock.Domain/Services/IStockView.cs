using CriptoStock.Domain.Models;

namespace CriptoStock.Domain.Services
{
    public interface IStockView
    {
        Task UpdateCurrencyAsync(StockDTO? model);
        void UpdateStockSymbol(string symbol);
    }
}
