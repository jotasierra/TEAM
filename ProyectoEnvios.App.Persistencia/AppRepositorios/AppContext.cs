using Microsoft.EntityFrameworkCore;
using ProyectoEnvios.App.Dominio;

namespace ProyectoEnvios.App.Persistencia.AppRepositorios
{
    public class AppContext : DbContext
    {
        public DbSet<Cliente> Clientes {get; set;}
        public DbSet<Enviar> Envios {get; set;}
        public DbSet<Factura> Facturas {get; set;}
        public DbSet<Funcionario> Funcionarios {get; set;}
        public DbSet<Mercancia> Mercancias {get; set;}
        public DbSet<Paquete> Paquetes {get; set;}
        public DbSet<Producto> Productos {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                //.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = MensajeriaBD");
                //.UseSqlServer("Server=localhost; Database=MensajeriaBD; Initial Catalog=MensajeriaBD");
                .UseSqlServer("Server=localhost; Database=MensajeriaBD; user id=sa; password=12345; Initial Catalog=MensajeriaBD");
            }
        }
    }
}