using System.ComponentModel.DataAnnotations;

namespace KyrsWork.Data.Models
{
    public class Client
    {
        [Key] public int ClientId { get; set; } // ID клиента
        public string? CarModel { get; set; } // Модель машины
        public string? ClientPhoneNumber { get; set; } // Номер телефона клиента
        public string? ClientName { get; set; } // Имя
        public int ClientRating { get; set; } // Рейтинг клиента (1-10)

    }
}
