


namespace Ustora.Core.Models
{
    public class CategoryOfClassfication:BaseClass
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public CmsPages CmsPages { get; set; }
        [ForeignKey("CmsPages")]
        public int ClassficationId { get; set; }
    }
}
