using Microsoft.AspNetCore.Mvc;
using StorageRoom.Api.Request;
using StorageRoom.Api.Responses;
using StorageRoom.Models.Dtos;
using Swashbuckle.AspNetCore.Annotations;

namespace StorageRoom.Api.Controllers;

/// <summary>
/// Контракт для работы с багажом.
/// </summary>
public interface IBaggageApi
{
    [HttpGet]
    [SwaggerOperation(Summary = "Получить список всех багажей", Description = "Возвращает список всех зарегистрированных багажей.")]
    [SwaggerResponse(200, "Список багажей успешно возвращен", typeof(IEnumerable<BaggageResponse>))]
    [SwaggerResponse(500, "Внутренняя ошибка сервера")]
    Task<ActionResult<IEnumerable<BaggageResponse>>> GetBaggage();

    [HttpGet("{id:guid}")]
    [SwaggerOperation(Summary = "Получить багаж по идентификатору", Description = "Возвращает информацию о багаже по идентификатору.")]
    [SwaggerResponse(200, "Багаж успешно возвращен", typeof(BaggageResponse))]
    [SwaggerResponse(404, "Багаж не найден")]
    Task<ActionResult<BaggageResponse>> GetBaggageById(Guid id);

    [HttpPost]
    [SwaggerOperation(Summary = "Добавить новый багаж", Description = "Добавляет новый багаж в систему.")]
    [SwaggerResponse(201, "Багаж успешно добавлен", typeof(BaggageResponse))]
    [SwaggerResponse(400, "Ошибка при добавлении багажа")]
    Task<ActionResult<BaggageResponse>> AddBaggage([FromBody] BaggageResponse baggage);

    [HttpPut("{id:guid}")]
    [SwaggerOperation(Summary = "Обновить информацию о багаже", Description = "Обновляет данные о багаже по его идентификатору.")]
    [SwaggerResponse(200, "Багаж успешно обновлен", typeof(BaggageResponse))]
    [SwaggerResponse(400, "Некорректные данные")]
    [SwaggerResponse(404, "Багаж не найден")]
    Task<ActionResult<BaggageResponse>> UpdateBaggage(Guid id, [FromBody] BaggageRequest baggage);

    [HttpDelete("{id:guid}")]
    [SwaggerOperation(Summary = "Удалить багаж", Description = "Удаляет багаж по его идентификатору.")]
    [SwaggerResponse(200, "Багаж успешно удален")]
    [SwaggerResponse(404, "Багаж не найден")]
    Task<IActionResult> DeleteBaggage(Guid id);

    [HttpPost("Tickets")]
    [SwaggerOperation(Summary = "Опубликовать информацию о всех багажах", Description = "Отправляет сообщения о всех багажах.")]
    [SwaggerResponse(200, "Сообщения для всех багажей успешно отправлены")]
    [SwaggerResponse(500, "Внутренняя ошибка сервера")]
    Task<IActionResult> PublishAllBaggages();
}
