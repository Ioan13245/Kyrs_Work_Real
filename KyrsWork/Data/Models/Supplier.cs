namespace KyrsWork.Data.Models
{
    public class Supplier
    {
        public int SupplierId { get; set; } // ID поставщика
        public string? SupplierName { get; set; } // Имя поставщика
        public string? SupplierPhoneNumber { get; set; } // Номер телефона
        public int SupplierRating { get; set; } // Рейтинг поставщика (1-10)
    }
}
