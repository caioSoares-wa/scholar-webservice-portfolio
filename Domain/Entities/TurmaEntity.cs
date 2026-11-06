using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class TurmaEntity
    {
        public int Id { get; private set; }
        public int NumeroSala { get; private set; }
        public int ProfessorId { get; private set; }
        public ProfessorEntity ProfessorResponsavel { get; private set; }
        public List<AlunoEntity> Alunos { get; private set; } = new();


        public TurmaEntity() { }


    }
}
