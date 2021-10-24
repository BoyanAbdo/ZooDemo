namespace ZooDemo
{
    using System;

    public class Bear : Animal
    {
        private bool isAlive;

        public Bear(string name, int health)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Bear's name cannot be null or blank.", name);
            }

            this.Name = name;

            if (health < 0)
            {
                throw new ArgumentException("Bear's health cannot be less than zero.");
            }

            if (health > 100)
            {
                health = 100;
            }

            this.Health = health;

            if (health >= 65)
            {
                isAlive = true;
            }
        }


        public Bear(string name)
            : this(name, 100)
        {
        }

        public Bear()
            : this("-", 100)
        {
        }

        public override bool IsAlive
        {
            get => this.isAlive = this.Health >= 65;
            set
            {
                this.isAlive = this.Health >= 65;
            }
        }
    }
}
