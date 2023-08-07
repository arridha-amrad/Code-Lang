// Abstract keyword is used for either class and method;
// abstract class -> restricted class which cannot be used to create an object
// abstract method -> a method that only available in abstract class which has no body. The body is provided by derived class

namespace abstraction
{
  class Abstraction
  {

    // public static void Main(String[] args)
    // {
    //   Animal dog = new Dog();
    //   dog.AnimalSound();

    //   Animal cat = new Cat();
    //   cat.AnimalSound();

    //   cat.Sleep();
    //   dog.Sleep();

    // }

  }

  abstract class Animal
  {
    public abstract void AnimalSound();
    public void Sleep()
    {
      Console.WriteLine("zzz");
    }
  }

  class Dog : Animal
  {
    public override void AnimalSound()
    {
      Console.WriteLine("Dog says : bow bow");
    }
  }

  class Cat : Animal
  {
    public override void AnimalSound()
    {
      Console.WriteLine("Cat says : meow meow");

    }
  }
}