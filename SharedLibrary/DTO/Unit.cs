
namespace SharedLibrary.DTO
{
    public class Unit : BaseDTO
    {
        public Guid ID { get; set; }
        public string NameEN { get; set; }
        public string NameVN { get; set; }
        public string DescriptionEN { get; set; }
        public string DescriptionVN { get; set; }
        public ICollection<Product> Products { get; set; }
        public Unit()
        {
            Products = new List<Product>();
        }
    }
}
