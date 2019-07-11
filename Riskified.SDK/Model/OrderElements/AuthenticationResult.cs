using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace Riskified.SDK.Model.OrderElements
{
    public class AuthenticationResult
    {
        public AuthenticationResult(DateTime? createdAt, string resultCode, string resultReasonCode)
        {
            CreatedAt = createdAt;
            ResultCode = resultCode;
            ResultReasonCode = resultReasonCode;
        }

        [JsonProperty(PropertyName = "created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty(PropertyName = "result_code")]
        public string ResultCode { get; set; }

        [JsonProperty(PropertyName = "result_reason_code")]
        public string ResultReasonCode { get; set; }

    }
}
