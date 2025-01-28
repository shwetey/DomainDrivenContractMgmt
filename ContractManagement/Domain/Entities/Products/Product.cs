using System.Text.Json.Serialization;
namespace Domain.Entities.Products
{
    public class Product
    {
        [JsonPropertyName("_id")]
        public required string _id { get; set; }

        [JsonPropertyName("Elements")]
        public required HashSet<Element> Elements { get; set; }
    }
}
