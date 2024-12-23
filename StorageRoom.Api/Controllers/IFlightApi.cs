using Microsoft.AspNetCore.Mvc;
using StorageRoom.Api.Request;
using StorageRoom.Api.Responses;

using Swashbuckle.AspNetCore.Annotations;

namespace StorageRoom.Api.Controllers;

/// <summary>
/// Контракт для работы с рейсами.
/// </summary>
public interface IFlightApi
{
    [HttpGet]
    [SwaggerOperation(Summary = "Получить список всех рейсов", Description = "Возвращает список всех зарегистрированных рейсов.")]
    [SwaggerResponse(200, "Список рейсов успешно возвращен", typeof(IEnumerable<FlightResponse>))]
    [SwaggerResponse(500, "Внутренняя ошибка сервера")]
    Task<ActionResult<IEnumerable<FlightResponse>>> GetFlights();

    [HttpGet("{id:guid}")]
    [SwaggerOperation(Summary = "Получить рейс по ID", Description = "Возвращает информацию о рейсе по его идентификатору.")]
    [SwaggerResponse(200, "Рейс успешно возвращен", typeof(FlightResponse))]
    [SwaggerResponse(404, "Рейс не найден")]
    [SwaggerResponse(500, "Внутренняя ошибка сервера")]
    Task<ActionResult<FlightResponse>> GetFlightById(Guid id);

    [HttpPost]
    [SwaggerOperation(Summary = "Добавить новый рейс", Description = "Добавляет новый рейс в систему.")]
    [SwaggerResponse(201, "Рейс успешно добавлен", typeof(FlightResponse))]
    [SwaggerResponse(400, "Ошибка при добавлении рейса")]
    [SwaggerResponse(500, "Внутренняя ошибка сервера")]
    Task<ActionResult<FlightResponse>> AddFlight([FromBody] FlightRequest flight);

    [HttpPut("{id:guid}")]
    [SwaggerOperation(Summary = "Обновить информацию о рейсе", Description = "Обновляет данные о рейсе по его идентификатору.")]
    [SwaggerResponse(200, "Рейс успешно обновлен", typeof(FlightResponse))]
    [SwaggerResponse(400, "Некорректные данные")]
    [SwaggerResponse(404, "Рейс не найден")]
    [SwaggerResponse(500, "Внутренняя ошибка сервера")]
    Task<ActionResult<FlightResponse>> UpdateFlight(Guid id, [FromBody] FlightRequest flight);

    [HttpDelete("{id:guid}")]
    [SwaggerOperation(Summary = "Удалить рейс", Description = "Удаляет рейс по его идентификатору.")]
    [SwaggerResponse(200, "Рейс успешно удален")]
    [SwaggerResponse(404, "Рейс не найден")]
    [SwaggerResponse(500, "Внутренняя ошибка сервера")]
    Task<IActionResult> DeleteFlight(Guid id);
}
