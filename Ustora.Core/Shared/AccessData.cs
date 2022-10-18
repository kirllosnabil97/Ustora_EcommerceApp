
namespace Ustora.Core.Shared
{
    //this is generic model use it in any drop down list use name and Id only 
    public class AccessData
    {
        [Required]
        public int ID{ get; set; }
        public string Name { get; set; } 
    }
}
