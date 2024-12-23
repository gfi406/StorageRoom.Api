namespace StorageRoom.Api.Responses
{
    public record BaggageResponse
    {
        public Guid Id { get; set; }
        public string? BaggageTag { get; set; }
        public double Weight { get; set; }
        public Guid PassengerId { get; set; }
    }
}
