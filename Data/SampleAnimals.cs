using ZooManager.Models.Database;

namespace ZooManager.Data
{
    public static class SampleAnimals
    {
        public const int NumberOfAnimals = 100;
        private static readonly IList<IList<string>> Data = new List<IList<string>>
        {
            new List<string> {"2", "Simba", "M", "24/10/2019", "12/12/2010"},
            new List<string> {"8", "Bruce", "M", "10/10/2003", "17/06/2016"},
            new List<string> {"6", "Panda", "F", "23/08/2024", "23/08/2024"},
            new List<string> {"5", "Ponyta", "M", "15/03/1834", "31/03/2022"},
            new List<string> {"4", "Croakie", "F", "23/06/2019", "14/07/2019"},
            new List<string> {"5", "Ruby", "F", "08/22/2020", "09/30/2020"},
            new List<string> {"1", "Chloe", "F", "03/12/2022", "05/01/2022"},
            new List<string> {"8", "Finn", "M", "05/19/2021", "07/10/2021"},
            new List<string> {"2", "Max", "M", "08/25/2018", "10/10/2018"},
            new List<string> {"12", "Oscar", "M", "11/15/2019", "12/10/2019"},
            new List<string> {"3", "Luna", "F", "02/14/2019", "04/01/2019"},
            new List<string> {"7", "Dragon", "M", "09/14/1001", "11/01/2020"},
            new List<string> {"14", "Sam", "F", "04/07/2024", "04/08/2024"},
            new List<string> {"14", "Lily", "F", "12/07/2024", "04/08/2024"},
            new List<string> {"13", "Jack", "M", "18/03/2018", "23/01/2020"},
            new List<string> {"13", "Tuk", "M", "21/05/2016", "01/04/2021"},
            new List<string> {"11", "Zoe", "F", "01/03/2018", "03/10/2018"},
            new List<string> {"9", "Coco", "F", "05/09/2017", "07/30/2017"},
            new List<string> {"13", "Polly", "F", "07/02/2021", "09/09/2021"},
            new List<string> {"10", "Buddy", "M", "01/28/2022", "03/01/2022"},
            new List<string> {"6", "Rocky", "M", "07/18/2020", "09/05/2020"},
            new List<string> {"14", "Toby", "M", "02/21/2019", "04/15/2019"},
            new List<string> {"4", "Charlie", "M", "03/30/2017", "05/20/2017"},
            new List<string> {"3", "Zeus", "M", "10/31/2017", "12/05/2017"},
            new List<string> {"11", "Molly", "F", "10/05/2020", "12/20/2020"},
            new List<string> {"1", "Bella", "F", "04/15/2020", "06/01/2020"},
            new List<string> {"7", "Daisy", "F", "12/01/2019", "01/15/2020"},
            new List<string> {"8", "Milo", "M", "06/11/2018", "07/22/2018"},
            new List<string> {"5", "Lucy", "F", "09/22/2021", "11/01/2021"},
            new List<string> {"1", "Rex", "M", "01/01/2020", "03/05/2020"},
            new List<string> {"2", "Bella", "F", "03/03/2019", "06/01/2019"},
            new List<string> {"3", "Duke", "M", "04/14/2018", "08/22/2018"},
            new List<string> {"5", "Shadow", "M", "09/09/2017", "10/10/2017"},
            new List<string> {"6", "Misty", "F", "11/11/2019", "12/05/2019"},
            new List<string> {"7", "Thor", "M", "02/02/2020", "04/10/2020"},
            new List<string> {"8", "Fluffy", "F", "05/05/2018", "07/07/2018"},
            new List<string> {"9", "Sam", "M", "10/01/2017", "11/11/2017"},
            new List<string> {"10", "Poppy", "F", "08/12/2016", "09/15/2016"},
            new List<string> {"11", "Bolt", "M", "01/01/2021", "02/22/2021"},
            new List<string> {"12", "Snowy", "F", "03/13/2020", "04/17/2020"},
            new List<string> {"13", "Tank", "M", "05/05/2019", "06/09/2019"},
            new List<string> {"14", "Maggie", "F", "07/20/2018", "08/18/2018"},
            new List<string> {"1", "Blue", "M", "10/11/2020", "12/01/2020"},
            new List<string> {"2", "Zara", "F", "09/09/2017", "11/14/2017"},
            new List<string> {"3", "Hank", "M", "06/06/2016", "08/22/2016"},
            new List<string> {"4", "Willow", "F", "12/25/2019", "02/15/2020"},
            new List<string> {"5", "Gunner", "M", "04/07/2017", "06/01/2017"},
            new List<string> {"6", "Hazel", "F", "08/18/2018", "09/25/2018"},
            new List<string> {"7", "Ace", "M", "11/11/2021", "01/15/2022"},
            new List<string> {"8", "Clover", "F", "07/03/2019", "08/11/2019"},
            new List<string> {"9", "Jax", "M", "03/21/2020", "04/19/2020"},
            new List<string> {"10", "Maisie", "F", "01/14/2019", "02/17/2019"},
            new List<string> {"11", "Thor", "M", "08/22/2020", "09/25/2020"},
            new List<string> {"12", "Sadie", "F", "04/03/2017", "05/10/2017"},
            new List<string> {"13", "Rusty", "M", "06/14/2019", "07/17/2019"},
            new List<string> {"14", "Lily", "F", "02/12/2016", "04/25/2016"},
            new List<string> {"1", "Boomer", "M", "09/30/2020", "11/10/2020"},
            new List<string> {"2", "Cleo", "F", "03/18/2018", "05/01/2018"},
            new List<string> {"3", "Maximus", "M", "07/04/2017", "08/12/2017"},
            new List<string> {"4", "Roxy", "F", "10/29/2019", "12/01/2019"},
            new List<string> {"5", "Bear", "M", "05/22/2019", "07/15/2019"},
            new List<string> {"6", "Penny", "F", "11/07/2018", "01/01/2019"},
            new List<string> {"7", "Toby", "M", "08/14/2020", "09/28/2020"},
            new List<string> {"8", "Mia", "F", "02/22/2021", "04/05/2021"},
            new List<string> {"9", "Gizmo", "M", "09/15/2017", "11/02/2017"},
            new List<string> {"10", "Rosie", "F", "03/08/2019", "05/05/2019"},
            new List<string> {"11", "Ranger", "M", "06/30/2018", "08/01/2018"},
            new List<string> {"12", "Lola", "F", "05/23/2020", "07/03/2020"},
            new List<string> {"13", "Buster", "M", "11/05/2017", "12/17/2017"},
            new List<string> {"14", "Zoey", "F", "04/19/2019", "05/15/2019"},
            new List<string> {"1", "Whiskey", "M", "03/11/2018", "05/05/2018"},
            new List<string> {"2", "Riley", "F", "01/30/2021", "02/15/2021"},
            new List<string> {"3", "Koda", "M", "07/07/2019", "09/15/2019"},
            new List<string> {"4", "Ellie", "F", "02/22/2018", "04/14/2018"},
            new List<string> {"5", "Cooper", "M", "11/13/2020", "12/05/2020"},
            new List<string> {"6", "Stella", "F", "09/17/2019", "11/02/2019"},
            new List<string> {"7", "Remy", "M", "10/25/2021", "12/10/2021"},
            new List<string> {"8", "Ruby", "F", "04/20/2018", "06/01/2018"},
            new List<string> {"10", "Harley", "F", "05/05/2021", "06/20/2021"},
            new List<string> {"11", "Scout", "M", "02/01/2020", "03/15/2020"},
            new List<string> {"13", "Ollie", "M", "12/12/2018", "02/02/2019"},
            new List<string> {"14", "Sophie", "F", "06/06/2017", "07/17/2017"},
            new List<string> {"1", "Murphy", "M", "01/11/2022", "03/01/2022"},
            new List<string> {"2", "Nala", "F", "02/24/2017", "04/05/2017"},
            new List<string> {"3", "Tucker", "M", "09/15/2020", "10/31/2020"},
            new List<string> {"4", "Phoebe", "F", "03/12/2018", "05/22/2018"},
            new List<string> {"5", "Chase", "M", "06/22/2019", "08/14/2019"},
            new List<string> {"6", "Molly", "F", "12/01/2021", "01/22/2022"},
            new List<string> {"7", "Ryder", "M", "04/03/2018", "06/02/2018"},
            new List<string> {"8", "Ginger", "F", "08/19/2020", "10/07/2020"},
            new List<string> {"1", "Archie", "M", "01/02/2021", "03/15/2021"},
            new List<string> {"2", "Lulu", "F", "05/10/2018", "07/01/2018"},
            new List<string> {"3", "Moose", "M", "02/21/2020", "04/03/2020"},
            new List<string> {"4", "Zoe", "F", "03/30/2019", "05/14/2019"},
            new List<string> {"5", "Bruno", "M", "09/09/2017", "10/10/2017"},
            new List<string> {"6", "Olive", "F", "06/11/2020", "07/22/2020"},
            new List<string> {"7", "Gus", "M", "12/05/2019", "01/20/2020"},
            new List<string> {"8", "Pearl", "F", "04/14/2021", "05/30/2021"},
            new List<string> {"9", "Diesel", "M", "08/25/2019", "10/01/2019"},
            new List<string> {"10", "Lily", "F", "07/19/2018", "08/25/2018"}
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
                // This parsing to DateOnly is not working, rejected by the database
                BirthDate = DateOnly.Parse(Data[index][3]),
                AcquiredDate = DateOnly.Parse(Data[index][4]),
            };
        }
    }
}