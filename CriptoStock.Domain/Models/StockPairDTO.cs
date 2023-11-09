﻿namespace CryptoStock.Domain.Models
{
    public class StockPairDTO
    {
        public string BaseAsset { get; set; }
        public string QuoteAsset { get; set; }

        public string GetSymbol() => BaseAsset + QuoteAsset;
        public string GetSymbol(string separator) => BaseAsset + separator + QuoteAsset;
    }
}
