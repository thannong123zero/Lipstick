namespace CRM.Services
{
    public class AppConfig
    {
        public string ProductMode { get; set; }
        public string ProdBaseAPIUrl { get; set; }
        public string DevBaseAPIUrl { get; set; }
        //MenuGroup
        public string GetMenuGroupsUrl { get; set; }
        public string GetMenuGroupByIDUrl { get; set; }
        public string AddMenuGroupUrl { get; set; }
        public string UpdateMenuGroupUrl { get; set; }
        public string DeleteMenuGroupByIDUrl { get; set; }
        public string SoftDeleteMenuGroupUrl { get; set; }
        public string RestoreMenuGroupUrl { get; set; }
        //MenuItem
        public string GetMenuItemsUrl { get; set; }
        public string GetMenuItemByIDUrl { get; set; }
        public string AddMenuItemUrl { get; set; }
        public string UpdateMenuItemUrl { get; set; }
        public string DeleteMenuItemByIDUrl { get; set; }
        public string SoftDeleteMenuItemUrl { get; set; }
        public string RestoreMenuItemUrl { get; set; }
        //Unit
        public string GetUnitsUrl { get; set; }
        public string GetUnitByIDUrl { get; set; }
        public string AddUnitUrl { get; set; }
        public string UpdateUnitUrl { get; set; }
        public string DeleteUnitByIDUrl { get; set; }
        public string SoftDeleteUnitUrl { get; set; }
        public string RestoreUnitUrl { get; set; }
        //Topic
        public string GetTopicsUrl { get; set; }
        public string GetTopicByIDUrl { get; set; }
        public string AddTopicUrl { get; set; }
        public string UpdateTopicUrl { get; set; }
        public string DeleteTopicByIDUrl { get; set; }
        public string SoftDeleteTopicUrl { get; set; }
        public string RestoreTopicUrl { get; set; }
        //Brand
        public string GetBrandsUrl { get; set; }
        public string GetBrandByIDUrl { get; set; }
        public string AddBrandUrl { get; set; }
        public string UpdateBrandUrl { get; set; }
        public string DeleteBrandByIDUrl { get; set; }
        public string SoftDeleteBrandUrl { get; set; }
        public string RestoreBrandUrl { get; set; }
        //Article
        public string GetArticlesUrl { get; set; }
        public string GetArticleByIDUrl { get; set; }
        public string AddArticleUrl { get; set; }
        public string UpdateArticleUrl { get; set; }
        public string DeleteArticleByIDUrl { get; set; }
        public string SoftDeleteArticleUrl { get; set; }
        public string RestoreArticleUrl { get; set; }
        //Product
        public string GetProductsUrl { get; set; }
        public string GetProductByIDUrl { get; set; }
        public string AddProductUrl { get; set; }
        public string UpdateProductUrl { get; set; }
        public string DeleteProductByIDUrl { get; set; }
        public string SoftDeleteProductUrl { get; set; }
        public string RestoreProductUrl { get; set; }
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
