namespace GonzaloCeballos
{
    partial class FrmAtencion
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
            rtbInfoMedico = new RichTextBox();
            lstMedicos = new ListBox();
            lstPacientes = new ListBox();
            lblMedicos = new Label();
            lblPacientes = new Label();
            btnAtender = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // rtbInfoMedico
            // 
            rtbInfoMedico.Location = new Point(12, 279);
            rtbInfoMedico.Name = "rtbInfoMedico";
            rtbInfoMedico.Size = new Size(700, 204);
            rtbInfoMedico.TabIndex = 0;
            rtbInfoMedico.Text = "";
            // 
            // lstMedicos
            // 
            lstMedicos.FormattingEnabled = true;
            lstMedicos.ItemHeight = 15;
            lstMedicos.Location = new Point(12, 46);
            lstMedicos.Name = "lstMedicos";
            lstMedicos.Size = new Size(332, 214);
            lstMedicos.TabIndex = 1;
            lstMedicos.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // lstPacientes
            // 
            lstPacientes.FormattingEnabled = true;
            lstPacientes.ItemHeight = 15;
            lstPacientes.Location = new Point(370, 46);
            lstPacientes.Name = "lstPacientes";
            lstPacientes.Size = new Size(316, 214);
            lstPacientes.TabIndex = 2;
            // 
            // lblMedicos
            // 
            lblMedicos.AutoSize = true;
            lblMedicos.Location = new Point(12, 18);
            lblMedicos.Name = "lblMedicos";
            lblMedicos.Size = new Size(95, 15);
            lblMedicos.TabIndex = 3;
            lblMedicos.Text = "Personal Medico";
            lblMedicos.Click += label1_Click;
            // 
            // lblPacientes
            // 
            lblPacientes.AutoSize = true;
            lblPacientes.Location = new Point(370, 18);
            lblPacientes.Name = "lblPacientes";
            lblPacientes.Size = new Size(57, 15);
            lblPacientes.TabIndex = 4;
            lblPacientes.Text = "Pacientes";
            // 
            // btnAtender
            // 
            btnAtender.Location = new Point(727, 46);
            btnAtender.Name = "btnAtender";
            btnAtender.Size = new Size(211, 103);
            btnAtender.TabIndex = 5;
            btnAtender.Text = "Atender";
            btnAtender.UseVisualStyleBackColor = true;
            btnAtender.Click += btnAtender_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(727, 340);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(214, 123);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // FrmAtencion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 506);
            Controls.Add(btnSalir);
            Controls.Add(btnAtender);
            Controls.Add(lblPacientes);
            Controls.Add(lblMedicos);
            Controls.Add(lstPacientes);
            Controls.Add(lstMedicos);
            Controls.Add(rtbInfoMedico);
            Name = "FrmAtencion";
            Text = "Gonzalo Ceballos";
            Load += FrmAtencion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtbInfoMedico;
        private ListBox lstMedicos;
        private ListBox lstPacientes;
        private Label lblMedicos;
        private Label lblPacientes;
        private Button btnAtender;
        private Button btnSalir;
    }
}
