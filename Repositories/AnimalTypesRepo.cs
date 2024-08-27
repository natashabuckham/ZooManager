using ZooManager.Models.Database;
using ZooManager.Models.Request;

namespace ZooManager.Repositories
{
    public interface IAnimalTypesRepo
    {
        AnimalType GetById(int id);
        AnimalType Create(CreateAnimalTypeRequest animalType);
        IEnumerable<AnimalType> GetAll();
        
    }

    public class AnimalTypesRepo : IAnimalTypesRepo
    {
        private readonly ZooManagerDbContext _context;

        public AnimalTypesRepo(ZooManagerDbContext context)
        {
            _context = context;
        }

        public AnimalType GetById(int id)
        {
            return _context.AnimalTypes.Single(animalType => animalType.Id == id);
        }
        
        public AnimalType Create(CreateAnimalTypeRequest animalType)
        {
            var insertResult = _context.AnimalTypes.Add(new AnimalType 
            {
                Species = animalType.Species,
                Classification = animalType.Classification,
            });
            _context.SaveChanges();
            return insertResult.Entity;
        }

        public IEnumerable<AnimalType> GetAll()
        {
            return _context.AnimalTypes.ToList();
        }
    }
}