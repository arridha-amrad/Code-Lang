namespace basic
{
  class Constructor
  {
    // public static void Main(string[] args)
    // {

    //   Car renaultCar = new("Renault", 2010, true);
    //   renaultCar.Run();

    //   Car ferariCar = new("Ferari", 2005, false);
    //   ferariCar.Run();
    // }
  }

  class Car
  {
    private readonly string name;
    private readonly int year;
    private readonly bool isActive;

    public Car(string name, int year, bool isActive)
    {
      this.year = year;
      this.isActive = isActive;
      this.name = name;
    }

    public void Run()
    {
      if (isActive)
      {
        Console.WriteLine($"model: {name}, year: {year} run 🚀");
      }
      else
      {
        Console.WriteLine($"model: {name}, year: {year} cannot run 😞");

      }
    }
  }
}