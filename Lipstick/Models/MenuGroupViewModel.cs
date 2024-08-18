namespace Lipstick.Models
{
    public class MenuGroupViewModel
    {
        public Guid ID { get; set; }
        public string NameEN { get; set; }
        public string NameVN { get; set; }
        public List<MenuItemViewModel> MenuItems { get; }
        public MenuGroupViewModel()
        {
            MenuItems = new List<MenuItemViewModel>();
        }
    }
}
