﻿namespace BankApp.Api.Dtos.Requests
{
    public class AddAuthorRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nationality { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
