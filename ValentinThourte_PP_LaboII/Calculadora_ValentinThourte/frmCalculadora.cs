using Entidades;

namespace Calculadora_ValentinThourte
{
    public partial class frmCalculadora : Form
    {
        private Calculadora calculadora;
        public frmCalculadora()
        {
            InitializeComponent();
            this.calculadora = new Calculadora("Valentin Thourte");
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            try
            {
                char operador;
                calculadora.PrimerOperando =
                this.GetOperando(this.txtPrimerOperador.Text);
                calculadora.SegundoOperando =
                this.GetOperando(this.txtSegundoOperador.Text);
                operador = (char)this.cmbOperacion.SelectedItem;
                this.calculadora.Calcular(operador);
                this.calculadora.ActualizaHistorialDeOperaciones(operador);
                this.lblResultado.Text = $"Resultado:  {calculadora.Resultado.Valor}";
                this.MostrarHistorial();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MostrarHistorial()
        {
            this.lstHistorial.DataSource = null;
            this.lstHistorial.DataSource = this.calculadora.Operaciones;
        }

        private Numeracion GetOperando(string text)
        {
            if (Calculadora.Sistema == ESistema.Binario)
            {
                return new SistemaBinario(text);
            }
            return new SistemaDecimal(text);
        }

        private void tbOperadores_KeyPress(object sender, KeyPressEventArgs e)
        {
            char[] caracteresPermitidos = { (char)Keys.Back };
            //e.Handled = Validador.TeclaPresionadaEsNumero(e.KeyChar, caracteresPermitidos);
        }



        private void frmCalculadora_Load(object sender, EventArgs e)
        {
            this.cmbOperacion.DataSource = new char[] { '+', '-', '*', '/' };
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.calculadora.EliminarHistorialDeOperaciones();
            this.txtPrimerOperador.Text = string.Empty;
            this.txtSegundoOperador.Text = string.Empty;
            this.lblResultado.Text = $"Resultado:";
            this.MostrarHistorial();
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void rbDecimal_CheckedChanged(object sender, EventArgs e)
        {
            Calculadora.Sistema = ESistema.Decimal;
        }

        private void rbBinario_CheckedChanged(object sender, EventArgs e)
        {
            Calculadora.Sistema = ESistema.Binario;
        }

        private void frmCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea cerrar la  calculadora?", "Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }

        }
    }
}