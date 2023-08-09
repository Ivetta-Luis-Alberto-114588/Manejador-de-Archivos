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
            panel1 = new Panel();
            btnCopiarDirectorio = new Button();
            textBox4 = new TextBox();
            txtCopiarDestino = new TextBox();
            label1 = new TextBox();
            txtCopiarOrigen = new TextBox();
            label2 = new TextBox();
            txtCrearArchivo = new TextBox();
            textBox6 = new TextBox();
            btnCrearArchivo = new Button();
            btnAbrirArchivo = new Button();
            textBox5 = new TextBox();
            txtAbrirArchivo = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            brnRenombrarArchivo = new Button();
            textBox7 = new TextBox();
            txtRonombrarArchivo = new TextBox();
            txtEscribir = new TextBox();
            textBox9 = new TextBox();
            btnEscribir = new Button();
            btnLeer = new Button();
            textBox10 = new TextBox();
            txtLeer = new TextBox();
            btnEncontrar = new Button();
            textBox12 = new TextBox();
            txtEncontrar = new TextBox();
            btnActualizar = new Button();
            textBox14 = new TextBox();
            txtActualizar = new TextBox();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            textBox13 = new TextBox();
            textBox8 = new TextBox();
            textBox11 = new TextBox();
            textBox15 = new TextBox();
            panel6 = new Panel();
            textBox16 = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // cboDiscos
            // 
            cboDiscos.FormattingEnabled = true;
            cboDiscos.Location = new Point(49, 54);
            cboDiscos.Name = "cboDiscos";
            cboDiscos.Size = new Size(217, 23);
            cboDiscos.TabIndex = 0;
            cboDiscos.SelectedIndexChanged += cboDiscos_SelectedIndexChanged;
            // 
            // txtDetallesSistema
            // 
            txtDetallesSistema.Location = new Point(52, 92);
            txtDetallesSistema.Multiline = true;
            txtDetallesSistema.Name = "txtDetallesSistema";
            txtDetallesSistema.Size = new Size(217, 221);
            txtDetallesSistema.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(303, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 23);
            textBox1.TabIndex = 2;
            textBox1.Text = "Crear Directorio";
            // 
            // txtNuevoDirectorio
            // 
            txtNuevoDirectorio.Location = new Point(460, 55);
            txtNuevoDirectorio.Name = "txtNuevoDirectorio";
            txtNuevoDirectorio.Size = new Size(137, 23);
            txtNuevoDirectorio.TabIndex = 3;
            // 
            // btnCrearDirectorio
            // 
            btnCrearDirectorio.Location = new Point(644, 55);
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
            textBox2.Location = new Point(303, 105);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 23);
            textBox2.TabIndex = 5;
            textBox2.Text = "Crear SubDirectorio";
            // 
            // txtSubDirectorio
            // 
            txtSubDirectorio.Location = new Point(460, 105);
            txtSubDirectorio.Name = "txtSubDirectorio";
            txtSubDirectorio.Size = new Size(137, 23);
            txtSubDirectorio.TabIndex = 6;
            // 
            // btnCrearSubdirectorio
            // 
            btnCrearSubdirectorio.Location = new Point(644, 105);
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
            // panel1
            // 
            panel1.Controls.Add(btnCopiarDirectorio);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(txtCopiarDestino);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtCopiarOrigen);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(303, 202);
            panel1.Name = "panel1";
            panel1.Size = new Size(504, 121);
            panel1.TabIndex = 11;
            // 
            // btnCopiarDirectorio
            // 
            btnCopiarDirectorio.Location = new Point(426, 38);
            btnCopiarDirectorio.Name = "btnCopiarDirectorio";
            btnCopiarDirectorio.Size = new Size(75, 77);
            btnCopiarDirectorio.TabIndex = 12;
            btnCopiarDirectorio.Text = "Copiar";
            btnCopiarDirectorio.UseVisualStyleBackColor = true;
            btnCopiarDirectorio.Click += btnCopiarDirectorio_Click;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox4.Location = new Point(4, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(174, 27);
            textBox4.TabIndex = 16;
            textBox4.Text = "Copiar Directorios";
            // 
            // txtCopiarDestino
            // 
            txtCopiarDestino.Location = new Point(268, 92);
            txtCopiarDestino.Name = "txtCopiarDestino";
            txtCopiarDestino.Size = new Size(137, 23);
            txtCopiarDestino.TabIndex = 15;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(111, 92);
            label1.Name = "label1";
            label1.Size = new Size(125, 23);
            label1.TabIndex = 14;
            label1.Text = "Destino";
            // 
            // txtCopiarOrigen
            // 
            txtCopiarOrigen.Location = new Point(268, 44);
            txtCopiarOrigen.Name = "txtCopiarOrigen";
            txtCopiarOrigen.Size = new Size(137, 23);
            txtCopiarOrigen.TabIndex = 13;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(111, 44);
            label2.Name = "label2";
            label2.Size = new Size(125, 23);
            label2.TabIndex = 12;
            label2.Text = "Origen";
            // 
            // txtCrearArchivo
            // 
            txtCrearArchivo.Location = new Point(571, 347);
            txtCrearArchivo.Name = "txtCrearArchivo";
            txtCrearArchivo.Size = new Size(137, 23);
            txtCrearArchivo.TabIndex = 12;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox6.Location = new Point(270, 8);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(202, 23);
            textBox6.TabIndex = 13;
            textBox6.Text = "Crear Archivo (incluir directorio)";
            // 
            // btnCrearArchivo
            // 
            btnCrearArchivo.Location = new Point(729, 347);
            btnCrearArchivo.Name = "btnCrearArchivo";
            btnCrearArchivo.Size = new Size(75, 23);
            btnCrearArchivo.TabIndex = 14;
            btnCrearArchivo.Text = "Crear";
            btnCrearArchivo.UseVisualStyleBackColor = true;
            btnCrearArchivo.Click += btnCrearArchivo_Click;
            // 
            // btnAbrirArchivo
            // 
            btnAbrirArchivo.Location = new Point(680, 10);
            btnAbrirArchivo.Name = "btnAbrirArchivo";
            btnAbrirArchivo.Size = new Size(75, 23);
            btnAbrirArchivo.TabIndex = 17;
            btnAbrirArchivo.Text = "Abrir";
            btnAbrirArchivo.UseVisualStyleBackColor = true;
            btnAbrirArchivo.Click += btnAbrirArchivo_Click;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox5.Location = new Point(254, 10);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(202, 23);
            textBox5.TabIndex = 16;
            textBox5.Text = "Seleccionar Archivo";
            // 
            // txtAbrirArchivo
            // 
            txtAbrirArchivo.Location = new Point(522, 10);
            txtAbrirArchivo.Name = "txtAbrirArchivo";
            txtAbrirArchivo.Size = new Size(137, 23);
            txtAbrirArchivo.TabIndex = 15;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // brnRenombrarArchivo
            // 
            brnRenombrarArchivo.Location = new Point(680, 48);
            brnRenombrarArchivo.Name = "brnRenombrarArchivo";
            brnRenombrarArchivo.Size = new Size(75, 23);
            brnRenombrarArchivo.TabIndex = 20;
            brnRenombrarArchivo.Text = "Renombrar";
            brnRenombrarArchivo.UseVisualStyleBackColor = true;
            brnRenombrarArchivo.Click += brnRenombrarArchivo_Click;
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox7.Location = new Point(254, 48);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(202, 23);
            textBox7.TabIndex = 19;
            textBox7.Text = "Renombrar Archivo";
            // 
            // txtRonombrarArchivo
            // 
            txtRonombrarArchivo.Location = new Point(522, 48);
            txtRonombrarArchivo.Name = "txtRonombrarArchivo";
            txtRonombrarArchivo.Size = new Size(137, 23);
            txtRonombrarArchivo.TabIndex = 18;
            // 
            // txtEscribir
            // 
            txtEscribir.Location = new Point(59, 545);
            txtEscribir.Multiline = true;
            txtEscribir.Name = "txtEscribir";
            txtEscribir.Size = new Size(154, 140);
            txtEscribir.TabIndex = 21;
            // 
            // textBox9
            // 
            textBox9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox9.Location = new Point(7, 39);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(125, 23);
            textBox9.TabIndex = 22;
            textBox9.Text = "Escribir";
            // 
            // btnEscribir
            // 
            btnEscribir.Location = new Point(88, 214);
            btnEscribir.Name = "btnEscribir";
            btnEscribir.Size = new Size(75, 23);
            btnEscribir.TabIndex = 23;
            btnEscribir.Text = "Escribir";
            btnEscribir.UseVisualStyleBackColor = true;
            btnEscribir.Click += btnEscribir_Click;
            // 
            // btnLeer
            // 
            btnLeer.Location = new Point(283, 214);
            btnLeer.Name = "btnLeer";
            btnLeer.Size = new Size(75, 23);
            btnLeer.TabIndex = 26;
            btnLeer.Text = "Leer";
            btnLeer.UseVisualStyleBackColor = true;
            btnLeer.Click += btnLeer_Click;
            // 
            // textBox10
            // 
            textBox10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox10.Location = new Point(211, 39);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(125, 23);
            textBox10.TabIndex = 25;
            textBox10.Text = "Leer";
            // 
            // txtLeer
            // 
            txtLeer.Location = new Point(211, 68);
            txtLeer.Multiline = true;
            txtLeer.Name = "txtLeer";
            txtLeer.Size = new Size(157, 140);
            txtLeer.TabIndex = 24;
            // 
            // btnEncontrar
            // 
            btnEncontrar.Location = new Point(483, 214);
            btnEncontrar.Name = "btnEncontrar";
            btnEncontrar.Size = new Size(75, 23);
            btnEncontrar.TabIndex = 29;
            btnEncontrar.Text = "Encontrar";
            btnEncontrar.UseVisualStyleBackColor = true;
            btnEncontrar.Click += btnEncontrar_Click;
            // 
            // textBox12
            // 
            textBox12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox12.Location = new Point(410, 39);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(125, 23);
            textBox12.TabIndex = 28;
            textBox12.Text = "Encontrar";
            // 
            // txtEncontrar
            // 
            txtEncontrar.Location = new Point(410, 68);
            txtEncontrar.Multiline = true;
            txtEncontrar.Name = "txtEncontrar";
            txtEncontrar.Size = new Size(154, 140);
            txtEncontrar.TabIndex = 27;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(679, 214);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 32;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // textBox14
            // 
            textBox14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox14.Location = new Point(608, 39);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(125, 23);
            textBox14.TabIndex = 31;
            textBox14.Text = "Actualizar";
            // 
            // txtActualizar
            // 
            txtActualizar.Location = new Point(608, 68);
            txtActualizar.Multiline = true;
            txtActualizar.Name = "txtActualizar";
            txtActualizar.Size = new Size(146, 140);
            txtActualizar.TabIndex = 30;
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox13);
            panel2.Location = new Point(296, 14);
            panel2.Name = "panel2";
            panel2.Size = new Size(508, 182);
            panel2.TabIndex = 33;
            // 
            // panel3
            // 
            panel3.Controls.Add(textBox11);
            panel3.Controls.Add(textBox6);
            panel3.Location = new Point(50, 340);
            panel3.Name = "panel3";
            panel3.Size = new Size(757, 40);
            panel3.TabIndex = 34;
            // 
            // panel4
            // 
            panel4.Controls.Add(textBox15);
            panel4.Controls.Add(txtRonombrarArchivo);
            panel4.Controls.Add(txtAbrirArchivo);
            panel4.Controls.Add(textBox5);
            panel4.Controls.Add(btnAbrirArchivo);
            panel4.Controls.Add(textBox7);
            panel4.Controls.Add(brnRenombrarArchivo);
            panel4.Location = new Point(49, 389);
            panel4.Name = "panel4";
            panel4.Size = new Size(764, 82);
            panel4.TabIndex = 35;
            // 
            // panel5
            // 
            panel5.Controls.Add(textBox8);
            panel5.Location = new Point(43, 14);
            panel5.Name = "panel5";
            panel5.Size = new Size(247, 309);
            panel5.TabIndex = 36;
            // 
            // textBox13
            // 
            textBox13.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox13.Location = new Point(3, 3);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(182, 27);
            textBox13.TabIndex = 17;
            textBox13.Text = "Crear, Listar Directorios";
            // 
            // textBox8
            // 
            textBox8.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox8.Location = new Point(7, 7);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(216, 27);
            textBox8.TabIndex = 18;
            textBox8.Text = "Trabajo con Discos";
            // 
            // textBox11
            // 
            textBox11.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox11.Location = new Point(10, 7);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(206, 27);
            textBox11.TabIndex = 17;
            textBox11.Text = "Crear Archvivos";
            // 
            // textBox15
            // 
            textBox15.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox15.Location = new Point(9, 10);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(208, 27);
            textBox15.TabIndex = 21;
            textBox15.Text = "Seleccionar Listar Archivos";
            // 
            // panel6
            // 
            panel6.Controls.Add(txtLeer);
            panel6.Controls.Add(txtActualizar);
            panel6.Controls.Add(textBox16);
            panel6.Controls.Add(txtEncontrar);
            panel6.Controls.Add(textBox14);
            panel6.Controls.Add(textBox12);
            panel6.Controls.Add(textBox10);
            panel6.Controls.Add(textBox9);
            panel6.Controls.Add(btnActualizar);
            panel6.Controls.Add(btnEscribir);
            panel6.Controls.Add(btnLeer);
            panel6.Controls.Add(btnEncontrar);
            panel6.Location = new Point(50, 477);
            panel6.Name = "panel6";
            panel6.Size = new Size(763, 247);
            panel6.TabIndex = 37;
            // 
            // textBox16
            // 
            textBox16.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox16.Location = new Point(7, 0);
            textBox16.Name = "textBox16";
            textBox16.Size = new Size(209, 27);
            textBox16.TabIndex = 33;
            textBox16.Text = "Trabajo con Archivos";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 724);
            Controls.Add(txtEscribir);
            Controls.Add(btnCrearArchivo);
            Controls.Add(txtCrearArchivo);
            Controls.Add(panel1);
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
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Controls.Add(panel6);
            Name = "Form1";
            Text = "Manejador de Archivos";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
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
        private Panel panel1;
        private TextBox txtCopiarDestino;
        private TextBox label1;
        private TextBox txtCopiarOrigen;
        private TextBox label2;
        private TextBox textBox4;
        private Button btnCopiarDirectorio;
        private TextBox txtCrearArchivo;
        private TextBox textBox6;
        private Button btnCrearArchivo;
        private Button btnAbrirArchivo;
        private TextBox textBox5;
        private TextBox txtAbrirArchivo;
        private OpenFileDialog openFileDialog1;
        private Button brnRenombrarArchivo;
        private TextBox textBox7;
        private TextBox txtRonombrarArchivo;
        private TextBox txtEscribir;
        private TextBox textBox9;
        private Button btnEscribir;
        private Button btnLeer;
        private TextBox textBox10;
        private TextBox txtLeer;
        private Button btnEncontrar;
        private TextBox textBox12;
        private TextBox txtEncontrar;
        private Button btnActualizar;
        private TextBox textBox14;
        private TextBox txtActualizar;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private TextBox textBox13;
        private TextBox textBox11;
        private TextBox textBox15;
        private TextBox textBox8;
        private Panel panel6;
        private TextBox textBox16;
    }
}