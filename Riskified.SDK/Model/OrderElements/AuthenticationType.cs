using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace Riskified.SDK.Model.OrderElements
{
    public class AuthenticationType
    {
        public AuthenticationType(string authType, string exemptionMethod)
        {
            AuthType = authType;
            ExemptionMethod = exemptionMethod;
        }

        [JsonProperty(PropertyName = "auth_type")]
        public string AuthType { get; set; }

        [JsonProperty(PropertyName = "exemption_method")]
        public string ExemptionMethod { get; set; }

    }
}
