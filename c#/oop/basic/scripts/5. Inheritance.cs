class Inheritance
{
  // public static void Main(String[] args)
  // {
  //   Android android = new("Samsung Galaxy", false, "Nugget");
  //   android.UseCall();

  //   IPhone iPhone = new("IPhone 17", true, "IOS-17");
  //   iPhone.UseCall();
  // }
}

class Android : Phone
{
  readonly string OS;
  public Android(string name, bool isFiveGSupport, string OS) : base(name, isFiveGSupport)
  {
    this.OS = OS;
  }

  public void UseCall()
  {
    Call();
  }
}

class IPhone : Phone
{
  readonly string OS;
  public IPhone(string name, bool isFiveGSupport, string OS) : base(name, isFiveGSupport)
  {
    this.OS = OS;
  }

  public void UseCall()
  {
    Call();
  }
}


class Phone
{
  private readonly string name;
  private readonly bool isFiveGSupport;

  public Phone(string name, bool isFiveGSupport)
  {
    this.name = name;
    this.isFiveGSupport = isFiveGSupport;
  }

  protected void Call()
  {
    if (isFiveGSupport)
    {
      Console.WriteLine($"{name} fast call");
    }
    else
    {
      Console.WriteLine($"{name} slow call");
    }
  }
}