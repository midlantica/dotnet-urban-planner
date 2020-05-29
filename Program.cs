using System;
using System.Collections.Generic;

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

      //Building 3
      // Building JacksonHospital = new Building()
      // {
      //   Name = "Jackson Hospital",
      //   _address = "101 Jackson Dr",
      //   Owner = "Fred Williams",
      //   Width = 50_000,
      //   Depth = 50_000,
      //   Stories = 10,
      //   Designer = "PUblic Architecture Co."
      // };

      // Write it out
      Console.WriteLine(theTaj.GetBuildingDescription);
      Console.WriteLine(theHoopy.GetBuildingDescription);

      // City >>>>>>>>>>>>>>>
      City Nashville = new City();
      Nashville.Name = "Nashville";
      Nashville.Mayor = "Jim Flannagan";
      Nashville.DateEstablished = DateTime.Now;
      Nashville.AddBuilding(theTaj);


      City Chattanooga = new City();
      City Knoxville = new City();
      City Franklin = new City();
      City Memphis = new City();

      Console.WriteLine(Nashville.GetCityDescription);

      List<string> buildings = new List<string>();
      buildings.Add("Martin's BBQ");
      buildings.Add("Edleys' BBQ");
      buildings.Add("Peg Leg Porker");
      buildings.Add("Jack's BBQ");

      Console.WriteLine($"{Nashville.Name}'s BBQ Joints");

      foreach (Building building in Nashville.Buildings) {
        Console.WriteLine(building.GetBuildingDescription);
      }

    }
  }
}

