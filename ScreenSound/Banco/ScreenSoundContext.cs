using Microsoft.EntityFrameworkCore;
using ScreenSound.Modelos;
using System.Data.SqlClient;

namespace ScreenSound.Banco
{
    internal class ScreenSoundContext : DbContext
    {
        public DbSet<Artista> Artistas { get; set; }
        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ScreenSound;Integrated Security=True;Encrypt=False;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

    }
}
