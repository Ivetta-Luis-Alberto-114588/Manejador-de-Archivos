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

        private void btnCrearDirectorio_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtNuevoDirectorio.Text))
                {
                    throw new Exception("Debe ingresar un directorio");
                }

                var directorio = txtNuevoDirectorio.Text;

                if (!Directory.Exists(directorio))
                {
                    Directory.CreateDirectory(directorio);
                    MessageBox.Show("Directorio creado");
                }
                else
                {
                    MessageBox.Show("El directorio ya existe");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnCrearSubdirectorio_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrEmpty(txtNuevoDirectorio.Text))
                {
                    throw new Exception("Debe ingresar un directorio");
                }

                if (string.IsNullOrEmpty(txtSubDirectorio.Text))
                {
                    throw new Exception("Debe ingresar un subdirectorio");
                }

                if (!Directory.Exists(txtSubDirectorio.Text))
                {
                    var directorio = txtNuevoDirectorio.Text;
                    var subDirInfo = new DirectoryInfo(directorio);
                    var subdirectorio = txtSubDirectorio.Text;
                    subDirInfo.CreateSubdirectory(subdirectorio);

                    MessageBox.Show("Subdirectorio creado");
                }
                else
                {
                    MessageBox.Show("El subdirectorio ya existe");
                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private void btnListarArchivos_Click(object sender, EventArgs e)
        {
            try
            {

                var directorio = txtNuevoDirectorio.Text;
                var directorioInfo = new DirectoryInfo(directorio);
                var listaArchivos = directorioInfo.GetFiles();
                var listaSubDirectorios = directorioInfo.GetDirectories();


                if (string.IsNullOrEmpty(directorio))
                {
                    throw new Exception("Debe colocar el directorio que quiera listar");
                }


                foreach (var subDir in listaSubDirectorios)
                {
                    if (!cbxArchivosDirectorio.Items.Contains(subDir.Name))
                    {
                        cbxArchivosDirectorio.Items.Add(subDir.Name);
                    }                    
                }

                foreach (var archivo in listaArchivos)
                {
                    if (!cbxArchivosDirectorio.Items.Contains(archivo.Name))
                    {
                        cbxArchivosDirectorio.Items.Add(archivo.Name);
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }



        }
    }
}