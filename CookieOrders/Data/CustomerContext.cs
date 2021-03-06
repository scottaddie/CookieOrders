﻿using Microsoft.EntityFrameworkCore;
using CookieOrders.Models;

namespace CookieOrders.Data
{
    public class CustomerContext : DbContext
    {
        public CustomerContext(DbContextOptions<CustomerContext> options) : base(options)
        {
        }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Cookie> Cookie { get; set; }
        public DbSet<CookieOrder> CookieOrder { get; set; }
        public DbSet<Order> Order { get; set; }
    }
}