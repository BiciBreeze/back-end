﻿namespace Security.Rental.Application.DTOs
{
    public class RentalDto
    {
        public int Id { get; set; }
        public string BikeType { get; set; }
        public DateTime PickupDateTime { get; set; }
        public DateTime DropoffDateTime { get; set; }
        public string PhoneNumber { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}