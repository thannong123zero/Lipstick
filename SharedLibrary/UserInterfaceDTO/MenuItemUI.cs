using System.ComponentModel.DataAnnotations;

namespace SharedLibrary.UserInterfaceDTO
{
    public class MenuItemUI : BaseUI
    {
        public Guid ID { get; set; }
        public Guid MenuGroupID { get; set; }
        public string NameEN { get; set; }
        public string NameVN { get; set; }
        public string? DescriptionEN { get; set; }
        public string? DescriptionVN { get; set; }
        [Range(1,9999)]
        public int Priority { get; set; }
        public MenuItemUI()
        {
            Priority = 1;
            IsActive = true;
        }
    }
}
