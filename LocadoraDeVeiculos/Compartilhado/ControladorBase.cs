

namespace LocadoraDeVeiculos.WinApp.Compartilhado {
    public abstract class ControladorBase {
        protected string mensagemRodape;

        public abstract void Inserir();

        public virtual void Editar() { }

        public abstract void Excluir();

        public virtual void Filtrar() { }

        public virtual void ConfigurarPreco() { }

        public virtual void Encerrar() { }

        public abstract UserControl ObtemListagem();

        public abstract ConfiguracaoToolboxBase ObtemConfiguracaoToolbox();

        public string ObterMensagemRodape() {
            return mensagemRodape;
        }
    }
}
