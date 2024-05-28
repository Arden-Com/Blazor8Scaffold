using System.ComponentModel.DataAnnotations;

namespace Blazor8Scaffold.Entities
{
    public class Mammal
    {
        public int Id { get; set; }
        
        [StringLength(40), Required]
        public string Name { get; set; } = string.Empty;
        
        [StringLength(1000)]
        public string Description { get; set; } = string.Empty;
        
        [StringLength(100)]
        public string Image { get; set; } = string.Empty;
        
        [StringLength(500)]
        public string Habitat { get; set; } = string.Empty;

        [StringLength(500)]
        public string Diet { get; set; } = string.Empty;
    }
}
