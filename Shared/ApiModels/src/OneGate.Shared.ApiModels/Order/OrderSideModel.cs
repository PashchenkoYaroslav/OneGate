﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace OneGate.Shared.ApiModels.Order
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OrderSideModel
    {
        BUY,
        SELL
    }
}