using System.ComponentModel.DataAnnotations;

namespace ValidationInterface.Model
{
    public class Apple : IFruit
    {
        [Range(10, 1000)]
        public int? Size { get; set; }

        public string Type { get; } = "apple";
    }
}