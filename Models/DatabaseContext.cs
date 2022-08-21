using Microsoft.EntityFrameworkCore;

namespace Hotsite.Models
{
    public class DatabaseContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server=localhost;DataBase=Hotsite;Uid=root;Pwd=;");
        }

        public DbSet<Interesse> Interesses { get; set; }
           public DbSet<agendasDeEventos> agendas { get; set; }
              public DbSet<dicas> dica { get; set; }
                 public DbSet<apoiadores> apoiador { get; set; }


    }
}