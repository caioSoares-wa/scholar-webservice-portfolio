using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class ProfessorEntity
    {
        public int Id { get; private set; }
        public required string Nome { get; set; }
        public List<TurmaEntity> TurmasResponsaveis { get; set; } = new();


        public ProfessorEntity()
        {

        }

     
    }
}
