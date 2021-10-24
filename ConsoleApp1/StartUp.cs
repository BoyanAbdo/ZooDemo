namespace ZooDemo
{
    using System;
    using System.Collections.Generic;

    public static class StartUp
    {
        // The zoo starts with 10 animals for each species
        public const int animal_count = 10;

        public const int cycles_count = 7;

        static void Main()
        {
            Console.WriteLine("Welcome to our Zoo Demo");
            Console.WriteLine("-----------------------");

            var zoo = new Zoo();
            zoo.GenerateZoo(animal_count, animal_count, animal_count);

            // print initial info
            PrintZooStats(zoo);
            
            // Make {cycles_count} cycles of Hunger and Feed
            IterateFeedHungerCycles(zoo, cycles_count);
        }

        private static void IterateFeedHungerCycles(Zoo zoo, int cyclesCount)
        {
            for (int i = 0; i < cyclesCount; i++)
            {
                zoo.LetsGetAllTheAnimalsHungry();
                zoo.FeedAllTheAnimals();

                Console.WriteLine($"Statistics after {i + 1} cycle(s) of Hunger and Feed");
                PrintZooStats(zoo);
            }
        }

        private static void PrintZooStats(Zoo zoo)
        {
            Console.WriteLine("List of Monkeys in the Zoo:");
            PrintAnimalGroupInfo(zoo.monkeys);
            Console.WriteLine($"Count of all alive monkeys: {zoo.GetAllAliveAnimalsCountInAGroup(zoo.monkeys)}");
            Console.WriteLine($"Get the minimum health in the group: {zoo.GetTheMinimumHealthInAGroup(zoo.monkeys)}");
            Console.WriteLine();

            Console.WriteLine("List of Giraffes in the Zoo:");
            PrintAnimalGroupInfo(zoo.giraffes);
            Console.WriteLine($"Count of all alive giraffes: {zoo.GetAllAliveAnimalsCountInAGroup(zoo.giraffes)}");
            Console.WriteLine($"Get the minimum health in the group: {zoo.GetTheMinimumHealthInAGroup(zoo.giraffes)}");
            Console.WriteLine();

            Console.WriteLine("List of Bears in the Zoo:");
            PrintAnimalGroupInfo(zoo.bears);
            Console.WriteLine($"Count of all alive bears: {zoo.GetAllAliveAnimalsCountInAGroup(zoo.bears)}");
            Console.WriteLine($"Get the minimum health in the group: {zoo.GetTheMinimumHealthInAGroup(zoo.bears)}");
            Console.WriteLine();
        }

        private static void PrintAnimalGroupInfo(IEnumerable<Animal> animals)
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine(String.Format("   {0,-13} | {1,3} | {2,-1}", "Name", "Health", "Is Alive?"));
            Console.WriteLine("-------------------------------------");
            foreach (var animal in animals)
            {
                Console.WriteLine(String.Format("   {0,-20} | {1,3} | {2,-1}", animal.Name, animal.Health, animal.IsAlive));

            }
            Console.WriteLine("-------------------------------------");
        }
    }
}
