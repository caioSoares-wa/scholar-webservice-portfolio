using api.DTOs;
using Domain.Enums;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/info/")]
    public class InfoController : ControllerBase
    {

        [HttpGet]
        [Route("professor/{id}")]
        public async Task<IActionResult> BuscarInfoProfessor([FromRoute] int id)
        {
            var professor = new InfoProfessorDTO() {
                Id = id,
                Nome = "pericles",
                Pendencias = new List<Pendencia> {
                    new Pendencia { Id = 1, Descricao="Fazer 0 jão calar a boca", IdAluno=null , IdProfessor= 1 },
                    new Pendencia { Id = 1, Descricao="Levar a Maria Alice na diretoria", IdAluno=null , IdProfessor= 1 },
                    new Pendencia { Id = 1, Descricao="Agendar reunião com a Gilma", IdAluno=null , IdProfessor= 1 },
                },
                TotalAlunos = 100,
                TotalTurmas = 4


            };

            return Ok(professor);
        }





        [HttpGet]
        [Route("aluno/{id}")]
        public async Task<IActionResult> BuscarInfoAluno([FromRoute] int id)
        {

            var aluno = new InfoAlunoDTO()
            {
                Id = id,
                Nome = "Bruna",
                DiasAteAProximaProva = 15,
                ProximasAulas = new List<AulasDTO>
                {  new AulasDTO{Data = DateTime.UtcNow, IdProfessor=1,Materia=MateriaEnum.Arte },
                    new AulasDTO{Data = DateTime.UtcNow, IdProfessor=1,Materia=MateriaEnum.Filosofia },
                    new AulasDTO{Data = DateTime.UtcNow, IdProfessor=1,Materia=MateriaEnum.EducacaoFisica },
                    new AulasDTO{Data = DateTime.UtcNow, IdProfessor=1,Materia=MateriaEnum.Biologia },
                },
                AtividadesPendentes = new List<AulasDTO>
                {  new AulasDTO{Data = DateTime.UtcNow, IdProfessor=1,Materia=MateriaEnum.Matematica },
                    new AulasDTO{Data = DateTime.UtcNow, IdProfessor=1,Materia=MateriaEnum.Quimica },
                    new AulasDTO{Data = DateTime.UtcNow, IdProfessor=1,Materia=MateriaEnum.Sociologia },
                    new AulasDTO{Data = DateTime.UtcNow, IdProfessor=1,Materia=MateriaEnum.EducacaoFisica },
                },
                Trabalhos = 6
            };


            return Ok(aluno);
        }


    }
}

