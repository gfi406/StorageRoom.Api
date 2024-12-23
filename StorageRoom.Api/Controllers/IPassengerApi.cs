using Microsoft.AspNetCore.Mvc;
using StorageRoom.Api.Responses;
using StorageRoom.Api.Request;
using Swashbuckle.AspNetCore.Annotations;

namespace StorageRoom.Api.Controllers;

/// <summary>
/// Контракт для работы с пассажирами.
/// </summary>
public interface IPassengerApi
{
    [HttpGet]
    [SwaggerOperation(Summary = "Получить список всех пассажиров", Description = "Возвращает список всех зарегистрированных пассажиров.")]
    [SwaggerResponse(200, "Список пассажиров успешно возвращен", typeof(IEnumerable<PassengerResponse>))]
    [SwaggerResponse(404, "Список пассажиров пуст")]
    [SwaggerResponse(500, "Внутренняя ошибка сервера")]
    Task<ActionResult<IEnumerable<PassengerResponse>>> GetPassengers();

    [HttpGet("{id:guid}")]
    [SwaggerOperation(Summary = "Получить пассажира по ID", Description = "Возвращает информацию о пассажире по его идентификатору.")]
    [SwaggerResponse(200, "Пассажир успешно возвращен", typeof(PassengerResponse))]
    [SwaggerResponse(404, "Пассажир не найден")]
    [SwaggerResponse(500, "Внутренняя ошибка сервера")]
    Task<ActionResult<PassengerResponse>> GetPassengerById(Guid id);

    [HttpPost]
    [SwaggerOperation(Summary = "Добавить нового пассажира", Description = "Добавляет нового пассажира в систему.")]
    [SwaggerResponse(201, "Пассажир успешно добавлен", typeof(PassengerResponse))]
    [SwaggerResponse(400, "Ошибка при добавлении пассажира")]
    [SwaggerResponse(500, "Внутренняя ошибка сервера")]
    Task<ActionResult<PassengerResponse>> AddPassenger([FromBody] PassengerRequest passenger);

    [HttpPut("{id:guid}")]
    [SwaggerOperation(Summary = "Обновить данные пассажира", Description = "Обновляет данные пассажира по его идентификатору.")]
    [SwaggerResponse(200, "Данные пассажира успешно обновлены", typeof(PassengerResponse))]
    [SwaggerResponse(400, "Некорректные данные")]
    [SwaggerResponse(404, "Пассажир не найден")]
    [SwaggerResponse(500, "Внутренняя ошибка сервера")]
    Task<ActionResult<PassengerResponse>> UpdatePassenger(Guid id, [FromBody] PassengerRequest passenger);

    [HttpDelete("{id:guid}")]
    [SwaggerOperation(Summary = "Удалить пассажира", Description = "Удаляет пассажира по его идентификатору.")]
    [SwaggerResponse(200, "Пассажир успешно удален")]
    [SwaggerResponse(404, "Пассажир не найден")]
    [SwaggerResponse(500, "Внутренняя ошибка сервера")]
    Task<IActionResult> DeletePassenger(Guid id);
}
