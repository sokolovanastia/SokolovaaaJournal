using System;
using System.ComponentModel.DataAnnotations;

namespace SokolovaaaJournal.Data
{
    public class Transaction
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Учетная запись обязательна")]
        public int AccountId { get; set; }
        [Required(ErrorMessage = "Дата обязательна")]
        public DateTime Date { get; set; }
        [Range(0.01, double.MaxValue, ErrorMessage = "Сумма должна быть положительным числом")]
        public double Amount { get; set; }
        [Required(ErrorMessage = "Тип обязателен")]
        public string TransactionType { get; set; }
        public string Description { get; set; }
    }
}










