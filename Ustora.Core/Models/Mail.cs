using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ustora.Core.Models
{
    public class Mail:BaseClass
    {
        public string Title { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public string CompanyName { get; set; }
        public string Description { get; set; }
    }
}
