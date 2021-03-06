﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Feedback
{
    public class EventClass
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Office { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Boolean IsActive { get; set; }
        public Boolean IsDelete { get; set; }
        public string PhoneNo { get; set; }
        public int SesionId { get; set; }
        public string Title { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public string CreatedDate { get; set; }
        public int Rating { get; set; }
        public int eId { get; set; }
    }
}