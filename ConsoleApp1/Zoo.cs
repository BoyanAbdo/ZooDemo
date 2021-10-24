namespace ZooDemo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Zoo
    {
        public List<Monkey> monkeys = new List<Monkey>();

        public List<Giraffe> giraffes = new List<Giraffe>();

        public List<Bear> bears = new List<Bear>();

        // ... other animal groups can continue here ...

        public List<Animal> allAnimals = new List<Animal>();
      

        /// <summary>
        /// Generates full Zoological Garden with given number of animals
        /// </summary>
        /// <param name="monkeysCount"></param>
        /// <param name="giraffesCount"></param>
        /// <param name="bearsCount"></param>
        public void GenerateZoo(int monkeysCount, int giraffesCount, int bearsCount)
        {
            for (int i = 0; i < monkeysCount; i++)
            {
                string randomMonkeyName = "Hairy Bonobo";

                var monkeyToAdd = new Monkey(randomMonkeyName + $" {i + 1}");
                this.monkeys.Add(monkeyToAdd);
            }

            for (int i = 0; i < giraffesCount; i++)
            {
                string randomGiraffeName = "West African Dude";

                var giraffeToAdd = new Giraffe(randomGiraffeName + $" {i + 1}");
               this.giraffes.Add(giraffeToAdd);
            }

            for (int i = 0; i < bearsCount; i++)
            {
                string randomBearName = "Black Bear Guy";

                var bearToAdd = new Bear(randomBearName + $" {i + 1}");
                this.bears.Add(bearToAdd);
            }

            this.allAnimals.AddRange(this.monkeys);
            this.allAnimals.AddRange(this.giraffes);
            this.allAnimals.AddRange(this.bears);
        }


        /// <summary>
        /// Feeding top 90% (using floor rounding) of an animal group sorted by health points in ascending order
        /// </summary>
        /// <param name="animals"></param>
        public void FeedGroupOfAnimals(IEnumerable<Animal> animals)
        {
            Random random = new Random();

            int desiredCountToBeTaken = (int)Math.Floor(0.9 * animals.Count());

            var sortedAnimals = animals
                .OrderBy(a => a.Health)
                .Take(desiredCountToBeTaken)
                .ToList();

            foreach (var animal in animals.Where(a => a.IsAlive))
            {
                // for each animal a random value between 10 and 25
                // is generated and used to increase that animal's health
                int randomInt = random.Next(10, 25);

                animal.Health += randomInt;
            }
        }

        /// <summary>
        /// Feeding top 90% (using floor rounding) of all the animals sorted by health points in ascending order
        /// </summary>
        public void FeedAllTheAnimals()
        {
            this.FeedGroupOfAnimals(this.monkeys);
            this.FeedGroupOfAnimals(this.giraffes);
            this.FeedGroupOfAnimals(this.bears);
        }

        /// <summary>
        /// A method to simulate a group of animals getting hungry
        /// </summary>
        /// <param name="animals"></param>
        public void LetsGetGroupOfAnimalsHungry(IEnumerable<Animal> animals)
        {
            // for each of the three species a random value between 15 and 35 is generated
            Random random = new Random();
            int randomInt = random.Next(15, 35);

            foreach (var animal in animals.Where(a => a.IsAlive))
            {
                animal.Health -= randomInt;
            }
        }

        /// <summary>
        /// A method to simulate all the animals getting hungry
        /// </summary>
        public void LetsGetAllTheAnimalsHungry()
        {
            this.LetsGetGroupOfAnimalsHungry(this.monkeys);
            this.LetsGetGroupOfAnimalsHungry(this.giraffes);
            this.LetsGetGroupOfAnimalsHungry(this.bears);
        }

        /// <summary>
        /// Get a list of all alive animals in the zoo
        /// </summary>
        /// <returns>Returns IEnumerable<Animal></returns>
        public IEnumerable<Animal> GetAllAliveAnimals()
        {
            return this.allAnimals.Where(a => a.IsAlive);
        }

        /// <summary>
        /// Get the number of all animals still alive in the zoo
        /// </summary>
        /// <returns>Returns an integer number</returns>
        public int GetAllAliveAnimalsCount()
        {
            return this.allAnimals.Where(a => a.IsAlive).Count();
        }

        /// <summary>
        /// Get the number of all animals still alive in a group
        /// </summary>
        /// <returns>Returns an integer number</returns>
        public int GetAllAliveAnimalsCountInAGroup(IEnumerable<Animal> animals)
        {
            return animals.Where(a => a.IsAlive).Count();
        }

        public string GetTheMinimumHealthInAGroup(IEnumerable<Animal> animals)
        {
            try
            {
                return animals.Where(a => a.IsAlive).Min(a => a.Health).ToString();
            }
            catch
            {
                return "No one is alive :(";
            }

        }
    }
}
