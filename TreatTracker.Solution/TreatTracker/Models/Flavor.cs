using System;
using System.Collections.Generic;

namespace TreatTracker.Models
{
  public class Flavor
  {
    public int FlavorId { get; set; }
    public string Type { get; set; }
    public virtual ApplicationUser User { get; set; }
    public ICollection<TreatFlavor> Treats { get; set; }

    public Flavor()
    {
      this.Treats = new HashSet<TreatFlavor>();
    }

  }
}