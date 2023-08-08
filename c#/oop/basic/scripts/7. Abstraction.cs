// Abstract keyword is used for either class and method;
// abstract class -> restricted class which cannot be used to create an object
// abstract method -> a method that only available in abstract class which has no body. The body is provided by derived class

namespace abstraction
{
  class Abstraction
  {

    public static void Main(String[] args)
    {
      Dog dog = new Dog
      {
        AnimalName = "PitBull"
      };
      dog.AnimalSound();

      Cat cat = new Cat();
      cat.AnimalName = "Persian Cat";
      cat.AnimalSound();

      cat.Sleep();
      dog.Sleep();

    }

  }

  abstract class Animal
  {
    public abstract string AnimalName { get; set; }
    public abstract void AnimalSound();
    public void Sleep()
    {
      Console.WriteLine($"{this.AnimalName} zzz");
    }
  }

  class Dog : Animal
  {
    private string _AnimalName = string.Empty;
    public override string AnimalName
    {
      get => this._AnimalName;
      set
      {
        this._AnimalName = value;
      }
    }

    public override void AnimalSound()
    {
      Console.WriteLine($"Dog name {this._AnimalName} says : bow bow");
    }
  }

  class Cat : Animal
  {
    private string _CatName = string.Empty;
    public override string AnimalName
    {
      get => this._CatName;
      set => this._CatName = value;
    }

    public override void AnimalSound()
    {
      Console.WriteLine($"Cat name {this._CatName} says : meow meow");
    }
  }
}