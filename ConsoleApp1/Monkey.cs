namespace ZooDemo
{
    using System;

    public class Monkey : Animal
    {
        private bool isAlive;

        public Monkey(string name, int health)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Monkey's name cannot be null or blank.", name);
            }

            this.Name = name;

            if (health < 0)
            {
                throw new ArgumentException("Monkey's health cannot be less than zero.");
            }

            if (health > 100)
            {
                health = 100;
            }

            this.Health = health;

            if (health >= 40)
            {
                this.isAlive = true;
            }
        }

        public Monkey(string name)
            : this(name, 100)
        {
        }

        public Monkey()
            : this("-", 100)
        {
        }


        public override bool IsAlive
        {
            get => this.isAlive = this.Health >= 40;
            set
            {
                this.isAlive = this.Health >= 40;
            }
        }
    }
}
