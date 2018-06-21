using System.ComponentModel.DataAnnotations;

namespace ValidationInterface.Model
{
    public class Orange : IFruit
    {
        [Required]
        [StringLength(1000, MinimumLength = 10)]
        public string Name { get; set; }

        public string Type { get; } = "orange";
    }
}