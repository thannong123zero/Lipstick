using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.DTO
{
    public class Brand : BaseDTO
    {
        public Guid ID { get; set; }
        public string NameEN { get; set; }
        public string NameVN { get; set; }
        public string DescriptionEN { get; set; }
        public string DescriptionVN { get; set; }
        public string Avatar { get; set; }
        public ICollection<Product> Products { get; set; }
        public Brand()
        {
            Products = new List<Product>();
        }
    }
}
