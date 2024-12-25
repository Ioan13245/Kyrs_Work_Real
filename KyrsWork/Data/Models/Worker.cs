using System.ComponentModel.DataAnnotations;

namespace KyrsWork.Data.Models
{
    public class Worker
    {
        [Key] public int WorkerId { get; set; }
        public string? WorkerName { get; set; }
        public double WorkerSalary { get; set; }
        public int WorkerRaiting { get; set; }
        public DateOnly WorkerYear { get; set; }
        public string? WorkerKvalification { get; set; }
    }
}
