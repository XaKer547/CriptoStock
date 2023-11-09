using CriptoStock.Domain.Models;

namespace CriptoStock.Domain.Services
{
    public interface IStockProvider<T>
    {
        Task ConnectToTickerChanelAsync(string symbol);

        delegate Task CurrencyChanged(StockDTO? model);
        event CurrencyChanged CurrencyChangedEvent;
    }
}
