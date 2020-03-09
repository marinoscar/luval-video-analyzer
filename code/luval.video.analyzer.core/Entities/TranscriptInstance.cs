using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace luval.video.analyzer.core.Entities
{
    public class TranscriptInstance
    {
        [JsonProperty("start")]
        public string Start { get; set; }
        [JsonProperty("end")]
        public string End { get; set; }
    }
}
