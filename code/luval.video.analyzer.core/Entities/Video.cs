using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace luval.video.analyzer.core.Entities
{
    public class Video
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("accountId")]
        public string AccountId { get; set; }
        [JsonProperty("language")]
        public string Language { get; set; }
        [JsonProperty("insights")]
        public VideoInsights Insights { get; set; }

    }
}
