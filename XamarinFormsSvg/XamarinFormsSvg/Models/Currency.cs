using System.Text.Json.Serialization;

namespace XamarinFormsSvg.Models
{
    public class Currency
    {
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        [JsonPropertyName("logo_url")]
        public string LogoUrl { get; set; }
    }
}
