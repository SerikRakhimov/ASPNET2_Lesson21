using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IdentityApplication.Models
{
    public class UserProfile
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int UserId { get; set; }
        public int PositionId { get; set; }
    }
}