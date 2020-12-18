﻿using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OneGate.Common.Models.Common;

namespace OneGate.Common.Models.Account
{
    public class AccountFilterDto : FilterDto
    {
        [FromQuery(Name = "id")]
        [JsonProperty("id")]
        public int? Id { get; set; }

        [MaxLength(30)]
        [FromQuery(Name = "email")]
        [JsonProperty("email")]
        public string Email { get; set; }
        
        [MaxLength(30)]
        [FromQuery(Name = "first_name")]
        [JsonProperty("first_name")]
        public string FirstName { get; set; }
        
        [MaxLength(30)]
        [FromQuery(Name = "last_name")]
        [JsonProperty("last_name")]
        public string LastName { get; set; }
        
        [FromQuery(Name = "is_admin")]
        [JsonProperty("is_admin")]
        public bool? IsAdmin { get; set; }
    }
}