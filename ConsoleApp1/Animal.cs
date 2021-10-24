namespace ZooDemo
{
    using System;

    public abstract class Animal : IAnimal
    {
        protected int health;

        public string Name { get; set; }

        public virtual bool IsAlive { get; set; } = false;

        // Each animal has a health value, represented by points in the range from 0 to 100.
        public int Health
        {
            get => this.health;
            set
            {
                if (value < 0)
                {
                    value = 0;
                }

                health = Math.Min(100, value);
            }
        }
    }
}
