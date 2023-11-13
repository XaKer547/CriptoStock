using Binance.Net.Interfaces;
using Binance.Net.Interfaces.Clients;
using CriptoStock.Domain.Services;
using CryptoExchange.Net.Sockets;
using CryptoStock.Domain.Models;
using static CriptoStock.Domain.Services.IStockProvider;

namespace CriptoStock.Application.Services
{
    public class BinanceStockProvider : IStockProvider
    {
        public event CurrencyChanged CurrencyChangedEvent;

        private readonly IBinanceSocketClient _socketClient;
        private readonly IBinanceRestClient _restClient;
        public BinanceStockProvider(IBinanceSocketClient client, IBinanceRestClient restClient)
        {
            _socketClient = client;
            _restClient = restClient;
        }


        private bool isConnected;
        public async Task ConnectToTickerChanelAsync(CoinPairDTO pair)
        {
            await _socketClient.UnsubscribeAsync(0);

            var result = await _socketClient.SpotApi.ExchangeData.SubscribeToTickerUpdatesAsync(pair.GetSymbol(), Update);

            isConnected = result.Success;
        }

        private void Update(DataEvent<IBinanceTick> @event)
        {
            var price = Math.Round(@event.Data.LastPrice, 2);
            CurrencyChangedEvent.Invoke(new Domain.Models.StockDTO()
            {
                LastPrice = price,
            });
        }

        public async Task<IReadOnlyCollection<CoinDTO>> GetSymbols()
        {
            var pairs = await _restClient.SpotApi.ExchangeData.GetExchangeInfoAsync();

            return pairs.Data.Symbols.Select(s => new CoinDTO
            {
                Id = s.BaseAsset,
                Name = s.BaseAsset
            }).ToArray();
        }
    }
}
