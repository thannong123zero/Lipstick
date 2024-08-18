namespace SharedLibrary.UserInterfaceDTO
{
    public class ProductUI : BaseUI
    {
        public Guid ID { get; set; }
        public Guid MenuItemID { get; set; }
        public Guid UnitID { get; set; }
        public string NameEN { get; set; }
        public string NameVN { get; set; }
        public string? DescriptionEN { get; set; }
        public string? DescriptionVN { get; set; }
        public string ContentEN { get; set; }
        public string ContentVN { get; set; }
        public string Images { get; set; }
        public double Price { get; set; }
        public int Discount { get; set; }
        public bool InHomePage { get; set; }
        public double Quantity { get; set; }
        public ProductUI()
        {
            IsActive = true;
        }
    }
}
