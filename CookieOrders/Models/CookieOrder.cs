﻿using System.Collections.Generic;

namespace CookieOrders.Models
{
    public class CookieOrder
    {
        public IList<Cookie> Cookies { get; set; }
        public string Name { get; set; }
        public string AddressLine1 { get; set; }
        public string City { get; set; }
        public string Email { get; set; }

    }
}
