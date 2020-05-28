using System;

namespace Planner
{
  class Program
  {
    static void Main(string[] args)
    {
      // Building 1
      Building theTaj = new Building();
      theTaj.Name = "The Taj Restaurant";
      theTaj.Address("3943 Nolensville Pike");
      theTaj.Owner("Mr G. Singh");
      theTaj.Width = 15_000;
      theTaj.Depth = 20_000;
      theTaj.Stories = 15;
      theTaj.Designer("John Smith Construction Co.");
      theTaj.Constructed();

      // Building 2
      Building theHoopy = new Building();
      theHoopy.Name = "The Hoopy Building";
      theHoopy.Address("64 Hoopsville Dr");
      theHoopy.Owner("Harold Williams");
      theHoopy.Width = 20_000;
      theHoopy.Depth = 30_000;
      theHoopy.Stories = 3;
      theHoopy.Designer("Fancy Architecture Co.");

      // Write it out
      Console.WriteLine(theTaj.GetDescription);
      Console.WriteLine(theHoopy.GetDescription);
    }
  }
}

