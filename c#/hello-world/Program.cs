namespace hello_world;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        PrintRandomNumber randomNumber = new();
        randomNumber.PrintNumber();
        randomNumber.PrintFromPrivate();

        PrintRandomNumberV2 printRandomNumberV2 = new();
        printRandomNumberV2.PrintNumberV2();

        PrintRandomNumberStatic.PrintNumber();
    }

    class PrintRandomNumber {
        readonly Random random = new();

        public void PrintNumber()
        {
            Console.WriteLine("print public : " + random.Next().ToString("N0"));
        }

        private void PrintNumberPrivate()
        {
            Console.WriteLine("print private : " + random.Next().ToString("N0"));
        }

        protected void PrintNumberProtected()
        {
            Console.WriteLine("print protected : " + random.Next().ToString("N0"));
        }

        public void PrintFromPrivate() 
        {
            PrintNumberPrivate();
        }
    }

    class PrintRandomNumberV2 : PrintRandomNumber {
        public void PrintNumberV2()
        {
            PrintNumberProtected();
        }
    }

    static class PrintRandomNumberStatic
    {
        static readonly Random random = new();

        public static void PrintNumber() {
            Console.WriteLine("static : " + random.Next().ToString("N0"));
        }
    }
}
