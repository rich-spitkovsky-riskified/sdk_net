using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace Riskified.SDK.Model.OrderElements
{
    // still need to change strings to enums here 
    public class AuthenticationResult
    {
        public AuthenticationResult(string eci, DateTime? createdAt = null, string cavv = null, string transStatus = null, string transStatusReason = null)
        {
            CreatedAt = createdAt;
            Cavv = cavv;
            Eci = eci;
            TransStatus = transStatus;
            TransStatusReason = transStatusReason;
        }

        [JsonProperty(PropertyName = "created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty(PropertyName = "cavv")]
        public string Cavv { get; set; }

        [JsonProperty(PropertyName = "eci")]
        public string Eci { get; set; }

        [JsonProperty(PropertyName = "trans_status")]
        public string TransStatus { get; set; }

        [JsonProperty(PropertyName = "trans_status_reason")]
        public string TransStatusReason { get; set; }

    }
}
