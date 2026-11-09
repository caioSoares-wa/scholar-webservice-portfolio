using Domain.Enums;

namespace api.DTOs
{
    public class AulasDTO
    {
        public DateTime Data { get; set; }
        public MateriaEnum Materia { get; set; }
        public int IdProfessor { get; set; }
    }
}
