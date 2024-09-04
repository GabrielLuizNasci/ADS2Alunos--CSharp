using Microsoft.EntityFrameworkCore;

namespace ADS2Alunos.Models
{
    public class Contexto: DbContext{

        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Aluno> Alunos { get; set; }
    }
}
