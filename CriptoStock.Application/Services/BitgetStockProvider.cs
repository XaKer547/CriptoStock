using Bitget.Net.Interfaces.Clients;
using Bitget.Net.Objects.Models;
using CriptoStock.Domain.Services;
using CryptoExchange.Net.Sockets;
using CryptoStock.Domain.Models;

namespace CriptoStock.Application.Services
{
    public class BitgetStockProvider : IStockProvider<BitgetTickerUpdate>
    {
        public event IStockProvider<BitgetTickerUpdate>.CurrencyChanged CurrencyChangedEvent;


        private readonly IBitgetSocketClient _client;
        public BitgetStockProvider(IBitgetSocketClient client)
        {
            _client = client;
        }


        private bool isConnected;
        public async Task ConnectToTickerChanelAsync(StockPairDTO pair)
        {
            await _client.UnsubscribeAllAsync();

            var result = await _client.SpotApi.SubscribeToTickerUpdatesAsync(pair.GetSymbol(), Update);

            isConnected = result.Success;
        }

        private void Update(DataEvent<BitgetTickerUpdate> @event)
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
