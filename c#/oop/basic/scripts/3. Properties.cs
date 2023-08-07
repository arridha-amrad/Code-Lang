namespace basic
{
  class GetSet
  {
    // static void Main(String[] args)
    // {
    //   Hero hero = new()
    //   {
    //     HeroName = "Aegon Targeryan"
    //   };
    //   Console.WriteLine(hero.HeroName);
    //   hero.HeroName = "Aegon Targeryan Sitorus";
    //   Console.WriteLine(hero.HeroName);
    // }
  }

  class Hero
  {
    private string? heroName; // filed
    public string HeroName // property
    {
      get { return heroName ?? ""; }
      set
      {
        if (value.Contains(' '))
        {
          string fixedName = value.Replace(" ", "_");
          heroName = fixedName;
        }
      }
    }
  }
}