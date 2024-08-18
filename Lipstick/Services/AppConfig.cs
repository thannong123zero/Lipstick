namespace Lipstick.Services
{
    public class AppConfig
    {
        public string ProductMode { get; set; }
        public string ProdBaseAPIUrl { get; set; }
        public string DevBaseAPIUrl { get; set; }

        public string GetMenuGroupsUrl { get; set; }
        public string GetMenuGroupByIDUrl { get; set; }

        public string GetMenuItemsUrl { get; set; }
        public string GetMenuItemByIDUrl { get; set; }


        public string GetUnitsUrl { get; set; }
        public string GetUnitByIDUrl { get; set; }

        public string GetBaseAPIURL()
        {
            string url = DevBaseAPIUrl;
            if (ProductMode.ToUpper() == "PROD")
            {
                url = ProdBaseAPIUrl;
            }
            return url;
        }
    }
}
