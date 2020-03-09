using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace luval.video.analyzer.core.Entities
{
    public class Transcript
    {
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("text")]
        public string Text { get; set; }
        [JsonProperty("instances")]
        public List<TranscriptInstance> Instances { get; set; }
    }
}
