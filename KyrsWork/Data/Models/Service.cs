using System.ComponentModel.DataAnnotations;

namespace KyrsWork.Data.Models
{
    public class Service
    {
        [Key] public Guid ServiceId { get; set; } // ID услуги
        public string? ServiceName { get; set; } // Название услуги
        public double ServicePrice { get; set; } // Цена за предоставление услуги
        public DateTime ServiceDate { get; set; } // Дата предоставления услуги
        public double Price { get; set; } // Цена услуги
        //соединения
        public int WorkerId { get; set; } // ID работника для соединения
        public Worker? Worker { get; set; }
        public int ClientId { get; set; } // ID клиента для соединения
        public Client? Client { get; set; }
        //Списки шин и дисков
        public virtual ICollection<Tire> Tires { get; set; } = new List<Tire>();
        public virtual ICollection<Wheel> Wheels { get; set; } = new List<Wheel>();
    }
}

