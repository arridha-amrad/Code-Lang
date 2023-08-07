// Polymorphism means "many forms"
// "virtual" keyword to base class's method
// "override" keyword to derived class's method

class Polymorphism
{
  // public static void Main(string[] args)
  // {

  //   Animal animal = new();
  //   animal.MakeSound();

  //   Animal dog = new Dog();
  //   dog.MakeSound();

  //   Animal cat = new Cat();
  //   cat.MakeSound();

  // }
}

class Animal
{
  public virtual void MakeSound()
  {
    Console.WriteLine("Animal make sound");
  }
}

class Dog : Animal
{
  public override void MakeSound()
  {
    Console.WriteLine("Dog says : bow bow");
  }
}

class Cat : Animal
{
  public override void MakeSound()
  {
    Console.WriteLine("Cat says : meow meow");
  }
}