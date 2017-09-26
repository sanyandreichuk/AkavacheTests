using Newtonsoft.Json;

namespace AkavacheTests.Rest.Dtos
{
    public class PhotoDto
    {
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "thumbnailUrl")]
        public string Url { get; set; }
    }
}
