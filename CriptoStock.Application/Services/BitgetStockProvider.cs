using Bitget.Net.Interfaces.Clients;
using Bitget.Net.Objects.Models;
using CriptoStock.Domain.Services;
using CryptoExchange.Net.Sockets;
using CryptoStock.Domain.Models;
using static CriptoStock.Domain.Services.IStockProvider;

namespace CriptoStock.Application.Services
{
    public class BitgetStockProvider : IStockProvider
    {
        public event CurrencyChanged CurrencyChangedEvent;


        private readonly IBitgetSocketClient _client;
        public BitgetStockProvider(IBitgetSocketClient client)
        {
            _client = client;
        }


        private bool isConnected;
        public async Task ConnectToTickerChanelAsync(CoinPairDTO pair)
        {
            await _client.UnsubscribeAsync(0);

            var result = await _client.SpotApi.SubscribeToTickerUpdatesAsync(pair.GetSymbol(), Update);

            isConnected = result.Success;
        }

        private void Update(DataEvent<BitgetTickerUpdate> @event)
        {
            CurrencyChangedEvent.Invoke(new Domain.Models.StockDTO()
            {
                LastPrice = @event.Data.LastPrice,
            });
        }
    }
}
