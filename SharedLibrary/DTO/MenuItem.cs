
namespace SharedLibrary.DTO
{
    public class MenuItem : BaseDTO
    {
        public Guid ID { get; set; }
        public Guid MenuGroupID { get; set; }
        public string NameEN { get; set; }
        public string NameVN { get; set; }
        public string DescriptionEN { get; set; }
        public string DescriptionVN { get; set; }
        public int Priority { get; set; }
        public MenuGroup MenuGroup { get; set; }
        public ICollection<Product> Products { get; set; }
        public MenuItem()
        {
            Products = new List<Product>();
        }
    }
}
