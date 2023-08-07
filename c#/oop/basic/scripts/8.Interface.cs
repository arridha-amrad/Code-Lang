// Interface is another way to achieve abstraction
// Can contain properties and methods, NOT fields
// a class can use multiple interfaces

namespace LearnInterface
{
  class Program
  {
    // public static void Main(string[] args)
    // {
    //   Dog dog = new();
    //   dog.MakeSound();
    //   dog.Run();

    //   dog.Breath();
    //   dog.FindFood();
    // }
  }

  interface IAnimal
  {
    void Run();
    void MakeSound();
  }

  interface ILivingCreature
  {
    void FindFood();
    void Breath();
  }

  class Dog : IAnimal, ILivingCreature
  {
    public void Breath()
    {
      Console.WriteLine("Breath... with lungs");
    }

    public void FindFood()
    {
      Console.WriteLine("Eating bones, meat and dog foods");
    }

    public void MakeSound()
    {
      Console.WriteLine("Dog says : bow bow");
    }

    public void Run()
    {
      Console.WriteLine("Dog run!!");
    }
  }
}