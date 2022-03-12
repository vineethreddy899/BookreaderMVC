using Business.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Data
{
    public class EventContext : IdentityDbContext
    {
        public EventContext(
            DbContextOptions<EventContext> options)
            : base(options)
        {
        }
        public DbSet<Event> Events { get; set; }

        public DbSet<Comment> Comment { get; set; }

    }
}
