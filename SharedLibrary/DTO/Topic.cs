using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.DTO
{
    public class Topic : BaseDTO
    {
        public Guid ID { get; set; }
        public string NameEN { get; set; }
        public string NameVN { get; set; }
        public string DescriptionEN { get; set; }
        public string DescriptionVN { get; set; }
        public int Priority { get; set; }
        public ICollection<Article> Articles { get; set; }
        public Topic()
        {
            Articles = new List<Article>();
        }
    }
}
