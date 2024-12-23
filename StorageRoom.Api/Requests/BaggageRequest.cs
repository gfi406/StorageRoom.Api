using System.ComponentModel.DataAnnotations;

namespace StorageRoom.Api.Request
{
    public record BaggageRequest
    {
        [Required(ErrorMessage = "Идентификатор багажа обязателен.")]
        public Guid Id { get; set; }

        [StringLength(50, ErrorMessage = "Длина тега багажа не может превышать 50 символов.")]
        public string? BaggageTag { get; set; }

        [Required(ErrorMessage = "Вес обязателен.")]
        [Range(0.1, 100, ErrorMessage = "Вес должен быть в диапазоне от 0.1 до 100 кг.")]
        public double Weight { get; set; }

        [Required(ErrorMessage = "Идентификатор пассажира обязателен.")]
        public Guid PassengerId { get; set; }
    }
}
