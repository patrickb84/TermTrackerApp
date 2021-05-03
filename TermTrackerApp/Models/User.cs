using System;
using System.Collections.Generic;

namespace TermTrackerApp.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<Term> Terms { get; set; }
    }
}
