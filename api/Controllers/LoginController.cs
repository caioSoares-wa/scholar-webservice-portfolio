using Microsoft.AspNetCore.Mvc;
using api.DTOs;

namespace api.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        [Route("login")]
        public async Task<UsuarioDTO> EfetuarLogin(LoginDTO login)
        {

            if (login == null)
            {
                throw new ArgumentNullException(nameof(login));
            }

            var UsuarioDTO = new UsuarioDTO
            {
                Id = 1,
                Cargo = "Aluno",
                Nome = "Caio"
            };

            return UsuarioDTO;
        }
    }
}
