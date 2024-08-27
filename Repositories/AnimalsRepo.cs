using ZooManager.Models.Database;
using ZooManager.Models.Request;

namespace ZooManager.Repositories
{
    public interface IAnimalsRepo
    {
        Animal GetById(int id);
        Animal Create(CreateAnimalRequest animal);
    }

    public class AnimalsRepo : IAnimalsRepo
    {
        private readonly ZooManagerDbContext _context;

        public AnimalsRepo(ZooManagerDbContext context)
        {
            _context = context;
        }

        public Animal GetById(int id)
        {
            return _context.Animals.Single(animal => animal.Id == id);
        }

        public Animal Create(CreateAnimalRequest animal)
        {
            var insertResult = _context.Animals.Add(new Animal 
            {
                Name = animal.Name,
                AnimalTypeId = animal.AnimalTypeId,
                Sex = animal.Sex,
                BirthDate =  DateOnly.Parse(animal.BirthDate),
                AcquiredDate =  DateOnly.Parse(animal.AcquiredDate),
            });
            
            _context.SaveChanges();
            return insertResult.Entity;
        }
    }
}