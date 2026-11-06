using front.Pages;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using front.DTOs;

namespace front.Services
{
    public class LoginService
    {
        //injeção de dependencia do httpclient
        private readonly HttpClient _httpClient;

        public LoginService( HttpClient http)
        {
            _httpClient = http;
        }



        //metodo pra fazer login (loginDTO tem email, senha e um bool pra lembrar)
        public async Task<UsuarioDTO> FazerLogin(LoginDTO login)
        {
            // aqui to fazendo um post como json passando o objeto login  e recebendo um response de volta
            HttpResponseMessage result = await _httpClient.PostAsJsonAsync("api/auth/login", login);
            
            //se deu certo
            if (result.IsSuccessStatusCode)
            {
                //normalmente o metodo de login volta as credenciais do usuario
                var usuario = await result.Content.ReadFromJsonAsync<UsuarioDTO>();

                //provisorio
                return new UsuarioDTO {
                    Id= usuario.Id,
                    Cargo = usuario.Cargo,
                    Nome = usuario.Nome,
                    
                };
                
            }

            return null;
        }
    }
}
