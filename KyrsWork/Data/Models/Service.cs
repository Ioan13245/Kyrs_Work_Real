using System.ComponentModel.DataAnnotations;

namespace KyrsWork.Data.Models
{
    public class Service
    {
        [Key] public int ServiceId { get; set; } // ID услуги
        public string? ServiceName { get; set; } // Название услуги
        public double ServicePrice { get; set; } // Цена за предоставление услуги
        public DateTime ServiceDate { get; set; } // Дата предоставления услуги
        public double Price { get; set; } // Цена услуги
        //соединения
        public int WorkerId { get; set; } // ID работника для соединения
        public Worker? Worker { get; set; }
        public int ClientId { get; set; } // ID клиента для соединения
        public Client? Client { get; set; }
        public int IdTire { get; set; } // ID шины для соединения
        public Tire? Tire { get; set; }
        public int WheelId { get; set; } //ID диска для соединения
        public Wheel? Wheel { get; set; }
    }
}
