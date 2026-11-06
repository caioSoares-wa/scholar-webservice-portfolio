using front.DTOs;
using System.Net.Http.Json;

namespace front.Services
{
    public class ResumoHomeService
    {
        private readonly HttpClient _http;

        public ResumoHomeService(HttpClient http)
        {
            _http = http;

        }


        public async Task<InfoProfessorDTO> BuscarInformacoesProfessor(int id)
        {
            var result = await _http.GetFromJsonAsync<InfoProfessorDTO>($"api/info/professor/{id}");

            if (result != null)
            {
                


                return new InfoProfessorDTO()
                {
                    Id = result.Id,
                    TotalAlunos = result.TotalAlunos,
                    TotalTurmas = result.TotalTurmas,
                    Pendencias = result.Pendencias,
                    


                };
            }
            else
            {
                return null;
            }


        }

        public async Task<InfoAlunoDTO> BuscarInformacoesAluno(int id)
        {
            var result = await _http.GetFromJsonAsync<InfoAlunoDTO>($"api/info/aluno/{id}");

            if (result != null)
            {



                return new InfoAlunoDTO()
                {
                    Id = result.Id,
                    DiasAteAProximaProva = result.DiasAteAProximaProva,
                    Trabalhos = result.Trabalhos,
                    ProximasAulas = result.ProximasAulas.Select(p => new AulasDTO
                    {
                        IdProfessor = p.IdProfessor,
                        Data = p.Data,
                        Materia = p.Materia,


                    }).ToList(),







                };
            }
            else
            {
                return null;
            }
        }



    }
}
