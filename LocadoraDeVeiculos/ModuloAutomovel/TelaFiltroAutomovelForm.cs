using LocadoraDeVeiculos.Dominio.ModuloGrupoAutomovel;
using LocadoraDeVeiculos.WinApp.Compartilhado;

namespace LocadoraDeVeiculos.WinApp.ModuloAutomovel {
    public partial class TelaFiltroAutomovelForm : Form {

        public GrupoAutomovel grupo;

        public TelaFiltroAutomovelForm(IRepositorioGrupoAutomovel repositorioGrupoAutomovel) {
            InitializeComponent();
            this.ConfigurarDialog();
            ConfigurarComboBox(repositorioGrupoAutomovel);
        }

        private void ConfigurarComboBox(IRepositorioGrupoAutomovel repositorioGrupoAutomovel) {
            foreach (var item in repositorioGrupoAutomovel.SelecionarTodos()) {
                txtListaGrupoAutomoveis.Items.Add(item);
            }
            txtListaGrupoAutomoveis.SelectedIndex = 0;
        }

        private void btnSalvar_Click(object sender, EventArgs e) {
            grupo = (GrupoAutomovel)txtListaGrupoAutomoveis.SelectedItem;
        }

    }
}
