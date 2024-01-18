﻿using Microsoft.EntityFrameworkCore;

namespace HotelManagement.Models
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {

        }

        public DbSet<Reservation> Reservations { get; set; }
    }
}
