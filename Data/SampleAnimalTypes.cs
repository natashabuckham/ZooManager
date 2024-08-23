using ZooManager.Models.Database;

namespace ZooManager.Data
{
public static class SampleAnimalTypes
{
    public const int NumberOfAnimalTypes = 14;
    private static readonly IList<IList<string>> Data = new List<IList<string>>
    {
        new List<string> {"cat", "mammal"},
        new List<string> {"lion", "mammal"},
        new List<string> {"penguin", "bird"},
        new List<string> {"frog", "amphibian"},
        new List<string> {"unicorn", "mammal"},
        new List<string> {"panda", "mammal"},
        new List<string> {"dinosaur", "reptile"},
        new List<string> {"shark", "fish"},
        new List<string> {"snake", "reptile"},
        new List<string> {"clownfish", "fish"},
        new List<string> {"turtle", "reptile"},
        new List<string> {"salamander", "amphibians"},
        new List<string> {"parrot", "bird"},
        new List<string> {"butterfly", "insect"}
    };

    public static IEnumerable<AnimalType> GetAnimalTypes()
        {
            return Enumerable.Range(0, NumberOfAnimalTypes).Select(CreateRandomAnimalType);
        }

        private static AnimalType CreateRandomAnimalType(int index)
        {
            return new AnimalType
            {
                Species = Data[index][0],
                Classification = Data[index][1],
            };
        }
    }
}
