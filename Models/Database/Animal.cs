using System.Collections.Generic;

namespace ZooManager.Models.Database
{
    public class Animal
    {
        public int Id { get; set; }
        public int AnimalTypeId { get; set; }
        public AnimalType AnimalType { get; set; } = null!;
        public string Name { get; set; }
        public string Sex { get; set; }
        public DateOnly BirthDate { get; set; }
        public DateOnly AcquiredDate { get; set; }
    }
}