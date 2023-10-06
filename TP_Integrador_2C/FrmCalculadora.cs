using Entidades;

namespace TP_Integrador_2C
{
    public partial class FrmCalculadora : Form
    {
        private Calculadora calculadora;

        /// <summary>
        /// 
        /// </summary>
        public FrmCalculadora()
        {
            InitializeComponent();
            this.calculadora = new Calculadora("Juan Pablo Gonzalez");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCalculadora_Load(object sender, EventArgs e)
        {
            this.cmbOperacion.DataSource = new char[] { '+', '-', '*', '/' };
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            char operador;
            calculadora.PrimerOperador = this.GetOperador(this.txtPrimerOperando.Text);
            calculadora.SegundoOperador = this.GetOperador(this.txtSegundoOperando.Text);
            operador = (char)this.cmbOperacion.SelectedItem;
            this.calculadora.Calcular(operador);
            this.calculadora.ActualizaHistorialDeOperaciones(operador);
            this.lblResultado.Text = $"Resultado: {calculadora.Resultado.Valor}"; 
            this.MostrarHistorial();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.calculadora.EliminarHistorialDeOperaciones();
            this.txtPrimerOperando.Text = string.Empty;
            this.txtSegundoOperando.Text = string.Empty;
            this.lblResultado.Text = $"Resultado:";
            this.MostrarHistorial();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 
        /// </summary>
        private Numeracion GetOperador(string value)
        {
            if (Calculadora.Sistema == ESistema.Binario)
            {
                return new SistemaBinario(value);
            }
            return new SistemaDecimal(value);
        }

        private void MostrarHistorial()
        {
            this.lstHistorial.DataSource = null;
            this.lstHistorial.DataSource =
            this.calculadora.Operaciones;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPrimerOperador_TextChanged(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSegundoOperador_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdbBinario_CheckedChanged(object sender, EventArgs e)
        {
            Calculadora.Sistema = ESistema.Decimal;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdbDecimal_CheckedChanged(object sender, EventArgs e)
        {
            Calculadora.Sistema = ESistema.Decimal;
        }

        private void FrmCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea cerrar la calculadora ? ", "Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}