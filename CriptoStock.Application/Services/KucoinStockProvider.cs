using CriptoStock.Domain.Services;
using CryptoExchange.Net.Sockets;
using Kucoin.Net.Clients;
using Kucoin.Net.Objects.Models.Spot.Socket;

namespace CriptoStock.Application.Services
{
    public class KucoinStockProvider : IStockProvider<KucoinStreamTick>
    {
        private readonly KucoinSocketClient _client;
        public KucoinStockProvider()
        {
            _client = new KucoinSocketClient();
        }

        public event IStockProvider<KucoinStreamTick>.CurrencyChanged CurrencyChangedEvent;

        private bool isConnected;
        public async Task ConnectToTickerChanelAsync(string symbol)
        {
            var result = await _client.SpotApi.SubscribeToTickerUpdatesAsync(symbol, Update);
            isConnected = result.Success;
        }

        private void Update(DataEvent<KucoinStreamTick> @event)
        {
            if (!isConnected)
            {
                CurrencyChangedEvent.Invoke(null);
                return;
            }

            CurrencyChangedEvent.Invoke(new Domain.Models.StockDTO()
            {
                LastPrice = (decimal)@event.Data.LastPrice,
            });
        }
    }
}
