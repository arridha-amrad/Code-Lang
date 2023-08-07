namespace basic
{
  class AccessModifier
  {
    // static void Main(string[] args)
    // {
    //   Salary salary = new();
    //   salary.GetSalaryPublic();
    //   salary.GetFutureSalary();

    //   ProtectedSalary protectedSalary = new();
    //   protectedSalary.GetEmployeeSalary();
    // }
  }

  class Salary
  {
    readonly Random random = new();

    public void GetSalaryPublic()
    {
      Console.WriteLine("public : " + random.Next().ToString("N0"));
    }

    private void GetSalaryPrivate()
    {
      Console.WriteLine("private : " + random.Next().ToString("N0"));
    }

    protected void GetSalaryProtected()
    {
      Console.WriteLine($"protected : {random.Next():N0}");
    }

    public void GetFutureSalary()
    {
      GetSalaryPrivate();
    }
  }

  class ProtectedSalary : Salary
  {
    public void GetEmployeeSalary()
    {
      GetSalaryProtected();
    }
  }

};