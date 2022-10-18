
namespace Ustora.Core.Models
{
    public class Country : BaseClass
    {
        [Required]
        public string Name { get; set; }
        public virtual ICollection<City> Cities { get; set; } = new List<City>();
    }
}
