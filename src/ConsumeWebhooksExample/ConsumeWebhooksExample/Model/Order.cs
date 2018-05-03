// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using FarPay.External.ConsumeWebhook.Model;
//
//    var order = Order.FromJson(jsonString);

namespace FarPay.External.ConsumeWebhook.Model
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Order
    {
        [JsonProperty("Token")]
        public string Token { get; set; }

        [JsonProperty("OrderEvent")]
        public string OrderEvent { get; set; }

        [JsonProperty("ExternalId")]
        public string ExternalId { get; set; }

        [JsonProperty("Created")]
        public DateTimeOffset Created { get; set; }

        [JsonProperty("CustomerNumber")]
        public string CustomerNumber { get; set; }
    }

    public partial class Order
    {
        public static Order FromJson(string json) => JsonConvert.DeserializeObject<Order>(json, FarPay.External.ConsumeWebhook.Model.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Order self) => JsonConvert.SerializeObject(self, FarPay.External.ConsumeWebhook.Model.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
