using System.ComponentModel.DataAnnotations;

namespace StorageRoom.Api.Request
{
    public record FlightRequest
    {
        //[Required(ErrorMessage = "Идентификатор рейса обязателен.")]
        //public Guid Id { get; set; }

        [Required(ErrorMessage = "Номер рейса обязателен.")]
        [StringLength(10, ErrorMessage = "Длина номера рейса не может превышать 10 символов.")]
        public string? FlightNumber { get; set; }

        [Required(ErrorMessage = "Пункт назначения обязателен.")]
        [StringLength(100, ErrorMessage = "Длина пункта назначения не может превышать 100 символов.")]
        public string? Destination { get; set; }

        [Required(ErrorMessage = "Время отправления обязательно.")]
        public DateTime DepartureTime { get; set; }

        [Required(ErrorMessage = "Время прибытия обязательно.")]
        public DateTime ArrivalTime { get; set; }
    }
}
