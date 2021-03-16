using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudNaMao.Models.Contexto
{
    public class UsuarioModelContext : DbContext
    {

        
            public UsuarioModelContext(DbContextOptions<UsuarioModelContext> options) : base(options)
            {
                Database.EnsureCreated();
            }

            public DbSet<Usuario> Usuario;

        public object[] Id { get; internal set; }
    }
}
