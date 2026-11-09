using System.Collections.Generic;

namespace api.DTOs
{
    public class InfoAlunoDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Trabalhos { get; set; }
        public int DiasAteAProximaProva { get; set; }
        public List<AulasDTO> ProximasAulas { get; set; }
        public List<AulasDTO>? AtividadesPendentes { get; set; }

    }
}
