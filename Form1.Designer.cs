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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}