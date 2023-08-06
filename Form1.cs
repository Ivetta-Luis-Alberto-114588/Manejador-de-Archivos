namespace Manejador_Archivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            discos();
        }

        public void discos()
        {
            try
            {
                var discos = Directory.GetLogicalDrives();
                foreach (var disco in discos)
                {
                    cboDiscos.Items.Add(disco);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboDiscos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var disco = cboDiscos.SelectedItem.ToString();
                DriveInfo drive = new DriveInfo(disco);

                var mostrar = $@"
                Nombre: {drive.Name}
                Espacio total: {drive.TotalSize / 1024 / 1024 / 1024} Gb""                
                Espacio libre: {drive.AvailableFreeSpace / 1024 / 1024 / 1024} Gb
                Esta disponible: {drive.IsReady}
                Formato: {drive.DriveFormat}";
                txtDetallesSistema.Text = mostrar;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}