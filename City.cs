using System;
using System.Collections.Generic;

namespace Planner
{
  public class City
  {
    public string Name { get; set; }
    public string Mayor { get; set; }
    public DateTime DateEstablished { get; set; }

    public List<Building> Buildings { get; } = new List<Building>();

    public void AddBuilding(Building buildingToAdd) {
      Buildings.Add(buildingToAdd);
    }

    public string GetCityDescription
    {
      get
      {
        return
        @$"
---------------------------------------------------
|  City:        | {Name}
|  Mayor:       | {Mayor}
|  Date & Time: | {DateEstablished}
---------------------------------------------------
        ";
      }
    }

  }
}
