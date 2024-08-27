using ZooManager.Models.Database;

namespace ZooManager.Data
{
    public static class SampleAnimals
    {
        public const int NumberOfAnimals = 70;
        private static readonly IList<IList<string>> Data = new List<IList<string>>
        {
            new List<string> {"2", "Simba", "M", "24/10/2019", "12/12/2010"},
            new List<string> {"8", "Bruce", "M", "10/10/2003", "17/06/2016"},
            new List<string> {"6", "Panda", "F", "23/08/2024", "23/08/2024"},
            new List<string> {"5", "Ponyta", "M", "15/03/1834", "31/03/2022"},
            new List<string> {"4", "Croakie", "F", "23/06/2019", "14/07/2019"},
            new List<string> {"5", "Ruby", "F", "22/08/2020", "30/09/2020"},
            new List<string> {"1", "Chloe", "F", "12/03/2022", "01/05/2022"},
            new List<string> {"8", "Finn", "M", "19/05/2021", "10/07/2021"},
            new List<string> {"2", "Max", "M", "25/08/2018", "10/10/2018"},
            new List<string> {"12", "Oscar", "M", "15/11/2019", "10/12/2019"},
            new List<string> {"3", "Luna", "F", "14/02/2019", "01/04/2019"},
            new List<string> {"7", "Dragon", "M", "14/09/1001", "01/11/2020"},
            new List<string> {"14", "Sam", "F", "07/04/2024", "08/04/2024"},
            new List<string> {"14", "Lily", "F", "07/12/2024", "08/04/2024"},
            new List<string> {"13", "Jack", "M", "18/03/2018", "23/01/2020"},
            new List<string> {"13", "Tuk", "M", "21/05/2016", "01/04/2021"},
            new List<string> {"11", "Zoe", "F", "01/03/2018", "10/03/2018"},
            new List<string> {"9", "Coco", "F", "09/05/2017", "30/07/2017"},
            new List<string> {"13", "Polly", "F", "02/07/2021", "09/09/2021"},
            new List<string> {"10", "Buddy", "M", "28/01/2022", "01/03/2022"},
            new List<string> {"6", "Rocky", "M", "18/07/2020", "05/09/2020"},
            new List<string> {"14", "Toby", "M", "21/02/2019", "15/04/2019"},
            new List<string> {"4", "Charlie", "M", "30/03/2017", "20/05/2017"},
            new List<string> {"3", "Zeus", "M", "31/10/2017", "05/12/2017"},
            new List<string> {"11", "Molly", "F", "05/10/2020", "20/12/2020"},
            new List<string> {"1", "Bella", "F", "15/04/2020", "01/06/2020"},
            new List<string> {"7", "Daisy", "F", "01/12/2019", "15/01/2020"},
            new List<string> {"8", "Milo", "M", "11/06/2018", "22/07/2018"},
            new List<string> {"5", "Lucy", "F", "22/09/2021", "01/11/2021"},
            new List<string> {"1", "Rex", "M", "01/01/2020", "05/03/2020"},
            new List<string> {"2", "Bella", "F", "03/03/2019", "01/06/2019"},
            new List<string> {"3", "Duke", "M", "14/04/2018", "22/08/2018"},
            new List<string> {"5", "Shadow", "M", "09/09/2017", "10/10/2017"},
            new List<string> {"6", "Misty", "F", "11/11/2019", "05/12/2019"},
            new List<string> {"7", "Thor", "M", "02/02/2020", "10/04/2020"},
            new List<string> {"8", "Fluffy", "F", "05/05/2018", "07/07/2018"},
            new List<string> {"9", "Sam", "M", "01/10/2017", "11/11/2017"},
            new List<string> {"10", "Poppy", "F", "12/08/2016", "15/09/2016"},
            new List<string> {"11", "Bolt", "M", "01/01/2021", "22/02/2021"},
            new List<string> {"12", "Snowy", "F", "13/03/2020", "17/04/2020"},
            new List<string> {"13", "Tank", "M", "05/05/2019", "09/06/2019"},
            new List<string> {"14", "Maggie", "F", "20/07/2018", "18/08/2018"},
            new List<string> {"1", "Blue", "M", "11/10/2020", "01/12/2020"},
            new List<string> {"2", "Zara", "F", "09/09/2017", "14/11/2017"},
            new List<string> {"3", "Hank", "M", "06/06/2016", "22/08/2016"},
            new List<string> {"4", "Willow", "F", "25/12/2019", "15/02/2020"},
            new List<string> {"5", "Gunner", "M", "07/04/2017", "01/06/2017"},
            new List<string> {"6", "Hazel", "F", "18/08/2018", "25/09/2018"},
            new List<string> {"7", "Ace", "M", "11/11/2021", "15/01/2022"},
            new List<string> {"8", "Clover", "F", "03/07/2019", "11/08/2019"},
            new List<string> {"9", "Jax", "M", "21/03/2020", "19/04/2020"},
            new List<string> {"10", "Maisie", "F", "14/01/2019", "17/02/2019"},
            new List<string> {"11", "Thor", "M", "22/08/2020", "25/09/2020"},
            new List<string> {"12", "Sadie", "F", "03/04/2017", "10/05/2017"},
            new List<string> {"13", "Rusty", "M", "14/06/2019", "17/07/2019"},
            new List<string> {"14", "Lily", "F", "12/02/2016", "25/04/2016"},
            new List<string> {"1", "Boomer", "M", "30/09/2020", "10/11/2020"},
            new List<string> {"2", "Cleo", "F", "18/03/2018", "01/05/2018"},
            new List<string> {"3", "Maximus", "M", "04/07/2017", "12/08/2017"},
            new List<string> {"4", "Roxy", "F", "29/10/2019", "01/12/2019"},
            new List<string> {"5", "Bear", "M", "22/05/2019", "15/07/2019"},
            new List<string> {"6", "Penny", "F", "07/11/2018", "01/01/2019"},
            new List<string> {"7", "Toby", "M", "14/08/2020", "28/09/2020"},
            new List<string> {"8", "Mia", "F", "22/02/2021", "05/04/2021"},
            new List<string> {"9", "Gizmo", "M", "15/09/2017", "02/11/2017"},
            new List<string> {"10", "Rosie", "F", "08/03/2019", "05/05/2019"},
            new List<string> {"11", "Ranger", "M", "30/06/2018", "01/08/2018"},
            new List<string> {"12", "Lola", "F", "23/05/2019", "15/07/2019"},
            new List<string> {"13", "Koda", "M", "17/10/2020", "22/12/2020"},
            new List<string> {"14", "Finn", "M", "01/03/2019", "03/04/2019"},
        };

        public static IEnumerable<Animal> GetAnimals()
        {
            return Enumerable.Range(0, NumberOfAnimals).Select(CreateRandomAnimal);
        }

        private static Animal CreateRandomAnimal(int index)
        {
            return new Animal
            {
                AnimalTypeId = int.Parse(Data[index][0]),
                Name = Data[index][1],
                Sex = Data[index][2],
                BirthDate = DateOnly.Parse(Data[index][3]),
                AcquiredDate = DateOnly.Parse(Data[index][4]),
            };
        }
    }
}