using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioApp
{
    class JSONParseQuote
    {

        public Equity Ticker { get; set; }

        public class Equity
        {
            [JsonProperty("assetType")]
            public string AssetType { get; set; }
            [JsonProperty("assetMainType")]
            public string AssetMainType { get; set; }
            [JsonProperty("cusip")]
            public string Cusip { get; set; }
            [JsonProperty("symbol")]
            public string Symbol { get; set; }
            [JsonProperty("description")]
            public string Description { get; set; }
            [JsonProperty("bidPrice")]
            public decimal BidPrice { get; set; }
            [JsonProperty("bidSize")]
            public decimal BidSize { get; set; }
            [JsonProperty("bidId")]
            public string BidId { get; set; }
            [JsonProperty("askPrice")]
            public decimal AskPrice { get; set; }
            [JsonProperty("askSize")]
            public decimal AskSize { get; set; }
            [JsonProperty("askId")]
            public string AskId { get; set; }
            [JsonProperty("lastPrice")]
            public decimal LastPrice { get; set; }
            [JsonProperty("lastSize")]
            public decimal LastSize { get; set; }
            [JsonProperty("lastId")]
            public string LastId { get; set; }
            [JsonProperty("openPrice")]
            public decimal OpenPrice { get; set; }
            [JsonProperty("highPrice")]
            public decimal HighPrice { get; set; }
            [JsonProperty("lowPrice")]
            public decimal LowPrice { get; set; }
            [JsonProperty("closePrice")]
            public decimal ClosePrice { get; set; }
            [JsonProperty("netChange")]
            public decimal NetChange { get; set; }
            [JsonProperty("totalVolume")]
            public double TotalVolume { get; set; }
            [JsonProperty("quoteTimeInLong")]
            public double QuoteTimeInLong { get; set; }
            [JsonProperty("tradeTimeInLong")]
            public double TradeTimeInLong { get; set; }
            [JsonProperty("mark")]
            public decimal Mark { get; set; }
            [JsonProperty("exchange")]
            public string Exchange { get; set; }
            [JsonProperty("exchangeName")]
            public string ExchangeName { get; set; }
            [JsonProperty("marginable")]
            public Boolean Marginable { get; set; }
            [JsonProperty("shortable")]
            public Boolean Shortable { get; set; }
            [JsonProperty("volatility")]
            public double Volatility { get; set; }
            [JsonProperty("digits")]
            public double Digits { get; set; }
            [JsonProperty("52WkHigh")]
            public decimal YearHigh { get; set; }
            [JsonProperty("52WkLow")]
            public decimal YearLow { get; set; }
            [JsonProperty("peRatio")]
            public double PeRatio { get; set; }
            [JsonProperty("divAmount")]
            public decimal DivAmount { get; set; }
            [JsonProperty("divYield")]
            public double DivYield { get; set; }
            [JsonProperty("divDate")]
            public string DivDate { get; set; }
            [JsonProperty("securityStatus")]
            public string SecurityStatus { get; set; }
            [JsonProperty("regularMarketLastPrice")]
            public decimal RegularMarketLastPrice { get; set; }
            [JsonProperty("regularMarketLastSize")]
            public decimal RegularMarketLastSize { get; set; }
            [JsonProperty("regularMarketNetChange")]
            public decimal RegularMarketNetChange { get; set; }
            [JsonProperty("regularMarketTradeTimeInLong")]
            public double RegularMarketTradeTimeInLong { get; set; }
            [JsonProperty("delayed")]
            public Boolean Delayed { get; set; }
        }

    }
}
