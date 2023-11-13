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

        private readonly IBitgetSocketClient _socketClient;
        private readonly IBitgetRestClient _restClient;
        public BitgetStockProvider(IBitgetSocketClient client, IBitgetRestClient restClient)
        {
            _socketClient = client;
            _restClient = restClient;
        }

        public async Task ConnectToTickerChanelAsync(CoinPairDTO pair)
        {
            await _socketClient.UnsubscribeAsync(0);

            var result = await _socketClient.SpotApi.SubscribeToTickerUpdatesAsync(pair.GetSymbol(), Update);
        }

        private void Update(DataEvent<BitgetTickerUpdate> @event)
        {
            CurrencyChangedEvent.Invoke(new Domain.Models.StockDTO()
            {
                LastPrice = @event.Data.LastPrice,
            });
        }

        public async Task<IReadOnlyCollection<CoinDTO>> GetSymbols()
        {
            var symbols = await _restClient.SpotApi.ExchangeData.GetSymbolsAsync();

            return symbols.Data.Select(s => new CoinDTO
            {
                Id = s.BaseAsset,
                Name = s.BaseAsset
            }).ToArray();
        }
    }
}
