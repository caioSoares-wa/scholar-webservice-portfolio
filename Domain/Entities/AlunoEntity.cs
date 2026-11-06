using Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class AlunoEntity
    {
        public int Id { get; private set; }
        public string Nome { get;  set; } = string.Empty;
        public int Matricula { get; set; }
        public int? TurmaId { get; private set; }
        public TurmaEntity? Turma { get; set; }
        public DateTime DataDaInscricao { get; set; } = new DateTime();
        public DateTime DataDaValidadeDaInscricao { get; set; } = new DateTime();
        public EnderecoVO Endereco { get; private set; } 

        public Dictionary<string, int> NotasTrabalhos { get; private set; }
        public Dictionary<string, int> NotasMaterias { get; private set; }
        public Dictionary<string, int>? NotaExtra { get; private set; } 



        public AlunoEntity(string nome, EnderecoVO end, int matr)
        {

            AtualizarNome(nome);
            this.Matricula = matr;
            this.Endereco = end;
            DataDaInscricao = DateTime.UtcNow;

        }

      
        public void AtualizarNome(string nome)
        {
            if (string.IsNullOrEmpty(nome))
            {
                throw new ArgumentNullException("insira um nome válido.",nameof(nome));
            }


            this.Nome = nome;
        }
        

       
    }
}
