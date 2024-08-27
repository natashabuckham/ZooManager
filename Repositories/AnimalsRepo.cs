using ZooManager.Models.Database;
using ZooManager.Models.Request;

namespace ZooManager.Repositories
{
    public interface IAnimalsRepo
    {
        Animal GetById(int id);
        Animal Create(CreateAnimalRequest animal);
        IEnumerable<Animal> Search(AnimalSearchRequest search);
        public int Count(AnimalSearchRequest search);
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

        public IEnumerable<Animal> Search(AnimalSearchRequest search)
        {
            return _context.Animals
                .Where(animal => search.Search == null ||
                    (
                        animal.AnimalType.Species.ToLower().Contains(search.Search) ||
                        animal.AnimalType.Classification.ToLower().Contains(search.Search) ||
                        animal.Name.ToLower().Contains(search.Search) ||
                        // age
                        animal.BirthDate.ToString().Contains(search.Search) ||
                        animal.AcquiredDate.ToString().Contains(search.Search) 
                    ))
                .OrderBy(s => s.AnimalType.Species)
                .Skip((search.Page - 1) * search.PageSize)
                .Take(search.PageSize);
        }

        public int Count(AnimalSearchRequest search)
        {
            return _context.Animals
                .Count(animal => search.Search == null ||
                    (
                        animal.AnimalType.Species.ToLower().Contains(search.Search) ||
                        animal.AnimalType.Classification.ToLower().Contains(search.Search) ||
                        animal.Name.ToLower().Contains(search.Search) ||
                        // age
                        animal.BirthDate.ToString().Contains(search.Search) ||
                        animal.AcquiredDate.ToString().Contains(search.Search) 
                    ));
        }
    }
}