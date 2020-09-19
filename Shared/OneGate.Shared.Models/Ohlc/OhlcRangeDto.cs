﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace OneGate.Shared.Models.Ohlc
{
    public class OhlcRangeDto
    {
        [Required]
        [JsonProperty("interval")]
        public OhlcIntervalDto Interval { get; set; }

        [Required]
        [JsonProperty("asset_id")]
        public int AssetId { get; set; }
        
        [Required]
        [JsonProperty("range")]
        public List<OhlcDto> Range { get; set; }
    }
}