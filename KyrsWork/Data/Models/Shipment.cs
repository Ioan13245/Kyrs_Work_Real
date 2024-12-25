using System.ComponentModel.DataAnnotations;

namespace KyrsWork.Data.Models;

public class Shipment
{
    [Key] public Guid IdShipment { get; set; }
    public DateTime DateTime { get; set; }
   
    public int SupplierId { get; set; }
    public Supplier? Supplier { get; set; }

    public virtual ICollection<Tire> Tires { get; set; } = new List<Tire>(); // Связь с шинами
    public virtual ICollection<Wheel> Wheels { get; set; } = new List<Wheel>(); // Связь с дисками
}
