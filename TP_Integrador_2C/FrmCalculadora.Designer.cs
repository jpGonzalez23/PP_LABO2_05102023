namespace TP_Integrador_2C
{
    partial class FrmCalculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblResultado = new Label();
            rdbBinario = new RadioButton();
            rdbDecimal = new RadioButton();
            gpbSistema = new GroupBox();
            lblPrimerOperador = new Label();
            lblOperador = new Label();
            lblSegundoOperador = new Label();
            txtPrimerOperando = new TextBox();
            txtSegundoOperando = new TextBox();
            cmbOperacion = new ComboBox();
            btnOperar = new Button();
            btnLimpiar = new Button();
            btnCerrar = new Button();
            lstHistorial = new ListBox();
            lblHistorial = new Label();
            gpbSistema.SuspendLayout();
            SuspendLayout();
            // 
            // lblResultado
            // 
            lblResultado.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultado.Location = new Point(12, 9);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(501, 40);
            lblResultado.TabIndex = 0;
            lblResultado.Text = "Resultado:";
            // 
            // rdbBinario
            // 
            rdbBinario.AutoSize = true;
            rdbBinario.Location = new Point(117, 33);
            rdbBinario.Name = "rdbBinario";
            rdbBinario.Size = new Size(62, 19);
            rdbBinario.TabIndex = 1;
            rdbBinario.Text = "Binario";
            rdbBinario.UseVisualStyleBackColor = true;
            rdbBinario.CheckedChanged += rdbBinario_CheckedChanged;
            // 
            // rdbDecimal
            // 
            rdbDecimal.AutoSize = true;
            rdbDecimal.Location = new Point(21, 33);
            rdbDecimal.Name = "rdbDecimal";
            rdbDecimal.Size = new Size(68, 19);
            rdbDecimal.TabIndex = 2;
            rdbDecimal.Text = "Decimal";
            rdbDecimal.UseVisualStyleBackColor = true;
            rdbDecimal.CheckedChanged += rdbDecimal_CheckedChanged;
            // 
            // gpbSistema
            // 
            gpbSistema.Controls.Add(rdbBinario);
            gpbSistema.Controls.Add(rdbDecimal);
            gpbSistema.Location = new Point(156, 52);
            gpbSistema.Name = "gpbSistema";
            gpbSistema.Size = new Size(200, 68);
            gpbSistema.TabIndex = 3;
            gpbSistema.TabStop = false;
            gpbSistema.Text = "Representar el resultado en:";
            // 
            // lblPrimerOperador
            // 
            lblPrimerOperador.AutoSize = true;
            lblPrimerOperador.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrimerOperador.Location = new Point(12, 139);
            lblPrimerOperador.Name = "lblPrimerOperador";
            lblPrimerOperador.RightToLeft = RightToLeft.No;
            lblPrimerOperador.Size = new Size(158, 25);
            lblPrimerOperador.TabIndex = 4;
            lblPrimerOperador.Text = "Primer Operador:";
            // 
            // lblOperador
            // 
            lblOperador.AutoSize = true;
            lblOperador.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblOperador.Location = new Point(205, 139);
            lblOperador.Name = "lblOperador";
            lblOperador.Size = new Size(104, 25);
            lblOperador.TabIndex = 5;
            lblOperador.Text = "Operación:";
            // 
            // lblSegundoOperador
            // 
            lblSegundoOperador.AutoSize = true;
            lblSegundoOperador.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSegundoOperador.Location = new Point(340, 139);
            lblSegundoOperador.Name = "lblSegundoOperador";
            lblSegundoOperador.Size = new Size(177, 25);
            lblSegundoOperador.TabIndex = 7;
            lblSegundoOperador.Text = "Segundo Operador:";
            // 
            // txtPrimerOperando
            // 
            txtPrimerOperando.Location = new Point(12, 167);
            txtPrimerOperando.Name = "txtPrimerOperando";
            txtPrimerOperando.Size = new Size(154, 23);
            txtPrimerOperando.TabIndex = 5;
            txtPrimerOperando.TextChanged += txtPrimerOperador_TextChanged;
            // 
            // txtSegundoOperando
            // 
            txtSegundoOperando.Location = new Point(340, 167);
            txtSegundoOperando.Name = "txtSegundoOperando";
            txtSegundoOperando.Size = new Size(173, 23);
            txtSegundoOperando.TabIndex = 8;
            txtSegundoOperando.TextChanged += txtSegundoOperador_TextChanged;
            // 
            // cmbOperacion
            // 
            cmbOperacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOperacion.FormattingEnabled = true;
            cmbOperacion.Items.AddRange(new object[] { "+", "-", "*", "/" });
            cmbOperacion.Location = new Point(194, 167);
            cmbOperacion.Name = "cmbOperacion";
            cmbOperacion.Size = new Size(121, 23);
            cmbOperacion.TabIndex = 6;
            // 
            // btnOperar
            // 
            btnOperar.Location = new Point(12, 208);
            btnOperar.Name = "btnOperar";
            btnOperar.Size = new Size(154, 43);
            btnOperar.TabIndex = 10;
            btnOperar.Text = "Operar";
            btnOperar.UseVisualStyleBackColor = true;
            btnOperar.Click += btnOperar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(194, 208);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(121, 43);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(340, 208);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(173, 43);
            btnCerrar.TabIndex = 12;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // lstHistorial
            // 
            lstHistorial.FormattingEnabled = true;
            lstHistorial.ItemHeight = 15;
            lstHistorial.Location = new Point(523, 82);
            lstHistorial.Name = "lstHistorial";
            lstHistorial.Size = new Size(210, 169);
            lstHistorial.TabIndex = 13;
            // 
            // lblHistorial
            // 
            lblHistorial.AutoSize = true;
            lblHistorial.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblHistorial.Location = new Point(519, 52);
            lblHistorial.Name = "lblHistorial";
            lblHistorial.RightToLeft = RightToLeft.No;
            lblHistorial.Size = new Size(86, 25);
            lblHistorial.TabIndex = 14;
            lblHistorial.Text = "Historial:";
            // 
            // FrmCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 276);
            Controls.Add(lblHistorial);
            Controls.Add(lstHistorial);
            Controls.Add(btnCerrar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnOperar);
            Controls.Add(cmbOperacion);
            Controls.Add(txtSegundoOperando);
            Controls.Add(txtPrimerOperando);
            Controls.Add(lblSegundoOperador);
            Controls.Add(lblOperador);
            Controls.Add(lblPrimerOperador);
            Controls.Add(gpbSistema);
            Controls.Add(lblResultado);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCalculadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora Gonzalez Juan Pablo";
            FormClosing += FrmCalculadora_FormClosing;
            Load += FrmCalculadora_Load;
            gpbSistema.ResumeLayout(false);
            gpbSistema.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblResultado;
        private RadioButton rdbBinario;
        private RadioButton rdbDecimal;
        private GroupBox gpbSistema;
        private Label lblPrimerOperador;
        private Label lblOperador;
        private Label lblSegundoOperador;
        private TextBox txtPrimerOperando;
        private TextBox txtSegundoOperando;
        private ComboBox cmbOperacion;
        private Button btnOperar;
        private Button btnLimpiar;
        private Button btnCerrar;
        private ListBox lstHistorial;
        private Label lblHistorial;
    }
}