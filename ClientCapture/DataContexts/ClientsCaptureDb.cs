using ClientCapture.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ClientCapture.DataContexts
{
    
        public class ClientsCaptureDb : DbContext
        {
            public ClientsCaptureDb()
                : base("DefaultConnection")
            {
            }

            // Momentum.Entities.Base
            public DbSet<Client> Clients { get; set; }
            public DbSet<Contact> Contacts { get; set; }
    }
}