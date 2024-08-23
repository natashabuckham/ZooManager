using System.Collections.Generic;

namespace ZooManager.Models.Database
{
    public class AnimalType
    {
        public int Id { get; set; }
        public string Species { get; set; }
        public string Classification { get; set; }
        public ICollection<Animal> Animals { get; } = new List<Animal>();
    }
}