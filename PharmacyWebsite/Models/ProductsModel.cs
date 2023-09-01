namespace PharmacyWebsite.Models
{
    public class ProductsModel
    {
        public int id { get; set; }
        public string name { get; set; } = string.Empty;
        public string description { get; set; } = string.Empty;
        public string imageURL { get; set; } = string.Empty;
    }
}
