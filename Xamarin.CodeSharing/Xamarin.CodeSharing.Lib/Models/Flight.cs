using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.CodeSharing.Lib.Models
{
    public class Flight
    {
        [JsonProperty("Id")]
        public string Number { get; set; }
        [JsonProperty()]
        public DateTime Depart { get; set; }
        [JsonProperty()]
        public DateTime Return { get; set; }
        [JsonProperty()]
        public string From { get; set; }
        [JsonProperty()]
        public string To { get; set; }
        [JsonIgnore]
        public double Duration { get { return Return.Subtract(Depart).TotalHours; } }
    }
}
