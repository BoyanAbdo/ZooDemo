namespace ZooDemo
{
    using System;

    public class Giraffe : Animal
    {
        private bool isAlive;

        public Giraffe(string name, int health)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Giraffe's name cannot be null or blank.", name);
            }

            this.Name = name;

            if (health < 0)
            {
                throw new ArgumentException("Giraffe's health cannot be less than zero.");
            }

            if (health > 100)
            {
                health = 100;
            }

            this.Health = health;

            if (health >= 60)
            {
                this.isAlive = true;
            }
        }


        public Giraffe(string name)
            : this(name, 100)
        {
        }

        public Giraffe()
            : this("-", 100)
        {
        }

        public override bool IsAlive
        {
            get => this.isAlive = this.Health >= (60 - 15);
            set
            {
                this.isAlive = this.Health >= (60 - 15);
            }
        }
    }
}
