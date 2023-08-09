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

        private void btnCopiarDirectorio_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCopiarDestino.Text) || string.IsNullOrEmpty(txtCopiarOrigen.Text))
                {
                    throw new Exception("Debe completar los campos");
                }

                var origenInfo = new DirectoryInfo(txtCopiarOrigen.Text);
                var destinoInfo = new DirectoryInfo(txtCopiarDestino.Text);

                copiarDirectorio(origenInfo, destinoInfo);
                MessageBox.Show("Directorio copiado con exito");

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void copiarDirectorio(DirectoryInfo p_directorioOrigen, DirectoryInfo p_directorioDestino)
        {
            try
            {
                if (!p_directorioOrigen.Exists)
                {
                    throw new Exception("El directorio de origen no existe");
                }

                if (!p_directorioDestino.Exists)
                {
                    p_directorioDestino.Create();
                }

                var archivos = p_directorioOrigen.GetFiles();

                foreach (var archivo in archivos)
                {
                    archivo.CopyTo(Path.Combine(p_directorioDestino.FullName, archivo.Name));
                }

                var directorios = p_directorioOrigen.GetDirectories();
                foreach (var directorio in directorios)
                {
                    string pathDestino = Path.Combine(p_directorioDestino.FullName, directorio.Name);
                    copiarDirectorio(directorio, new DirectoryInfo(pathDestino));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnCrearArchivo_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCrearArchivo.Text))
                {
                    throw new Exception("Debe completar los campos");
                }

                if (!File.Exists(txtCrearArchivo.Text))
                {
                    File.Create(txtCrearArchivo.Text);
                    MessageBox.Show("Archivo creado");
                }
                else
                {
                    MessageBox.Show("El archivo ya existe");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnAbrirArchivo_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    txtAbrirArchivo.Text = openFileDialog1.FileName;
                    txtRonombrarArchivo.Text = openFileDialog1.FileName;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void brnRenombrarArchivo_Click(object sender, EventArgs e)
        {
            try
            {
                var origen = txtAbrirArchivo.Text;
                var destino = txtRonombrarArchivo.Text;

                var origenFileInfo = new FileInfo(origen);

                if (origenFileInfo.Exists)
                {
                    origenFileInfo.MoveTo(destino);
                    MessageBox.Show("Archivo renombrado");
                }
                else
                {
                    throw new Exception("El archivo no existe");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtAbrirArchivo.Text))
                {
                    throw new Exception("Debe seleccionar un archivo");
                }

                if (!File.Exists(txtAbrirArchivo.Text))
                {
                    throw new Exception("El archivo no existe");
                }

                FileStream fs = new FileStream(txtAbrirArchivo.Text, FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);

                sw.WriteLine(txtEscribir.Text);
                sw.Flush();
                fs.Close();

                MessageBox.Show("Archivo escrito");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtAbrirArchivo.Text))
                {
                    throw new Exception("Debe seleccionar un archivo");
                }

                if (!File.Exists(txtAbrirArchivo.Text))
                {
                    throw new Exception("El archivo no existe");
                }

                FileStream fs = new FileStream(txtAbrirArchivo.Text, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                txtLeer.Text = sr.ReadToEnd();

                fs.Close();


                MessageBox.Show("Archivo leido");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnEncontrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtAbrirArchivo.Text))
                {
                    throw new Exception("Debe seleccionar un archivo");
                }

                if (!File.Exists(txtAbrirArchivo.Text))
                {
                    throw new Exception("El archivo no existe");
                }

                FileStream fs = new FileStream(txtAbrirArchivo.Text, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                var contenido = sr.ReadToEnd();

                int i = contenido.IndexOf(txtEncontrar.Text.Trim(), 0);

                if (i > -1)
                {
                    MessageBox.Show("Texto encontrado");
                }
                else
                {
                    MessageBox.Show("Texto no encontrado");
                }

                fs.Close();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtAbrirArchivo.Text))
                {
                    throw new Exception("Debe seleccionar un archivo");
                }

                if (!File.Exists(txtAbrirArchivo.Text))
                {
                    throw new Exception("El archivo no existe");
                }

                var path = txtAbrirArchivo.Text;

                var sw = File.AppendText(path);
                sw.WriteLine(txtActualizar.Text);

                sw.Close();

                MessageBox.Show("Archivo actualizado");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}