using Binance.Net.Interfaces;
using Bitget.Net.Objects.Models;
using Bybit.Net.Objects.Models.V5;
using CriptoStock.Domain.Services;
using CryptoStock.Domain.Models;
using Kucoin.Net.Objects.Models.Spot.Socket;

namespace CriptoStock.Desktop.Presenters
{
    public class StockPresenter
    {
        private readonly IStockView _view;
        private readonly IStockProvider<BybitSpotTickerUpdate> _bybitProvider;
        private readonly IStockProvider<IBinanceTick> _binanceProvider;
        private readonly IStockProvider<BitgetTickerUpdate> _bitGetProvider;
        private readonly IStockProvider<KucoinStreamTick> _kucoinProvider;
        public StockPresenter(IStockView view,
            IStockProvider<BybitSpotTickerUpdate> bybitProvider,
            IStockProvider<IBinanceTick> binanceProvider,
            IStockProvider<BitgetTickerUpdate> bitGetProvider,
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

        public async void ConnectToTickerChanel(StockPairDTO pair)
        {
            await _bybitProvider.ConnectToTickerChanelAsync(pair);

            await _binanceProvider.ConnectToTickerChanelAsync(pair);

            await _bitGetProvider.ConnectToTickerChanelAsync(pair);

            await _kucoinProvider.ConnectToTickerChanelAsync(pair);

            _view.UpdateStockSymbol(pair.GetSymbol("-"));
        }
    }
}
