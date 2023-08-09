    
    namespace LocadorDeVeiculos.Infra.Arquivo.Compartilhado {
        public interface IContextoPersistencia {
            void DesfazerAlteracoes();

            void GravarDados();

            }
        }
