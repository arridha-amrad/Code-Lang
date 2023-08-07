namespace basic
{
  class StaticKeyword
  {
    // static void Main(string[] args)
    // {
    //   Console.WriteLine("Static Keyword");
    //   Human.Greet();
    //   Human.fullName = "James Coco-Lomell";
    //   Human.Greet();
    // }
  }

  static class Human
  {
    public static string fullName = "Alex-Pulalo";
    private readonly static int age = 27;
    static public void Greet()
    {
      Console.WriteLine($"Hello I'm {fullName}. {age} years old.");
    }
  }
}