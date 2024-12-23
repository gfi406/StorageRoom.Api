namespace StorageRoom.Api.Responses
{
    public record PassengerResponse
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Guid FlightId { get; set; }
        public FlightResponse? Flight { get; set; }
        public List<BaggageResponse>? Baggages { get; set; }
    }
}
