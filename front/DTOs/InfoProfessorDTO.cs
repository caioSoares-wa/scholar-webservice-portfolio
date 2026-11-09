using System.Collections.Generic;
namespace front.DTOs


{
    public class InfoProfessorDTO
    {
        public int Id { get; set; }
        public string Nome {get;set;}
        public int TotalAlunos { get; set; }
        public int TotalTurmas { get; set; }
        public List<Pendencia> Pendencias { get; set; }

    }
}
