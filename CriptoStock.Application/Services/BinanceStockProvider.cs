using Binance.Net.Clients;
using Binance.Net.Interfaces;
using CriptoStock.Domain.Services;
using CryptoExchange.Net.Sockets;

namespace CriptoStock.Application.Services
{
    public class BinanceStockProvider : IStockProvider<IBinanceTick>
    {
        private readonly BinanceSocketClient _client;
        public BinanceStockProvider()
        {
            _client = new BinanceSocketClient();
        }

        public event IStockProvider<IBinanceTick>.CurrencyChanged CurrencyChangedEvent;

        private bool isConnected;
        public async Task ConnectToTickerChanelAsync(string symbol)
        {
            var result = await _client.SpotApi.ExchangeData.SubscribeToTickerUpdatesAsync(symbol, Update);

            isConnected = result.Success;
        }

        private void Update(DataEvent<IBinanceTick> @event)
        {
            if (!isConnected)
            {
                CurrencyChangedEvent.Invoke(null);
                return;
            }

            CurrencyChangedEvent.Invoke(new Domain.Models.StockDTO()
            {
                LastPrice = @event.Data.LastPrice,
            });
        }
    }
}
