using System.Text.Json.Serialization;
namespace Domain.Entities.Contract
{
    public class Root
    {
        [JsonPropertyName("Contracts")]
        public required Contract Contracts { get; set; }
    }
}
