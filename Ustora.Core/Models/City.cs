using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ustora.Core.Models
{
    public class City :BaseClass
    {
        [Required]
        public string Name { get; set; }

        public virtual Country country { get; set; }
        [ForeignKey("Country")]
        public int countryId { get; set; }
  

    }
}
