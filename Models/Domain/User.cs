using System;
using Microsoft.AspNetCore.Identity;

namespace OnlineConsultationManagementSystem.Models.Domain
{
    public class User: IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
