using CriptoStock.Domain.Services;
using CryptoStock.Domain.Models;

namespace CriptoStock.Desktop.Presenters
{
    public class StockPresenter
    {
        private readonly IStockView _view;
        private readonly IStockProvider _provider;

        public StockPresenter(IStockView view, IStockProvider provider)
        {
            _view = view;

            _provider = provider;
            _provider.CurrencyChangedEvent += _view.UpdateCurrencyAsync;
        }

        public async void ConnectToTickerChanel(CoinPairDTO pair)
        {
            await _provider.ConnectToTickerChanelAsync(pair);

            _view.UpdateStockSymbol(pair.GetSymbol("-"));
        }
    }
}
