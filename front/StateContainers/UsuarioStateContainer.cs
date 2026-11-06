using front.DTOs;

namespace front.StateContainers
{
    //classe para o estado geral do usuario
    public class UsuarioStateContainer
    {
        // Nosso usuario
        public UsuarioDTO Usuario { get; private set; }

        //um evento para avisar as telas que o estado mudou
        public event Action OnChange;


        //metodo para alterar o estado local
        public void SalvarUsuario(UsuarioDTO usuario)
        {
            this.Usuario = usuario;

            //aciona todo mundo que esta envolvido com a classe usuario
            NotifyStateChanged();
        }

        public async Task FazerLogout()
        {
            this.Usuario = null;
            NotifyStateChanged();
        }

        private void NotifyStateChanged() {
            OnChange?.Invoke();
        
        }

    }
}
