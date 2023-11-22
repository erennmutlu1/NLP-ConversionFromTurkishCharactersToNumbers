using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace NLP_KarakterdenNumarayaDonusum.Models
{
    public class ConversionModel
    {
        public string? UserText { get; set; }

        [JsonIgnore]
        public string? OutputText { get; set; }    
    }
}
