namespace SharedLibrary.UserInterfaceDTO
{
    public class UnitUI : BaseUI
    {
        public Guid ID { get; set; }
        public string NameEN { get; set; }
        public string NameVN { get; set; }
        public string? DescriptionEN { get; set; }
        public string? DescriptionVN { get; set; }
        public UnitUI()
        {
            IsActive = true;
        }
    }
}
