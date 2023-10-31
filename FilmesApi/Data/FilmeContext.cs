using FilmesApi.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmesApi.Data
{
    public class FilmeContext : DbContext
    {
        // Adicionar uma migration, Add-Migration nomeDaMigration

        // Atualizar o banco, Update-Database
        public FilmeContext(DbContextOptions<FilmeContext> opts)
            : base(opts)
        {
            
        }

        public DbSet<Filme> Filmes { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
    }
}
