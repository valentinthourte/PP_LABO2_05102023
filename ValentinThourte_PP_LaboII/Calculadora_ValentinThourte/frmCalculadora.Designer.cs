namespace Calculadora_ValentinThourte
{
    partial class frmCalculadora
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
            lblPrimerOperador = new Label();
            lblOperacion = new Label();
            lblSegundoOperador = new Label();
            txtPrimerOperador = new TextBox();
            txtSegundoOperador = new TextBox();
            cmbOperacion = new ComboBox();
            btnOperar = new Button();
            btnLimpiar = new Button();
            btnCerrar = new Button();
            grpSistema = new GroupBox();
            lstHistorial = new ListBox();
            lblHistorial = new Label();
            grpSistema.SuspendLayout();
            SuspendLayout();
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultado.Location = new Point(29, 23);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(218, 54);
            lblResultado.TabIndex = 0;
            lblResultado.Text = "Resultado: ";
            // 
            // rdbBinario
            // 
            rdbBinario.AutoSize = true;
            rdbBinario.Location = new Point(109, 44);
            rdbBinario.Name = "rdbBinario";
            rdbBinario.Size = new Size(62, 19);
            rdbBinario.TabIndex = 1;
            rdbBinario.Text = "Binario";
            rdbBinario.UseVisualStyleBackColor = true;
            rdbBinario.CheckedChanged += rbBinario_CheckedChanged;
            // 
            // rdbDecimal
            // 
            rdbDecimal.AutoSize = true;
            rdbDecimal.Checked = true;
            rdbDecimal.Location = new Point(6, 44);
            rdbDecimal.Name = "rdbDecimal";
            rdbDecimal.Size = new Size(68, 19);
            rdbDecimal.TabIndex = 0;
            rdbDecimal.TabStop = true;
            rdbDecimal.Text = "Decimal";
            rdbDecimal.UseVisualStyleBackColor = true;
            rdbDecimal.CheckedChanged += rbDecimal_CheckedChanged;
            // 
            // lblPrimerOperador
            // 
            lblPrimerOperador.AutoSize = true;
            lblPrimerOperador.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrimerOperador.Location = new Point(36, 285);
            lblPrimerOperador.Name = "lblPrimerOperador";
            lblPrimerOperador.Size = new Size(217, 37);
            lblPrimerOperador.TabIndex = 3;
            lblPrimerOperador.Text = "Primer operador:";
            // 
            // lblOperacion
            // 
            lblOperacion.AutoSize = true;
            lblOperacion.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblOperacion.Location = new Point(319, 285);
            lblOperacion.Name = "lblOperacion";
            lblOperacion.Size = new Size(146, 37);
            lblOperacion.TabIndex = 4;
            lblOperacion.Text = "Operacion:";
            // 
            // lblSegundoOperador
            // 
            lblSegundoOperador.AutoSize = true;
            lblSegundoOperador.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblSegundoOperador.Location = new Point(522, 285);
            lblSegundoOperador.Name = "lblSegundoOperador";
            lblSegundoOperador.Size = new Size(246, 37);
            lblSegundoOperador.TabIndex = 5;
            lblSegundoOperador.Text = "Segundo operador:";
            // 
            // txtPrimerOperador
            // 
            txtPrimerOperador.Location = new Point(47, 337);
            txtPrimerOperador.Name = "txtPrimerOperador";
            txtPrimerOperador.Size = new Size(191, 23);
            txtPrimerOperador.TabIndex = 6;
            txtPrimerOperador.Text = "0";
            txtPrimerOperador.KeyPress += tbOperadores_KeyPress;
            // 
            // txtSegundoOperador
            // 
            txtSegundoOperador.Location = new Point(547, 337);
            txtSegundoOperador.Name = "txtSegundoOperador";
            txtSegundoOperador.Size = new Size(191, 23);
            txtSegundoOperador.TabIndex = 8;
            txtSegundoOperador.Text = "0";
            txtSegundoOperador.KeyPress += tbOperadores_KeyPress;
            // 
            // cmbOperacion
            // 
            cmbOperacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOperacion.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            cmbOperacion.FormattingEnabled = true;
            cmbOperacion.Items.AddRange(new object[] { "+", "-", "*", "/" });
            cmbOperacion.Location = new Point(294, 326);
            cmbOperacion.Name = "cmbOperacion";
            cmbOperacion.Size = new Size(191, 36);
            cmbOperacion.TabIndex = 2;
            // 
            // btnOperar
            // 
            btnOperar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnOperar.Location = new Point(294, 375);
            btnOperar.Name = "btnOperar";
            btnOperar.Size = new Size(191, 43);
            btnOperar.TabIndex = 9;
            btnOperar.Text = "Operar";
            btnOperar.UseVisualStyleBackColor = true;
            btnOperar.Click += btnOperar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(47, 375);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(191, 43);
            btnLimpiar.TabIndex = 10;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnCerrar.Location = new Point(547, 375);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(191, 43);
            btnCerrar.TabIndex = 11;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // grpSistema
            // 
            grpSistema.Controls.Add(rdbBinario);
            grpSistema.Controls.Add(rdbDecimal);
            grpSistema.Location = new Point(294, 146);
            grpSistema.Name = "grpSistema";
            grpSistema.Size = new Size(191, 100);
            grpSistema.TabIndex = 2;
            grpSistema.TabStop = false;
            grpSistema.Text = "Operar en";
            // 
            // lstHistorial
            // 
            lstHistorial.FormattingEnabled = true;
            lstHistorial.ItemHeight = 15;
            lstHistorial.Location = new Point(774, 84);
            lstHistorial.Name = "lstHistorial";
            lstHistorial.Size = new Size(448, 334);
            lstHistorial.TabIndex = 12;
            // 
            // lblHistorial
            // 
            lblHistorial.AutoSize = true;
            lblHistorial.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblHistorial.Location = new Point(907, 23);
            lblHistorial.Name = "lblHistorial";
            lblHistorial.Size = new Size(189, 54);
            lblHistorial.TabIndex = 13;
            lblHistorial.Text = "Historial: ";
            // 
            // frmCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1225, 450);
            Controls.Add(lblHistorial);
            Controls.Add(lstHistorial);
            Controls.Add(grpSistema);
            Controls.Add(btnCerrar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnOperar);
            Controls.Add(cmbOperacion);
            Controls.Add(txtSegundoOperador);
            Controls.Add(txtPrimerOperador);
            Controls.Add(lblSegundoOperador);
            Controls.Add(lblOperacion);
            Controls.Add(lblPrimerOperador);
            Controls.Add(lblResultado);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmCalculadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora de Valentin Thourte";
            FormClosing += frmCalculadora_FormClosing;
            Load += frmCalculadora_Load;
            grpSistema.ResumeLayout(false);
            grpSistema.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblResultado;
        private RadioButton rdbBinario;
        private RadioButton rdbDecimal;
        private Label lblPrimerOperador;
        private Label lblOperacion;
        private Label lblSegundoOperador;
        private TextBox txtPrimerOperador;
        private TextBox txtSegundoOperador;
        private ComboBox cmbOperacion;
        private Button btnOperar;
        private Button btnLimpiar;
        private Button btnCerrar;
        private GroupBox grpSistema;
        private ListBox lstHistorial;
        private Label lblHistorial;
    }
}