using CriptoStock.Domain.Models;

namespace CriptoStock.Domain.Services
{
    public interface IStockView
    {
        Task UpdateBinanceCurrency(StockDTO? model);
        Task UpdateBitGetCurrency(StockDTO? model);
        Task UpdateBybitCurrency(StockDTO? model);
        Task UpdateKucoinCurrency(StockDTO? model);
        void UpdateStockSymbol(string symbol);
    }
}
