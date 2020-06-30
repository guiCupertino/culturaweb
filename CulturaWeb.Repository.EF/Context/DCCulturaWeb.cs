using CulturaWeb.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace CulturaWeb.Repository.EF.Context
{
    public class DCCulturaWeb : DbContext
    {
        public DCCulturaWeb(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Editora> Editoras { get; set; }
        public DbSet<Livro> Livros { get; set; }
        public DbSet<Emprestimo> Emprestimos { get; set; }
        public DbSet<ItemEmprestimo> ItemEmprestimos { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Setor> Setores { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Telefone> Telefones { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Aluno>().HasKey(p => p.Id);
            modelBuilder.Entity<Aluno>().Property(p => p.Nome).IsRequired();
            modelBuilder.Entity<Aluno>().Property(p => p.CPF).IsRequired();
            modelBuilder.Entity<Aluno>().HasOne(p => p.Endereco);
            modelBuilder.Entity<Aluno>()
                .HasOne(p => p.Telefone)
                .WithOne()
                .HasForeignKey<Telefone>(f => f.Id); ;

            modelBuilder.Entity<Endereco>().HasKey(p => p.Id);
            modelBuilder.Entity<Endereco>().HasOne(p => p.Cidade);
            modelBuilder.Entity<Endereco>().Property(p => p.Logradouro).IsRequired();
            modelBuilder.Entity<Endereco>().Property(p => p.Numero).IsRequired();

            modelBuilder.Entity<Funcionario>().HasKey(p => p.Id);
            modelBuilder.Entity<Funcionario>().Property(p => p.Nome).IsRequired();
            modelBuilder.Entity<Funcionario>().Property(p => p.CPF).IsRequired();
            modelBuilder.Entity<Funcionario>().Property(p => p.TelefoneId).IsRequired();
            modelBuilder.Entity<Funcionario>().Property(p => p.SetorId).IsRequired();
            modelBuilder.Entity<Funcionario>().HasOne(p => p.Endereco);            
            modelBuilder.Entity<Funcionario>().HasOne(p => p.Setor);
            modelBuilder.Entity<Funcionario>()
                .HasOne(p => p.Telefone)
                .WithOne()
                .HasForeignKey<Telefone>(f => f.Id)
                .OnDelete(DeleteBehavior.NoAction);
                       
            modelBuilder.Entity<Setor>().HasKey(p => p.Id);
            modelBuilder.Entity<Setor>().Property(p => p.Nome).IsRequired();

            modelBuilder.Entity<Livro>().HasKey(p => p.Id);
            modelBuilder.Entity<Livro>().Property(p => p.Nome).IsRequired();
            modelBuilder.Entity<Livro>().Property(p => p.Titulo).IsRequired();
            modelBuilder.Entity<Livro>().Property(p => p.Autor).IsRequired();
            modelBuilder.Entity<Livro>().HasOne(p => p.Editora);
            modelBuilder.Entity<Livro>().HasMany(p => p.Genero);

            modelBuilder.Entity<Genero>().HasKey(p => p.Id);
            modelBuilder.Entity<Genero>().Property(p => p.Nome).IsRequired();

            modelBuilder.Entity<Editora>().HasKey(p => p.Id);
            modelBuilder.Entity<Editora>().Property(p => p.Nome).IsRequired();
            modelBuilder.Entity<Editora>().HasOne(p => p.Endereco);

            modelBuilder.Entity<Cidade>().HasKey(p => p.Id);
            modelBuilder.Entity<Cidade>().HasOne(p => p.Estado);
            modelBuilder.Entity<Cidade>().Property(p => p.EstadoId).IsRequired();

            modelBuilder.Entity<Estado>().HasKey(p => p.Id);
            modelBuilder.Entity<Estado>().Property(p => p.Nome).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<Estado>().Property(p => p.UF).HasMaxLength(2).IsRequired();

            modelBuilder.Entity<Emprestimo>().HasKey(p => p.Id);
            modelBuilder.Entity<Emprestimo>().HasOne(p => p.Aluno);
            modelBuilder.Entity<Emprestimo>().HasMany(p => p.ItemEmprestimos);
            modelBuilder.Entity<Emprestimo>().HasOne(p => p.Funcionario)
                .WithOne()
                .HasForeignKey<Funcionario>(f => f.Id);
                       

            modelBuilder.Entity<ItemEmprestimo>().HasKey(p => p.Id);
            modelBuilder.Entity<ItemEmprestimo>().HasOne(p => p.Livro);
            modelBuilder.Entity<ItemEmprestimo>().HasOne(p => p.Emprestimo)
                .WithMany(p => p.ItemEmprestimos);

            modelBuilder.Entity<Telefone>().HasKey(p => p.Id);
                        
        }

    }
}
