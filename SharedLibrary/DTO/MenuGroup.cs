
namespace SharedLibrary.DTO
{
    public class MenuGroup : BaseDTO
    {
        public Guid ID { get; set; }
        public string NameEN { get; set; }
        public string NameVN { get; set; }
        public string DescriptionEN { get; set; }
        public string DescriptionVN { get; set; }
        public bool InNavbar { get; set; }
        public int Priority { get; set; }
        public ICollection<MenuItem> MenuItems { get; set; }
        public MenuGroup()
        {
            MenuItems = new List<MenuItem>();
        }
    }
}
