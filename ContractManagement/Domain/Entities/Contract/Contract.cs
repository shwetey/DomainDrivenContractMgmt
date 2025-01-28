using System.Text.Json.Serialization;
using Domain.Entities.Products;
namespace Domain.Entities.Contract
{
    public class Contract
    {
        [JsonPropertyName("_id")]
        public required string _id { get; set; }

        [JsonPropertyName("Name")]
        public required string Name { get; set; }

        [JsonPropertyName("CountryId")]
        public required int CountryId { get; set; }

        [JsonPropertyName("Products")]
        public required HashSet<Product> Products { get; set; }
    }
}
