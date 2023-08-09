﻿

namespace LocadoraDeVeiculos.WinApp.Compartilhado {
    public abstract class ConfiguracaoToolboxBase {
        #region tooltips dos botões
        public abstract string TipoCadastro { get; }

        public abstract string TooltipInserir { get; }

        public abstract string TooltipEditar { get; }

        public abstract string TooltipExcluir { get; }

        public virtual string TooltipConfigurar { get; }

        public virtual string TooltipFiltrar { get; }

        public virtual string TooltipGerarPdf { get; }

       
        #endregion

        #region estados dos botões
        public virtual bool InserirHabilitado { get { return true; } }

        public virtual bool EditarHabilitado { get { return true; } }

        public virtual bool ExcluirHabilitado { get { return true; } }

        public virtual bool ConfigurarHabilitado { get { return false; } }

        public virtual bool FiltrarHabilitado { get { return false; } }

        public virtual bool GerarPdfHabilitado { get { return false; } }

        public virtual bool DuplicarHabilitado { get { return false; } }

        public virtual bool VisualizarHabilitado { get { return false; } }

        #endregion

    }
}
