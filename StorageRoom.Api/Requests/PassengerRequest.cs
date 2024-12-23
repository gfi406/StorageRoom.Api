using System.ComponentModel.DataAnnotations;

namespace StorageRoom.Api.Request
{
    public record PassengerRequest
    {
        [Required(ErrorMessage = "Идентификатор пассажира обязателен.")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Имя пассажира обязательно.")]
        [StringLength(50, ErrorMessage = "Длина имени не может превышать 50 символов.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Фамилия пассажира обязательна.")]
        [StringLength(50, ErrorMessage = "Длина фамилии не может превышать 50 символов.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Возраст обязателен.")]
        [Range(0, 120, ErrorMessage = "Возраст должен быть в диапазоне от 0 до 120.")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Идентификатор рейса обязателен.")]
        public Guid FlightId { get; set; }
    }
}
