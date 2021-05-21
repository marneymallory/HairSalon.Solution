using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Stylist
  {
    public Stylist()
    {
      this.Clients = new HashSet<Stylist>();
    }

    public int StylistId { get; set; }
    
    public string Name { get; set; }
    public string Description { get; set; }
    public string Specialty { get; set; }
    public virtual ICollection<Client> Clients { get; set; }
  }
}