using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Bakery.Models
{
  public class Flavor
  {
    public int FlavorId { get; set; }
    [Required(ErrorMessage = "The Flavor's name can't be empty!")]
    public string FlavorName { get; set; }
    public string Description { get; set; }
    public string Instructions { get; set; }
    public string Ingredients { get; set; }
    public List<FlavorTreat> JoinEntities { get; set; }
    public ApplicationUser User { get; set; }
    public int Rating { get; set; }
    public static int CompareFlavorByRating(Flavor x, Flavor y)
    {
      if(x.Rating == y.Rating)
      {
        return 0;
      }
      if(x.Rating > y.Rating)
      {
        return -1;
      }
      if(x.Rating < y.Rating)
      {
        return 1;
      }
      return 0;
    }
  }
}