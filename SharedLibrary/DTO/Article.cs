using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.DTO
{
    public class Article : BaseDTO
    {
        public Guid ID { get; set; }
        public Guid TopicID { get; set; }
        public string SubjectEN { get; set; }
        public string SubjectVN { get; set; }
        public string DescriptionEN { get; set; }
        public string DescriptionVN { get; set; }
        public string ContentEN { get; set; }
        public string ContentVN { get; set; }
        public string Avatar { get; set; }
        public Topic Topic { get; set; }
    }
}
