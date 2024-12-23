namespace StorageRoom.Api.Exceptions
{
    /// <summary>
    /// Исключение выбрасывается при попытке передачи любых некорректных данных.
    /// </summary>
    public class InvalidEntityException : Exception
    {
        public InvalidEntityException(string entityName, string message)
            : base($"Некорректные данные для сущности {entityName}: {message}") { }
    }
}
