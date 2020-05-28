using System;

namespace Planner
{
  class Program
  {
    static void Main(string[] args)
    {
      Building theTaj = new Building();
      theTaj.Address("1020 Battlefield Dr");
      theTaj.Designer("Designer");
      // theTaj.Constructed();
      theTaj.Owner("Mr Big");
      // theTaj.Volume();

      Console.WriteLine(theTaj.Address("A1020 Battlefield Dr"));
      // Console.WriteLine(theTaj.Description());
    }
  }
}
