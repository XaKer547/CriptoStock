using Binance.Net.Interfaces;
using Binance.Net.Interfaces.Clients;
using CriptoStock.Domain.Services;
using CryptoExchange.Net.Sockets;
using CryptoStock.Domain.Models;

namespace CriptoStock.Application.Services
{
    public class BinanceStockProvider : IStockProvider<IBinanceTick>
    {
        public event IStockProvider<IBinanceTick>.CurrencyChanged CurrencyChangedEvent;


        private readonly IBinanceSocketClient _client;
        public BinanceStockProvider(IBinanceSocketClient client)
        {
            _client = client;
        }


        private bool isConnected;
        public async Task ConnectToTickerChanelAsync(StockPairDTO pair)
        {
            await _client.UnsubscribeAllAsync();

            var result = await _client.SpotApi.ExchangeData.SubscribeToTickerUpdatesAsync(pair.GetSymbol(), Update);

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
