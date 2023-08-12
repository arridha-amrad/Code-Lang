namespace Enumerations
{
   class Program
   {
      // public static void Main(string[] args)
      // {
      //   // int android = (int)Android.Tiramisu;
      //   // Console.WriteLine(android);

      //   Android android = Android.Nougat;
      //   Android androidTwo = Android.Pie;

      //   Console.WriteLine(android);
      //   Console.WriteLine(androidTwo);

      //   FiveGSupport(android);
      //   FiveGSupport(androidTwo);
      // }

      private static void FiveGSupport(Android android)
      {
         switch (android)
         {
            case Android.Pie:
               Console.WriteLine("supported");
               break;
            case Android.Tiramisu:
               Console.WriteLine("supported");
               break;
            default:
               Console.WriteLine("unSupported");
               break;
         }
      }
   }

   enum Android
   {
      Lollipop,
      Nougat,
      Oreo,
      Pie,
      Tiramisu,
   }
}