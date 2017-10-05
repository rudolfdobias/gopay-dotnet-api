using System;
using Newtonsoft.Json;
using GoPay.Common;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;
using System.Globalization;


namespace GoPay.Model.Payments
{
    public class Swift
    {

        [JsonProperty("swift")]
        public string SwiftName { get; set; }

        [JsonProperty("label")]
        public Dictionary<string, string> Label { get; set; }

        [JsonProperty("image")]
        public Image Image { get; set; }

        [JsonProperty("isOnline")]
        public bool IsOnline { get; set; }


        public Swift AddLabel(string locale, string label)
        {
            if (this.Label == null)
            {
                this.Label = new Dictionary<string, string>();
            }

            this.Label.Add(locale, label);
            return this;
        }

    }
}
