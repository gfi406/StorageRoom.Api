namespace StorageRoom.Api.Exceptions
{
    /// <summary>
    /// Исключение выбрасывается при попытке передачи некорректных данных багажа.
    /// </summary>
    public class InvalidBaggageException : Exception
    {
        public InvalidBaggageException(string message)
            : base($"Некорректные данные багажа: {message}") { }
    }
}
