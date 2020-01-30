using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Authorization.Models
{
    public class PositionRoles
    {
        [Key, Column(Order = 0)]
        public int RoleId { get; set; }
        
        [Key, Column(Order = 1)]
        public int PositionId { get; set; }
    }
}