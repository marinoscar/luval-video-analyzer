using luval.video.analyzer.core.Entities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace luval.video.analyzer.core
{
    public class IndexerOutput
    {
        public IndexerOutput(string content)
        {
            Content = content;
            ParseContent();
        }

        public string Content { get; private set; }
        public JToken Json { get; private set; }

        private void ParseContent()
        {
            if (string.IsNullOrWhiteSpace(Content)) throw new ArgumentException("Json not provided");
            try
            {
                Json = JsonConvert.DeserializeObject<JToken>(Content);
                //System.IO.File.WriteAllText("output.json",JsonConvert.SerializeObject(Json, Formatting.Indented));
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Invalid JSON provided", ex);
            }
        }

        public List<Video> GetVideos()
        {
            var videos = (JArray)Json["videos"];
            var result = new List<Video>();
            foreach(var vid in videos)
            {
                var video = vid.ToObject<Video>();
                //video.Transcript = new List<Transcript>();
                //foreach(var tran in (JArray)vid["transcript"])
                //{
                //    video.Transcript.Add(tran.ToObject<Transcript>());
                //}
                result.Add(video);
            }
            return result;
        }
    }
}
