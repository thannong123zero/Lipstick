using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.DTO
{
    public class Invoice
    {
        public Guid ID { get; set; }
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        public int DistrictID { get; set; }
        public int ProvinceID { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Note { get; set; }
        public bool IsApproved { get; set; }
        public ICollection<InvoiceDetails> InvoiceDetails { get; set; }
        public Invoice()
        {
            InvoiceDetails = new List<InvoiceDetails>();
        }

    }
}
