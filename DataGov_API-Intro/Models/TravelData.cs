namespace Travel_API.Models
{
    public class TravelInfo
    {
        public Quote[] Quotes { get; set; }
        public Carrier[] Carriers { get; set; }
        public Place[] Places { get; set; }
        public Currency[] Currencies { get; set; }
        public Dates Dates { get; set; }
    }

    public class Dates
    {
        public Outbounddate[] OutboundDates { get; set; }
    }

    public class Outbounddate
    {
        public string PartialDate { get; set; }
        public int Price { get; set; }
        public string[] QuoteIds { get; set; }
    }

    public class Quote
    {
        public int QuoteId { get; set; }
        public int MinPrice { get; set; }
        public bool Direct { get; set; }
        public Outboundleg OutboundLeg { get; set; }
    }

    public class Outboundleg
    {
        public int[] CarrierIds { get; set; }
        public int OriginId { get; set; }
        public int DestinationId { get; set; }
    }

    public class Carrier
    {
        public int CarrierId { get; set; }
        public string Name { get; set; }
    }

    public class Place
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int PlaceId { get; set; }
        public string IataCode { get; set; }
        public string SkyscannerCode { get; set; }
        public string CityName { get; set; }
        public string CityId { get; set; }
        public string CountryName { get; set; }
    }

    public class Currency
    {
        public string Code { get; set; }
        public string Symbol { get; set; }
        public string ThousandsSeparator { get; set; }
        public string DecimalSeparator { get; set; }
        public bool SymbolOnLeft { get; set; }
        public bool SpaceBetweenAmountAndSymbol { get; set; }
        public int RoundingCoefficient { get; set; }
        public int DecimalDigits { get; set; }
    }
}
