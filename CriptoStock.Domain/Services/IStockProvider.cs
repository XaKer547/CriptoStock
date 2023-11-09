using CriptoStock.Domain.Models;
using CryptoStock.Domain.Models;

namespace CriptoStock.Domain.Services
{
    public interface IStockProvider<T>
    {
        Task ConnectToTickerChanelAsync(StockPairDTO pair);

        delegate Task CurrencyChanged(StockDTO? model);
        event CurrencyChanged CurrencyChangedEvent;
    }
}
