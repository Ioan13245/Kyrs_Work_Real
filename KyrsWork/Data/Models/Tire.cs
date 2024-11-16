using System.ComponentModel.DataAnnotations;

namespace KyrsWork.Data.Models
{
    public class Tire
    {
        [Key] public int IdTire { get; set; } // ID шины
        public double Width { get; set; } // Ширина шины
        public double TireLoadCapacity { get; set; } // Грузоподъёмность
        public string? TireManufacturer { get; set; } // Производитель
        public string? Season { get; set; } // Сезон
        public bool IsUsed { get; set; } // Б/У
        public double TirePrice { get; set; } // Цена
        public DateTime ProductionDate { get; set; } // Дата производства
        public DateTime ExpirationDate { get; set; } // Срок годности
        public int SupplierId { get; set; } // Поставщик для связи
        public Supplier? Supplier { get; set; }
        public int ServiceId { get; set; } // ID услуги для связи
        public Service? Service { get; set; } // Связь с услугой

    }
}
