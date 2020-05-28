using System;

namespace Planner
{
  class Program
  {
    static void Main(string[] args)
    {
      Building theTaj = new Building();
      theTaj.Name = "The Taj";
      theTaj.Address("1020 Battlefield Dr");
      theTaj.Designer("Fancy Pants Designer");
      theTaj.Constructed();
      theTaj.Width = 2;
      theTaj.Depth = 2;
      theTaj.Stories = 2;
      theTaj.Owner("Mr Big");

      Building theHoopy = new Building();
      theHoopy.Address("1020 Battlefield Dr");
      theHoopy.Designer("Fancy Pants Designer");
      theHoopy.Owner("Mr Big");

      Console.WriteLine(theTaj.GetDescription);
      Console.WriteLine(theHoopy.GetDescription);
    }
  }
}

