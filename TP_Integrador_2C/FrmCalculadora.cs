//using Entidades;
//using Entidades.Modelos;

namespace TP_Integrador_2C
{
    public partial class FrmCalculadora : Form
    {

        /// <summary>
        /// Constructor del formulario
        /// </summary>
        public FrmCalculadora()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metodo para inicializar valores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCalculadora_Load(object sender, EventArgs e)
        {
        }


        /// <summary>
        /// Metodo cuando se hace click en el btnOperar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Metodo para limpiar el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtPrimerOperador.Clear();
            this.txtSegundoOperador.Clear();
            this.lblResultado.Text = "Resultado: ";
            this.cmbOperacion.Text = null;
        }

        /// <summary>
        /// Metodo para cerrar el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
        }

        private void SetResultado()
        {
        }

        private void txtPrimerOperador_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSegundoOperador_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdbBinario_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void rdbDecimal_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}