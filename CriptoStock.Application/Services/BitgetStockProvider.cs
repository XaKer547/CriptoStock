using BitGet.Net.Clients;
using BitGet.Net.Interfaces;
using CriptoStock.Domain.Services;
using CryptoExchange.Net.Sockets;

namespace CriptoStock.Application.Services
{
    public class BitgetStockProvider : IStockProvider<IBitGetTick>
    {
        private readonly BitGetSocketClient client;
        public BitgetStockProvider()
        {
            client = new BitGetSocketClient(new BitGet.Net.Objects.BitGetSocketClientOptions());
        }

        public event IStockProvider<IBitGetTick>.CurrencyChanged CurrencyChangedEvent;

        private bool isConnected;
        public async Task ConnectToTickerChanelAsync(string symbol)
        {
            await client.UnsubscribeAllAsync();

            var result = await client.SpotStreams.SubscribeToTickerUpdatesAsync(symbol, Update);

            isConnected = result.Success;
        }

        private void Update(DataEvent<IBitGetTick> @event)
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
