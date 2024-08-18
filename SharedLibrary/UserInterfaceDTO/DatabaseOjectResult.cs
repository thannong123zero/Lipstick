using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.UserInterfaceDTO
{
    public class DatabaseOjectResult
    {
        public bool OK { get; set; }
        public string ErrorMessage { get; set; }
        public string Content { get; set; }
        public DatabaseOjectResult()
        {
            OK = false;
        }
    }
}
