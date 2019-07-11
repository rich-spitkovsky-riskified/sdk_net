using Newtonsoft.Json;
using Riskified.SDK.Model.OrderElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Riskified.SDK.Model.Internal
{
    internal class OrderCheckoutWrapper<TOrderCheckout>
    {
        [JsonProperty(PropertyName = "checkout", Required = Required.Always)]
        public TOrderCheckout Order { get; set; }

        [JsonProperty(PropertyName = "warnings")]
        public string[] Warnings { get; set; }

        [JsonProperty(PropertyName = "authentication_type")]
        public AuthenticationType AuthenticationType { get; set; }

        [JsonProperty(PropertyName = "score")]
        public int Score { get; set; }

        public OrderCheckoutWrapper(TOrderCheckout order)
        {
            Order = order;
        }
    }
}
