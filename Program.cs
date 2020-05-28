using System;

namespace Planner
{
  class Program
  {
    static void Main(string[] args)
    {
      Building theTaj = new Building();
      theTaj.Address("1020 Battlefield Dr");
      theTaj.Designer("Fancy Pants Designer");
      // theTaj.Constructed("DateTime.Now");
      theTaj.Owner("Mr Big");
      theTaj.SetVolume(2, 2, 2);

      // Console.WriteLine(theTaj.GetAddress());
      Console.WriteLine(theTaj.GetDescription);
    }
  }
}

