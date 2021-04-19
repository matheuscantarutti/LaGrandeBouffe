using Buffet.Models.Acesso;
using Buffet.Models.Buffet.Evento;
using La_Grande_Bouffe.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace La_Grande_Bouffe.Data
{
    public class DatabaseContext : IdentityDbContext<Usuario, Papel, Guid>
    {
        public DbSet<ClienteEntity> Clientes { get; set; }
        public DbSet<EventoEntity> Eventos  { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            :base(options)
        {
        }
    }
}
