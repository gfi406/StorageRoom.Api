namespace StorageRoom.Api.Exceptions
{
    /// <summary>
    /// Исключение выбрасывается при попытке передачи некорректных данных рейса.
    /// </summary>
    public class InvalidFlightException : Exception
    {
        public InvalidFlightException(string message)
            : base($"Некорректные данные рейса: {message}") { }
    }
}
