namespace Manejador_Archivos
{
    partial class Form1
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
            cboDiscos = new ComboBox();
            txtDetallesSistema = new TextBox();
            textBox1 = new TextBox();
            txtNuevoDirectorio = new TextBox();
            btnCrearDirectorio = new Button();
            textBox2 = new TextBox();
            txtSubDirectorio = new TextBox();
            btnCrearSubdirectorio = new Button();
            cbxArchivosDirectorio = new ComboBox();
            btnListarArchivos = new Button();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // cboDiscos
            // 
            cboDiscos.FormattingEnabled = true;
            cboDiscos.Location = new Point(52, 24);
            cboDiscos.Name = "cboDiscos";
            cboDiscos.Size = new Size(217, 23);
            cboDiscos.TabIndex = 0;
            cboDiscos.SelectedIndexChanged += cboDiscos_SelectedIndexChanged;
            // 
            // txtDetallesSistema
            // 
            txtDetallesSistema.Location = new Point(52, 83);
            txtDetallesSistema.Multiline = true;
            txtDetallesSistema.Name = "txtDetallesSistema";
            txtDetallesSistema.Size = new Size(217, 240);
            txtDetallesSistema.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(303, 24);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 23);
            textBox1.TabIndex = 2;
            textBox1.Text = "Crear Directorio";
            // 
            // txtNuevoDirectorio
            // 
            txtNuevoDirectorio.Location = new Point(460, 24);
            txtNuevoDirectorio.Name = "txtNuevoDirectorio";
            txtNuevoDirectorio.Size = new Size(137, 23);
            txtNuevoDirectorio.TabIndex = 3;
            // 
            // btnCrearDirectorio
            // 
            btnCrearDirectorio.Location = new Point(644, 24);
            btnCrearDirectorio.Name = "btnCrearDirectorio";
            btnCrearDirectorio.Size = new Size(75, 23);
            btnCrearDirectorio.TabIndex = 4;
            btnCrearDirectorio.Text = "Crear";
            btnCrearDirectorio.UseVisualStyleBackColor = true;
            btnCrearDirectorio.Click += btnCrearDirectorio_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(303, 91);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 23);
            textBox2.TabIndex = 5;
            textBox2.Text = "Crear SubDirectorio";
            // 
            // txtSubDirectorio
            // 
            txtSubDirectorio.Location = new Point(460, 91);
            txtSubDirectorio.Name = "txtSubDirectorio";
            txtSubDirectorio.Size = new Size(137, 23);
            txtSubDirectorio.TabIndex = 6;
            // 
            // btnCrearSubdirectorio
            // 
            btnCrearSubdirectorio.Location = new Point(644, 91);
            btnCrearSubdirectorio.Name = "btnCrearSubdirectorio";
            btnCrearSubdirectorio.Size = new Size(75, 23);
            btnCrearSubdirectorio.TabIndex = 7;
            btnCrearSubdirectorio.Text = "Crear";
            btnCrearSubdirectorio.UseVisualStyleBackColor = true;
            btnCrearSubdirectorio.Click += btnCrearSubdirectorio_Click;
            // 
            // cbxArchivosDirectorio
            // 
            cbxArchivosDirectorio.FormattingEnabled = true;
            cbxArchivosDirectorio.Location = new Point(460, 151);
            cbxArchivosDirectorio.Name = "cbxArchivosDirectorio";
            cbxArchivosDirectorio.Size = new Size(137, 23);
            cbxArchivosDirectorio.TabIndex = 8;
            // 
            // btnListarArchivos
            // 
            btnListarArchivos.Location = new Point(644, 151);
            btnListarArchivos.Name = "btnListarArchivos";
            btnListarArchivos.Size = new Size(75, 23);
            btnListarArchivos.TabIndex = 9;
            btnListarArchivos.Text = "Listar";
            btnListarArchivos.UseVisualStyleBackColor = true;
            btnListarArchivos.Click += btnListarArchivos_Click;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.Location = new Point(303, 151);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 23);
            textBox3.TabIndex = 10;
            textBox3.Text = "Listar";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox3);
            Controls.Add(btnListarArchivos);
            Controls.Add(cbxArchivosDirectorio);
            Controls.Add(btnCrearSubdirectorio);
            Controls.Add(txtSubDirectorio);
            Controls.Add(textBox2);
            Controls.Add(btnCrearDirectorio);
            Controls.Add(txtNuevoDirectorio);
            Controls.Add(textBox1);
            Controls.Add(txtDetallesSistema);
            Controls.Add(cboDiscos);
            Name = "Form1";
            Text = "Manejador de Archivos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboDiscos;
        private TextBox txtDetallesSistema;
        private TextBox textBox1;
        private TextBox txtNuevoDirectorio;
        private Button btnCrearDirectorio;
        private TextBox textBox2;
        private TextBox txtSubDirectorio;
        private Button btnCrearSubdirectorio;
        private ComboBox cbxArchivosDirectorio;
        private Button btnListarArchivos;
        private TextBox textBox3;
    }
}