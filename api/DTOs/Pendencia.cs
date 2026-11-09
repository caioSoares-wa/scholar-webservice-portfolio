namespace api.DTOs
{
    public class Pendencia
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int? IdProfessor { get; set; }
        public int? IdAluno { get; set; }
    }
}
