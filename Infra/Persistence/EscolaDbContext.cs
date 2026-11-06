using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Persistence
{
    public class EscolaDbContext : DbContext
    {

        public EscolaDbContext(DbContextOptions<EscolaDbContext> options) : base(options)
        {
            
        }




        public DbSet<AlunoEntity> Alunos { get; set; }
        public DbSet<ProfessorEntity> Professores { get; set; }
        public DbSet<TurmaEntity> Turmas { get; set; }


        //Sobrescreve o metodo padrão que o EFcore usa para configurar o modelo no banco de dados
        //O ModelBuilder é a ferramenta para contar como as classes C# vai ficar como tabelas/colunas/chaves
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //chama a classe pai
            base.OnModelCreating(modelBuilder);


            //Iniciando a configuração especifica do alunoentity
            modelBuilder.Entity<AlunoEntity>(
                entity =>
                {
                    //Definimos a prioridade primaria como o Id 
                    entity.HasKey(a => a.Id);

                    //dizemos q a propriedade endereco não vai ter uma tabela propria no banco
                    //os dados vão morar "dentro" da tabela aluno
                    entity.OwnsOne(a => a.Endereco, endereco =>
                    {
                        // Cada linha renomeia a coluna no banco de dados 
                        endereco.Property(a => a.Logradouro).HasColumnName("Endereco_Logradouro");
                        endereco.Property(a => a.Bairro).HasColumnName("Endereco_Bairro");
                        endereco.Property(a => a.Complemento).HasColumnName("Endereco_Complemento");
                        endereco.Property(a => a.CEP).HasColumnName("Endereco_CEP");

                    });

                    
                });



            modelBuilder.Entity<TurmaEntity>(
                entity =>
                {
                    //define o id Da turma
                    entity.HasKey( a => a.Id);

                    //uma turma tem um professor
                    entity.HasOne(t => t.ProfessorResponsavel)
                    //com muitas turmas 
                    .WithMany(p => p.TurmasResponsaveis)
                    //chave estrangeira ID do professor na classe turma
                    .HasForeignKey(t => t.ProfessorId);
                    
                    //turma tem muitos alunos
                    entity.HasMany( t=>t.Alunos)
                    //com uma turma cada um
                    .WithOne(a => a.Turma)
                    //chave estrangeira id da turma na classe aluno
                    .HasForeignKey(a => a.TurmaId )
                    // se deletar a turma o aluno n morre
                    .OnDelete(DeleteBehavior.SetNull);
                }
                
                );
        }


    }
}
