using System.ComponentModel.DataAnnotations;

namespace KyrsWork.Data.Models
{
    public class Wheel
    {
        [Key] public Guid WheelId { get; set; }
        public string? WheelManufacturer { get; set; } // Производитель
        public string? WheelModel { get; set; } // Модель диска
        public double WheelDiameter { get; set; } // Диаметр диска
        public double WheelLoadCapacity { get; set; } // Грузоподъёмность диска
        public double WheelWeight { get; set; } // Вес
        public double WheelPrice { get; set; } // Цена
        public DateTime ProductionDate { get; set; } // Дата производства
        public int SupplierId { get; set; } // Поставщик для связи
        public Supplier? Supplier { get; set; }
        public Guid ServiceId { get; set; } // ID услуги для связи
        public Service? Service { get; set; } // Связь с услугой
        public Guid IdShipment {  get; set; }
        public Shipment? Shipment { get; set; }
    }
}
