using System.ComponentModel.DataAnnotations;

namespace ComputerLabLibrary
{
    public class ComputerLabModel
    {
        [Key]
        public int Id { get; set; }

        public string Model { get; set; }

        public string Brand { get; set; }

        public int Price { get; set; }
    }
}