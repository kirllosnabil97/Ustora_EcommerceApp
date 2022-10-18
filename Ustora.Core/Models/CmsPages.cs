using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ustora.Core.Models
{
    public class CmsPages
    {
        [Key]
        public int ClassficationId { get; set; }
        [Required]
        public int ClassficationName { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int DeletedBy { get; set; }
        public DateTime DeletedDate { get; set; }
        public virtual ICollection<CategoryOfClassfication> Categories { get; set; } = new List<CategoryOfClassfication>();
    }
}
