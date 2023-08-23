using Chapter.Models;
using Microsoft.EntityFrameworkCore;

namespace Chapter.Contexts
{
    public class ChapterContext : DbContext
    {
        public ChapterContext() { }
        public ChapterContext(DbContextOptions<ChapterContext> options) : base(options) { }
        //vamos utilizar esse método par configurar o banco de dados
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured) 
            {
                //cada provedor tem sua sintaxe para especificação
                // optionsBuilder.UseSqlServer("Data Source = DESKTOP-F2ABGDE\\SQLEXPRESS; initial catalog = Chapter2 ; user id = seuuser; password = suasenha ;");
                // TrustServerCertificate
                optionsBuilder.UseSqlServer("Data Source = DESKTOP-F2ABGDE\\SQLEXPRESS; initial catalog = Chapter2 ; Integrated Security = true ; TrustServerCertificate = True");
            }
        }
        // dbset representa as entidades que serão utilizadas nas operações de leitura, criação, atualização e deleção
        public DbSet<Livro> Livros { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

    }
}
