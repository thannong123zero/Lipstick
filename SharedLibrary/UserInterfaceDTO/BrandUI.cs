using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace SharedLibrary.UserInterfaceDTO
{
    public class BrandUI : BaseUI
    {
        public Guid ID { get; set; }
        public string NameEN { get; set; }
        public string NameVN { get; set; }
        public string? DescriptionEN { get; set; }
        public string? DescriptionVN { get; set; }
        public string? Avatar { get; set; }
        [NotMapped]
        public IFormFile UploadImage { get; set; }
        public BrandUI()
        {
            IsActive = true;
        }
    }
}
