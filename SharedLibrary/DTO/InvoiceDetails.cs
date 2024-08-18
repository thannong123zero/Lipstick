using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.DTO
{
    public class InvoiceDetails
    {
        public Guid ID { get; set; }
        public Guid ProductID {get;set;}
        public Guid InvoiceID { get; set; }
        public int Quantity { get; set; }
        public Invoice Invoice { get; set; }
    }
}
