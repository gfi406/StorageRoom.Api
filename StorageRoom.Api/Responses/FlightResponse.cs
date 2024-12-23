﻿namespace StorageRoom.Api.Responses
{
    public record FlightResponse
    {
        public Guid Id { get; set; }
        public string? FlightNumber { get; set; }
        public string? Destination { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public List<PassengerResponse>? Passengers { get; set; }
    }
}
