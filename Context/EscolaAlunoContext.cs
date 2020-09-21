using Alunos.EfCore.Domain;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;



public class EscolaAlunoContext : DbContext
{

    public DbSet<Aluno> Alunos { get; set; }
    public DbSet<Escola> Escolas { get; set; }
    public DbSet<EscolaAluno> EscolaAlunos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-LOT7QKV\SQLEXPRESS2;Initial Catalog=loja;User ID=sa;Password=sa132");

        base.OnConfiguring(optionsBuilder);
        
    }

}
