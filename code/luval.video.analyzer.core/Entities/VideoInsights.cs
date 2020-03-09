using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace luval.video.analyzer.core.Entities
{
    public class VideoInsights
    {
        [JsonProperty("version")]
        public string Version { get; set; }
        [JsonProperty("duration")]
        public TimeSpan Duration { get; set; }
        [JsonProperty("language")]
        public string Language { get; set; }
        [JsonProperty("transcript")]
        public List<Transcript> Transcript  { get;set;}
    }
}
