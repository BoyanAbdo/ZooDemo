namespace ZooDemo
{
    public interface IAnimal
    {
        string Name { get; }

        int Health { get; set; }

        bool IsAlive { get; }
    }
}
