using System.ComponentModel.DataAnnotations;

namespace SokolovaaaJournal.Data
{
    public class Account
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Имя обязательно")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Отдел обязателен")]
        public string Department { get; set; }
        [Range(0, double.MaxValue, ErrorMessage = "Баланс должен быть неотрицательным числом")]
        public double Balance { get; set; }
    }
}









