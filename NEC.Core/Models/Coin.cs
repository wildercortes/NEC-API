using System;

namespace NEC.Core.Models
{
    public class Coin
    {
        public Status Status { get; set; }
        public Data[] Data { get; set; }
    }

    public class Status
    {
        public DateTime Timestamp { get; set; }
        public int Error_code { get; set; }
        public object Error_message { get; set; }
        public int Elapsed { get; set; }
        public int Credit_count { get; set; }
        public object Notice { get; set; }
        public int Total_count { get; set; }
    }

    public class Data
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public string Slug { get; set; }
        public int Num_market_pairs { get; set; }
        public DateTime Date_added { get; set; }
        public string[] Tags { get; set; }
        public float? Max_supply { get; set; }
        public float Circulating_supply { get; set; }
        public float Total_supply { get; set; }
        public Platform Platform { get; set; }
        public int Cmc_rank { get; set; }
        public float? Self_reported_circulating_supply { get; set; }
        public float? Self_reported_market_cap { get; set; }
        public DateTime Last_updated { get; set; }
        public Quote Quote { get; set; }
    }

    public class Platform
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public string Slug { get; set; }
        public string Token_address { get; set; }
    }

    public class Quote
    {
        public USD USD { get; set; }
    }

    public class USD
    {
        public float Price { get; set; }
        public float Volume_24h { get; set; }
        public float Volume_change_24h { get; set; }
        public float Percent_change_1h { get; set; }
        public float Percent_change_24h { get; set; }
        public float Percent_change_7d { get; set; }
        public float Percent_change_30d { get; set; }
        public float Percent_change_60d { get; set; }
        public float Percent_change_90d { get; set; }
        public float Market_cap { get; set; }
        public float Market_cap_dominance { get; set; }
        public float Fully_diluted_market_cap { get; set; }
        public DateTime Last_updated { get; set; }
    }

}
