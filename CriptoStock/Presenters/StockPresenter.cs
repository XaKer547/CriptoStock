using Binance.Net.Interfaces;
using BitGet.Net.Interfaces;
using Bybit.Net.Objects.Models.V5;
using CriptoStock.Domain.Services;
using Kucoin.Net.Objects.Models.Spot.Socket;

namespace CriptoStock.Desktop.Presenters
{
    public class StockPresenter
    {
        private readonly IStockView _view;
        private readonly IStockProvider<BybitSpotTickerUpdate> _bybitProvider;
        private readonly IStockProvider<IBinanceTick> _binanceProvider;
        private readonly IStockProvider<IBitGetTick> _bitGetProvider;
        private readonly IStockProvider<KucoinStreamTick> _kucoinProvider;
        public StockPresenter(IStockView view,
            IStockProvider<BybitSpotTickerUpdate> bybitProvider,
            IStockProvider<IBinanceTick> binanceProvider,
            IStockProvider<IBitGetTick> bitGetProvider,
            IStockProvider<KucoinStreamTick> kucoinProvider)
        {
            _view = view;

            _bybitProvider = bybitProvider;
            _bybitProvider.CurrencyChangedEvent += _view.UpdateBybitCurrency;

            _binanceProvider = binanceProvider;
            _binanceProvider.CurrencyChangedEvent += _view.UpdateBinanceCurrency;

            _bitGetProvider = bitGetProvider;
            _bitGetProvider.CurrencyChangedEvent += _view.UpdateBitGetCurrency;

            _kucoinProvider = kucoinProvider;
            _kucoinProvider.CurrencyChangedEvent += _view.UpdateKucoinCurrency;
        }

        public async void ConnectToTickerChanel(string symbol)
        {
            await _bybitProvider.ConnectToTickerChanelAsync(symbol);

            await _binanceProvider.ConnectToTickerChanelAsync(symbol);

            await _bitGetProvider.ConnectToTickerChanelAsync(symbol);

            await _kucoinProvider.ConnectToTickerChanelAsync(symbol);

            _view.UpdateStockSymbol(symbol);
        }
    }
}
