using AppProlipa.controladores;
using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prolipa.controladores;
using Transitions;
using Newtonsoft.Json;

namespace Prolipa.vistas
{
    public partial class Principal : Form
    {
        List<Libros> listaL = new List<Libros>();
        List<string> listalibro = new List<string>();
        List<Cuadernos> listaC = new List<Cuadernos>();
        List<string> listacuaderno = new List<string>();
        List<Guias> listaG = new List<Guias>();
        List<string> listaguia = new List<string>();
        List<PlanLector> listaP = new List<PlanLector>();
        List<string> listaplanlector = new List<string>();
        List<MaterialApoyo> listaM = new List<MaterialApoyo>();
        List<string> listamaterial = new List<string>();
        List<Planificaciones> listaPl = new List<Planificaciones>();
        List<string> listaplanificacion = new List<string>();

        List<string> listasguia = new List<string>();
        List<string> listacguia = new List<string>();
        List<string> listadguia = new List<string>();

        String zip = ".zip";
        String doc = "";
        string rutaDirectorio;
        int codigo = 0;
        string idusuario = "";

        public Principal()
        {
            InitializeComponent();
            this.descarga.Hide();
            this.btnLibro.BackColor = Color.FromArgb(30, 30, 46);
            this.cuadernoSubMenu.Hide();
            this.guiaSubMenu.Hide();
            this.checkedListBox1.Items.Clear();
        }
        public void Libros()
        {
            this.label11.Text = "Libros";
            this.checkedListBox1.Items.Clear();
            this.button1.Click -= BunifuFlatButton11_Click;
            this.button1.Click -= BunifuFlatButton9_Click;
            this.button1.Click -= BunifuFlatButton8_Click;
            this.button1.Click -= BunifuFlatButton7_Click;
            this.button1.Click -= bunifuFlatButton6_Click;
            this.button1.Click += Button1_Click;
            this.label11.Text = "Libros";
            foreach (var dato in listaL)
            {
                if (dato.Ziplibro != null)
                {
                    checkedListBox1.Items.Add(dato.Ziplibro.ToString());
                }
            }
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        private void MenuSidebar_Click(object sender, EventArgs e)
        {
            if (Sidebar.Width == 234)
            {
                Sidebar.Visible = false;
                Sidebar.Width = 54;
                SidebarWrapper.Width = 80;
                AnimacionSidebar.Show(Sidebar);
            }
            else
            {
                Sidebar.Visible = false;
                Sidebar.Width = 234;
                SidebarWrapper.Width = 260;
                AnimacionSidebarBack.Show(Sidebar);
            }
        }

        public void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.label11.Text = "Libros";
            this.check.Checked = false;
            
            this.checkedListBox1.Items.Clear();
            this.button1.Click -= bunifuFlatButton70_Click;
            this.button1.Click -= bunifuFlatButton71_Click;
            this.button1.Click -= bunifuFlatButton69_Click;
            this.button1.Click -= BunifuFlatButton11_Click;
            this.button1.Click -= BunifuFlatButton9_Click;
            this.button1.Click -= BunifuFlatButton8_Click;
            this.button1.Click -= BunifuFlatButton7_Click;
            this.button1.Click -= bunifuFlatButton6_Click;
            this.button1.Click += Button1_Click;
            foreach (var dato in listaL)
            {
                if (dato.Ziplibro != null)
                {
                    checkedListBox1.Items.Add(dato.Ziplibro.ToString());
                }
            }

            this.btnLibro.BackColor = Color.FromArgb(30, 30, 46);
            this.btnCuaderno.BackColor = Color.Transparent;
            this.btnGuias.BackColor = Color.Transparent;
            this.btnPlanlector.BackColor = Color.Transparent;
            this.btnMaterial.BackColor = Color.Transparent;
            this.btnPlanificaciones.BackColor = Color.Transparent;
            this.guiaSubMenu.Hide();
            this.cuadernoSubMenu.Hide();
            this.libroSubMenu.Show();
        }

        private void BunifuFlatButton5_Click(object sender, EventArgs e)
        {
            this.label11.Text = "Material de Apoyo";
            this.check.Checked = false;

            this.checkedListBox1.Items.Clear();
            this.button1.Click -= bunifuFlatButton70_Click;
            this.button1.Click -= bunifuFlatButton71_Click;
            this.button1.Click -= bunifuFlatButton69_Click;
            this.button1.Click -= BunifuFlatButton9_Click;
            this.button1.Click -= BunifuFlatButton8_Click;
            this.button1.Click -= BunifuFlatButton7_Click;
            this.button1.Click -= bunifuFlatButton6_Click;
            this.button1.Click -= Button1_Click;
            this.button1.Click += BunifuFlatButton11_Click;
            foreach (var dato in listaM)
            {
                if (dato.Zipmaterial != null)
                {
                    checkedListBox1.Items.Add(dato.Zipmaterial.ToString());
                }
            }
            this.btnLibro.BackColor = Color.Transparent;
            this.btnCuaderno.BackColor = Color.Transparent;
            this.btnGuias.BackColor = Color.Transparent;
            this.btnPlanlector.BackColor = Color.Transparent;
            this.btnMaterial.BackColor = Color.FromArgb(30, 30, 46);
            this.btnPlanificaciones.BackColor = Color.Transparent;
            this.libroSubMenu.Hide();
            this.guiaSubMenu.Hide();
            this.cuadernoSubMenu.Hide();
        }

        private void BunifuFlatButton4_Click(object sender, EventArgs e)
        {
            this.label11.Text = "Plan Lector";
            this.check.Checked = false;

            this.checkedListBox1.Items.Clear();
            this.button1.Click -= bunifuFlatButton70_Click;
            this.button1.Click -= bunifuFlatButton71_Click;
            this.button1.Click -= bunifuFlatButton69_Click;
            this.button1.Click -= BunifuFlatButton11_Click;
            this.button1.Click -= BunifuFlatButton8_Click;
            this.button1.Click -= BunifuFlatButton7_Click;
            this.button1.Click -= bunifuFlatButton6_Click;
            this.button1.Click -= Button1_Click;
            this.button1.Click += BunifuFlatButton9_Click;
            foreach (var dato in listaP)
            {
                if (dato.Zipplanlector != null)
                {
                    checkedListBox1.Items.Add(dato.Zipplanlector.ToString());
                }
            }
            this.btnLibro.BackColor = Color.Transparent;
            this.btnCuaderno.BackColor = Color.Transparent;
            this.btnGuias.BackColor = Color.Transparent;
            this.btnPlanlector.BackColor = Color.FromArgb(30, 30, 46);
            this.btnMaterial.BackColor = Color.Transparent;
            this.btnPlanificaciones.BackColor = Color.Transparent;
            this.libroSubMenu.Hide();
            this.guiaSubMenu.Hide();
            this.cuadernoSubMenu.Hide();
        }

        private void BunifuFlatButton3_Click(object sender, EventArgs e)
        {
            this.label11.Text = "Guías";
            this.check.Checked = false;

            this.checkedListBox1.Items.Clear();
            this.button1.Click -= bunifuFlatButton70_Click;
            this.button1.Click -= bunifuFlatButton71_Click;
            this.button1.Click -= bunifuFlatButton69_Click;
            this.button1.Click -= BunifuFlatButton11_Click;
            this.button1.Click -= BunifuFlatButton9_Click;
            this.button1.Click -= BunifuFlatButton7_Click;
            this.button1.Click -= bunifuFlatButton6_Click;
            this.button1.Click -= Button1_Click;
            this.button1.Click += BunifuFlatButton8_Click;
            foreach (var dato in listaG)
            {
                if (dato.Zipguias != null)
                {
                    checkedListBox1.Items.Add(dato.Zipguias.ToString());
                }
            }
            this.btnLibro.BackColor = Color.Transparent;
            this.btnCuaderno.BackColor = Color.Transparent;
            this.btnGuias.BackColor = Color.FromArgb(30, 30, 46);
            this.btnPlanlector.BackColor = Color.Transparent;
            this.btnMaterial.BackColor = Color.Transparent;
            this.btnPlanificaciones.BackColor = Color.Transparent;
            this.libroSubMenu.Hide();
            this.guiaSubMenu.Show();
            this.cuadernoSubMenu.Hide();
        }

        private void BunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.label11.Text = "Cuadernos";
            this.check.Checked = false;

            this.checkedListBox1.Items.Clear();
            this.button1.Click -= bunifuFlatButton70_Click;
            this.button1.Click -= bunifuFlatButton71_Click;
            this.button1.Click -= bunifuFlatButton69_Click;
            this.button1.Click -= BunifuFlatButton11_Click;
            this.button1.Click -= BunifuFlatButton9_Click;
            this.button1.Click -= BunifuFlatButton8_Click;
            this.button1.Click -= bunifuFlatButton6_Click;
            this.button1.Click -= Button1_Click;
            this.button1.Click += BunifuFlatButton7_Click;
            foreach (var dato in listaC)
            {
                if (dato.Zipcuadernos != null)
                {
                    checkedListBox1.Items.Add(dato.Zipcuadernos.ToString());
                }
            }
            this.btnLibro.BackColor = Color.Transparent;
            this.btnCuaderno.BackColor = Color.FromArgb(30, 30, 46);
            this.btnGuias.BackColor = Color.Transparent;
            this.btnPlanlector.BackColor = Color.Transparent;
            this.btnMaterial.BackColor = Color.Transparent;
            this.btnPlanificaciones.BackColor = Color.Transparent;
            this.libroSubMenu.Hide();
            this.guiaSubMenu.Hide();
            this.cuadernoSubMenu.Show();
        }

        private void BunifuFlatButton10_Click(object sender, EventArgs e)
        {
            this.label11.Text = "Planificaciones";
            this.check.Checked = false;

            this.checkedListBox1.Items.Clear();
            this.button1.Click -= bunifuFlatButton70_Click;
            this.button1.Click -= bunifuFlatButton71_Click;
            this.button1.Click -= bunifuFlatButton69_Click;
            this.button1.Click -= BunifuFlatButton11_Click;
            this.button1.Click -= BunifuFlatButton9_Click;
            this.button1.Click -= BunifuFlatButton8_Click;
            this.button1.Click -= BunifuFlatButton7_Click;
            this.button1.Click -= Button1_Click;
            this.button1.Click += bunifuFlatButton6_Click;
            foreach (var dato in listaPl)
            {
                Console.WriteLine(dato.Webplanificacion);
                if (dato.Webplanificacion != null)
                {
                    checkedListBox1.Items.Add(dato.Webplanificacion.ToString());
                }
            }
            this.btnLibro.BackColor = Color.Transparent;
            this.btnCuaderno.BackColor = Color.Transparent;
            this.btnGuias.BackColor = Color.Transparent;
            this.btnPlanlector.BackColor = Color.Transparent;
            this.btnMaterial.BackColor = Color.Transparent;
            this.btnPlanificaciones.BackColor = Color.FromArgb(30, 30, 46);
            this.libroSubMenu.Hide();
            this.guiaSubMenu.Hide();
            this.cuadernoSubMenu.Hide();
        }

        // Descarga
        private void mostrarProgreso(object sender, DownloadProgressChangedEventArgs e, FlowLayoutPanel panel)
        {
            try
            {
                int bytesRecibidos = (int)(e.BytesReceived / (1024 * 1024));
                int bytesTotales = (int)(e.TotalBytesToReceive / (1024 * 1024));
                string archivo = e.UserState.ToString();
                Control[] rpta = panel.Controls.Find("pn" + archivo, false);
                Control[] rptas = rpta[0].Controls.Find("pg" + archivo, false);
                Control[] pr = rpta[0].Controls.Find("pr" + archivo, false);
                if (rptas != null && rptas.Length > 0)
                {
                    ProgressBar pbr = (ProgressBar)rptas[0];
                    Label l = (Label)pr[0];
                    pbr.Value = e.ProgressPercentage;
                    l.Text = e.ProgressPercentage.ToString() + "%";
                }
            }
            catch (Exception er)
            {
                Console.WriteLine("El error es = " + er);
            }

        }

        private async void finalizarDescarga(object sender, AsyncCompletedEventArgs e, FlowLayoutPanel panel, string destino, String ext)
        {
            string archivo = e.UserState.ToString();
            Console.WriteLine(archivo);

            Control[] rpta = panel.Controls.Find("pn" + archivo, false);
            Control[] rptas = rpta[0].Controls.Find("pg" + archivo, false);
            Control[] pr = rpta[0].Controls.Find("pr" + archivo, false);
            Control[] st = rpta[0].Controls.Find("st" + archivo, false);
            Control[] btn = rpta[0].Controls.Find("btn" + archivo, false);

            if (rptas != null && rptas.Length > 0)
            {
                Label std = (Label)st[0];
                std.Text = "";
                Label l = (Label)pr[0];
                l.Size = new Size(80, 40);
                l.Location = new Point(186, 70);
                l.Text = "Instalando...";
                if (ext == ".zip")
                {
                    string estado = await descomprimirlibro(archivo, destino);
                    l.Text = estado.ToString();
                    Button bt = (Button)btn[0];
                    bt.Show();
                }
                else
                {
                    l.Text = "Finalizado";
                }

            }

        }

        public async Task<string> descomprimirlibro(String carpeta, String destino)
        {
            string estado = "";
            await Task.Run(() =>
            {
                string rutaDirectorio = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                string zipToUnpack = destino + carpeta;
                string unpackDirectory = destino;

                bool res = verificarArchivo(zipToUnpack);

                if (res == true)
                {
                    using (ZipFile zip1 = ZipFile.Read(zipToUnpack))
                    {
                        foreach (ZipEntry a in zip1)
                        {
                            a.Extract(unpackDirectory, ExtractExistingFileAction.OverwriteSilently);
                        }
                    }
                    File.Delete(zipToUnpack);
                    estado = "Finalizado";
                }
                else
                {
                    estado = "Finalizado";
                }
            });
            return estado;
        }

        public bool verificarArchivo(string directorio)
        {
            if (File.Exists(directorio))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void iniciarDescarga(String carpeta, String web, String destino, int codigo, FlowLayoutPanel panel, String abrir, String ext)
        {
            WebClient oCliente = new WebClient();
            Uri url = new Uri(web + carpeta + ext);
            string archivo = Path.GetFileName(url.AbsolutePath);
            string abrirdireccion = abrir + carpeta + "/index.php";
            string axu;
            if (ext == ".zip")
            {
                axu = codigo + ext;
                rutaDirectorio = destino + codigo + ext;

            }
            else
            {
                rutaDirectorio = destino + archivo + ext;
                axu = archivo;
            }
            ServicePointManager.DefaultConnectionLimit = 10;

            ProgressBar pbr = new ProgressBar();
            pbr.Name = "pg" + axu;
            pbr.Visible = true;
            pbr.Location = new Point(2, 40);
            pbr.Size = new Size(420, 10);

            Label titulo = new Label();
            titulo.Text = carpeta;
            titulo.Font = new Font("Arial", 8, FontStyle.Bold);
            titulo.Location = new Point(5, 13);
            titulo.Size = new Size(420, 20);
            titulo.BackColor = Color.Transparent;

            Label estado = new Label();
            estado.Name = "st" + axu;
            estado.Text = "Descargando";
            estado.Location = new Point(186, 53);
            estado.Font = new Font("Arial", 8, FontStyle.Bold);
            estado.BackColor = Color.Transparent;

            Label porcentaje = new Label();
            porcentaje.Name = "pr" + axu;
            porcentaje.Size = new Size(40, 40);
            porcentaje.Font = new Font("Arial", 8, FontStyle.Bold);
            porcentaje.Text = "0%";
            porcentaje.Location = new Point(208, 70);
            porcentaje.BackColor = Color.Transparent;

            Bunifu.Framework.UI.BunifuCards pan = new Bunifu.Framework.UI.BunifuCards();
            pan.Name = "pn" + axu;
            pan.color = Color.DodgerBlue;
            pan.BackColor = Color.FromArgb(30, 30, 46);
            pan.AutoSize = true;
            pan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            pan.ForeColor = Color.White;

            Button btn = new Button();
            btn.Name = "btn" + axu;
            btn.Text = "Ver";
            btn.Click += new EventHandler((sender, e) => verdescarga_Click(sender, e, abrirdireccion));
            btn.Location = new Point(180, 90);
            btn.Hide();

            Bunifu.Framework.UI.BunifuElipse style = new Bunifu.Framework.UI.BunifuElipse();
            style.ElipseRadius = 100;
            pan.Controls.Add(style.TargetControl);
            pan.Controls.Add(btn);
            pan.Controls.Add(titulo);
            pan.Controls.Add(porcentaje);
            pan.Controls.Add(estado);
            pan.Controls.Add(pbr);
            panel.Controls.Add(pan);

            carpeta = "";
            oCliente.DownloadProgressChanged += new DownloadProgressChangedEventHandler((sender, e) => mostrarProgreso(sender, e, panel));
            oCliente.DownloadFileCompleted += new AsyncCompletedEventHandler((sender, e) => finalizarDescarga(sender, e, panel, destino, ext));
            oCliente.DownloadFileAsync(url, rutaDirectorio, axu);
        }

        void verdescarga_Click(object sender, EventArgs e, String destino)
        {

            try
            {
                System.Diagnostics.Process.Start("chrome.exe", destino);
            }
            catch (Exception)
            {
                try
                {
                    System.Diagnostics.Process.Start("firefox.exe", destino);
                }
                catch (Exception)
                {
                    try
                    {
                        System.Diagnostics.Process.Start("opera.exe", destino);
                    }
                    catch (Exception)
                    {
                        System.Diagnostics.Process.Start(destino);

                    }
                }
            }

        }

        void descargaLibro(List<string> listalibro, FlowLayoutPanel panel)
        {
            string web = "https://prolipadigital.com.ec/software/PlataformaProlipa/public/upload/ziplibros/";
            string destino = "C:\\Users\\Public\\Prolipa\\www\\Libro\\";
            string abrir = "http://localhost:54112/Libro/";
            rutaDirectorio = destino;
            CreateDirectoryIfDoesNotExist(rutaDirectorio);
            foreach (string carpeta in listalibro)
            {
                codigo++;
                this.iniciarDescarga(carpeta, web, destino, codigo, panel, abrir, zip);
            }
        }
        void descargacuaderno(List<string> listacuaderno, FlowLayoutPanel panel)
        {
            string web = "https://prolipadigital.com.ec/software/PlataformaProlipa/public/upload/zipcuadernos/";
            string destino = "C:\\Users\\Public\\Prolipa\\www\\Cuaderno\\";
            string abrir = "http://localhost:54112/Cuaderno/";
            rutaDirectorio = destino;
            CreateDirectoryIfDoesNotExist(rutaDirectorio);
            foreach (string carpeta in listacuaderno)
            {
                codigo++;
                this.iniciarDescarga(carpeta, web, destino, codigo, panel, abrir, zip);
            }
        }
        void descargaguia(List<string> listaguia, FlowLayoutPanel panel)
        {
            string web = "https://prolipadigital.com.ec/software/PlataformaProlipa/public/upload/zipguias/";
            string destino = "C:\\Users\\Public\\Prolipa\\www\\Guia\\";
            string abrir = "http://localhost:54112/Guia/";
            rutaDirectorio = destino;
            CreateDirectoryIfDoesNotExist(rutaDirectorio);
            foreach (string carpeta in listaguia)
            {
                codigo++;
                this.iniciarDescarga(carpeta, web, destino, codigo, panel, abrir, zip);
            }
        }

        void descargaplanlector(List<string> listaplanlector, FlowLayoutPanel panel)
        {
            string web = "https://prolipadigital.com.ec/software/PlataformaProlipa/public/upload/zipplanlector/";
            string destino = "C:\\Users\\Public\\Prolipa\\www\\Planlector\\";
            string abrir = "http://localhost:54112/Planlector/";
            rutaDirectorio = destino;
            CreateDirectoryIfDoesNotExist(rutaDirectorio);
            foreach (string carpeta in listaplanlector)
            {
                codigo++;
                this.iniciarDescarga(carpeta, web, destino, codigo, panel, abrir, zip);
            }
        }

        void descargamaterial(List<string> listamaterial, FlowLayoutPanel panel)
        {
            string web = "https://prolipadigital.com.ec/software/PlataformaProlipa/public/upload/zipmateriales/";
            string destino = "C:\\Users\\Public\\Prolipa\\www\\Material\\";
            string abrir = "http://localhost:54112/Material/";
            rutaDirectorio = destino;
            CreateDirectoryIfDoesNotExist(rutaDirectorio);
            foreach (string carpeta in listamaterial)
            {
                codigo++;
                this.iniciarDescarga(carpeta, web, destino, codigo, panel, abrir, zip);
            }
        }

        void descargaplanificacion(List<string> listaplanificacion, FlowLayoutPanel panel)
        {
            string web = "https://prolipadigital.com.ec/software/PlataformaProlipa/public/upload/planificacion/";
            string destino = "C:\\Users\\Public\\Prolipa\\www\\Planificaciones\\";
            string abrir = "http://localhost:54112/Planificacion/";
            rutaDirectorio = destino;
            CreateDirectoryIfDoesNotExist(rutaDirectorio);
            foreach (string carpeta in listaplanificacion)
            {
                codigo++;
                this.iniciarDescarga(carpeta, web, destino, codigo, panel, abrir, doc);
            }
        }

        private void CreateDirectoryIfDoesNotExist(string dirName)
        {
            System.IO.Directory.CreateDirectory(dirName);
        }


        private void PictureBox12_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Hide();
        }
        private void Button1_Click(object sender, EventArgs e)
        {

            foreach (string s in this.checkedListBox1.CheckedItems)
            {
                this.listalibro.Add(s);
            }
            this.descargaLibro(listalibro, flowLayoutPanel1);
            for (int i = 0; i < this.checkedListBox1.Items.Count; i++)
            {
                this.checkedListBox1.SetItemChecked(i, false);
            }
            listalibro.Clear();
            this.check.Checked = false;
        }

        private void BunifuFlatButton7_Click(object sender, EventArgs e)
        {

            foreach (string s in this.checkedListBox1.CheckedItems)
            {
                this.listacuaderno.Add(s);
            }
            this.descargacuaderno(listacuaderno, flowLayoutPanel1);
            for (int i = 0; i < this.checkedListBox1.Items.Count; i++)
            {
                this.checkedListBox1.SetItemChecked(i, false);
            }
            listacuaderno.Clear();
            this.check.Checked = false;
        }

        private void BunifuFlatButton8_Click(object sender, EventArgs e)
        {

            foreach (string s in this.checkedListBox1.CheckedItems)
            {
                this.listaguia.Add(s);
            }
            this.descargaguia(listaguia, flowLayoutPanel1);
            for (int i = 0; i < this.checkedListBox1.Items.Count; i++)
            {
                this.checkedListBox1.SetItemChecked(i, false);
            }
            listaguia.Clear();
            this.check.Checked = false;
        }

        private void BunifuFlatButton9_Click(object sender, EventArgs e)
        {

            foreach (string s in this.checkedListBox1.CheckedItems)
            {
                this.listaplanlector.Add(s);
            }
            this.descargaplanlector(listaplanlector, flowLayoutPanel1);
            for (int i = 0; i < this.checkedListBox1.Items.Count; i++)
            {
                this.checkedListBox1.SetItemChecked(i, false);
            }
            listaplanlector.Clear();
            this.check.Checked = false;
        }

        private void BunifuFlatButton11_Click(object sender, EventArgs e)
        {

            foreach (string s in this.checkedListBox1.CheckedItems)
            {
                this.listamaterial.Add(s);
            }
            this.descargamaterial(listamaterial, flowLayoutPanel1);
            for (int i = 0; i < this.checkedListBox1.Items.Count; i++)
            {
                this.checkedListBox1.SetItemChecked(i, false);
            }
            listamaterial.Clear();
            this.check.Checked = false;
        }

        public async void ingresarProlipa()
        {
            bool conexion = this.HayInternet();
            string usuario = this.usuario.Text;
            string password = this.password.Text;
            Usuario login = new Usuario();
            if (conexion == true)
            {
                idusuario = await login.login(usuario, password);
                Console.WriteLine("Id del Usuario = " + idusuario);
                if (idusuario == null || idusuario == "")
                {
                    error error = new error();
                    error.Show();
                    ingresar.Click += ingresar_Click;
                }
                else
                {
                    success success = new success();
                    success.Show();
                    this.login.Hide();
                    this.descarga.Show();
                    Libros libro = new Libros();
                    listaL = await libro.buscarlibros(idusuario);
                    Libros();
                    Cuadernos cuaderno = new Cuadernos();
                    listaC = await cuaderno.buscarcuadernos(idusuario);
                    Guias guias = new Guias();
                    listaG = await guias.buscarguias(idusuario);
                    PlanLector planLector = new PlanLector();
                    listaP = await planLector.buscarplanlector(idusuario);
                    MaterialApoyo material = new MaterialApoyo();
                    listaM = await material.buscarmaterial(idusuario);
                    Planificaciones planificacion = new Planificaciones();
                    listaPl = await planificacion.buscarplanificaciones(idusuario);
                    crearbaseregion(idusuario);
                }
            }
            else
            {
                MessageBox.Show("No tiene una conexion a internet", "Mensaje informativo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ingresar_Click(object sender, EventArgs e)
        {
            ingresar.Click -= ingresar_Click;
            this.ingresarProlipa();
        }
        private bool HayInternet()
        {
            try
            {
                System.Net.IPHostEntry host = System.Net.Dns.GetHostEntry("www.google.com");
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {

            foreach (string s in this.checkedListBox1.CheckedItems)
            {
                this.listaplanificacion.Add(s);
            }
            this.descargaplanificacion(listaplanificacion, flowLayoutPanel1);
            for (int i = 0; i < this.checkedListBox1.Items.Count; i++)
            {
                this.checkedListBox1.SetItemChecked(i, false);
            }
            listaplanificacion.Clear();
            this.check.Checked = false;

        }

        public async void crearbaseregion(string idusuario)
        {
            await Task.Run(() =>
            {
                try
                {

                    string url = "https://prolipadigital.com.ec/software/PlataformaProlipa/public/api/aplicativobase?idusuario=" + idusuario;
                    var json = new WebClient().DownloadString(url);
                    dynamic datos = JsonConvert.DeserializeObject(json);
                    foreach (var dato in datos)
                    {
                        WebClient cliente = new WebClient();
                        string destino = @"C:\Users\Public\Linux\ext\libro.sqlite";
                        CreateDirectoryIfDoesNotExist(@"C:\Users\Public\Linux\ext\");
                        var ur = "http://prolipadigital.com.ec/Bases/" + dato.periodoescolar + "/libro.sqlite";
                        cliente.DownloadFile(ur, destino);

                    }

                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                }
            });
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("chrome.exe", "https://prolipadigital.com.ec/software/PlataformaProlipa/public/password/reset");
            }
            catch (Exception)
            {
                try
                {
                    System.Diagnostics.Process.Start("firefox.exe", "https://prolipadigital.com.ec/software/PlataformaProlipa/public/password/reset");
                }
                catch (Exception)
                {
                    try
                    {
                        System.Diagnostics.Process.Start("opera.exe", "https://prolipadigital.com.ec/software/PlataformaProlipa/public/password/reset");
                    }
                    catch (Exception)
                    {
                        System.Diagnostics.Process.Start("https://prolipadigital.com.ec/software/PlataformaProlipa/public/password/reset");
                    }
                }
            }
        }

        private void Sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.check.Checked = false;
            this.button1.Click -= BunifuFlatButton11_Click;
            this.button1.Click -= BunifuFlatButton9_Click;
            this.button1.Click -= BunifuFlatButton8_Click;
            this.button1.Click -= BunifuFlatButton7_Click;
            this.button1.Click -= Button1_Click;
            this.button1.Click -= bunifuFlatButton6_Click;
            this.button1.Click -= bunifuFlatButton70_Click;
            this.button1.Click -= bunifuFlatButton71_Click;
            this.button1.Click += bunifuFlatButton69_Click;
            this.checkedListBox1.Items.Clear();
            this.label11.Text = "Pdf sin guía";
            foreach (var dato in listaL)
            {
                if (dato.Sguia == "")
                {
                }
                else
                {
                    checkedListBox1.Items.Add(dato.Sguia.ToString());
                }
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.check.Checked = false;
            this.button1.Click -= BunifuFlatButton11_Click;
            this.button1.Click -= BunifuFlatButton9_Click;
            this.button1.Click -= BunifuFlatButton8_Click;
            this.button1.Click -= BunifuFlatButton7_Click;
            this.button1.Click -= Button1_Click;
            this.button1.Click -= bunifuFlatButton6_Click;
            this.button1.Click -= bunifuFlatButton71_Click;
            this.button1.Click -= bunifuFlatButton69_Click;
            this.button1.Click += bunifuFlatButton70_Click;
            this.checkedListBox1.Items.Clear();
            this.label11.Text = "Pdf con guía";

            foreach (var dato in listaL)
            {
                if (dato.Cguia == "")
                {
                }
                else
                {
                    checkedListBox1.Items.Add(dato.Cguia.ToString());
                }
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.check.Checked = false;
            this.button1.Click -= BunifuFlatButton11_Click;
            this.button1.Click -= BunifuFlatButton9_Click;
            this.button1.Click -= BunifuFlatButton8_Click;
            this.button1.Click -= BunifuFlatButton7_Click;
            this.button1.Click -= Button1_Click;
            this.button1.Click -= bunifuFlatButton6_Click;
            this.button1.Click -= bunifuFlatButton69_Click;
            this.button1.Click -= bunifuFlatButton70_Click;
            this.button1.Click += bunifuFlatButton71_Click;
            this.checkedListBox1.Items.Clear();
            this.label11.Text = "Pdf guía didáctica";
            foreach (var dato in listaL)
            {
                if (dato.Dguia == "")
                {
                }
                else
                {
                    checkedListBox1.Items.Add(dato.Dguia.ToString());
                }
            }
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            this.check.Checked = false;
            this.button1.Click -= BunifuFlatButton11_Click;
            this.button1.Click -= BunifuFlatButton9_Click;
            this.button1.Click -= BunifuFlatButton8_Click;
            this.button1.Click -= BunifuFlatButton7_Click;
            this.button1.Click -= Button1_Click;
            this.button1.Click -= bunifuFlatButton6_Click;
            this.button1.Click -= bunifuFlatButton70_Click;
            this.button1.Click -= bunifuFlatButton71_Click;
            this.button1.Click += bunifuFlatButton69_Click;
            this.checkedListBox1.Items.Clear();
            this.label11.Text = "Pdf sin guía";
            foreach (var dato in listaC)
            {
                if (dato.Sguia == "")
                {
                }
                else
                {
                    checkedListBox1.Items.Add(dato.Sguia.ToString());
                }
            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            this.check.Checked = false;
            this.button1.Click -= BunifuFlatButton11_Click;
            this.button1.Click -= BunifuFlatButton9_Click;
            this.button1.Click -= BunifuFlatButton8_Click;
            this.button1.Click -= BunifuFlatButton7_Click;
            this.button1.Click -= Button1_Click;
            this.button1.Click -= bunifuFlatButton6_Click;
            this.button1.Click -= bunifuFlatButton71_Click;
            this.button1.Click -= bunifuFlatButton69_Click;
            this.button1.Click += bunifuFlatButton70_Click;
            this.checkedListBox1.Items.Clear();
            this.label11.Text = "Pdf con guía";
            foreach (var dato in listaC)
            {
                if (dato.Cguia == "")
                {
                }
                else
                {
                    checkedListBox1.Items.Add(dato.Cguia.ToString());
                }
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            this.check.Checked = false;
            this.button1.Click -= BunifuFlatButton11_Click;
            this.button1.Click -= BunifuFlatButton9_Click;
            this.button1.Click -= BunifuFlatButton8_Click;
            this.button1.Click -= BunifuFlatButton7_Click;
            this.button1.Click -= Button1_Click;
            this.button1.Click -= bunifuFlatButton6_Click;
            this.button1.Click -= bunifuFlatButton69_Click;
            this.button1.Click -= bunifuFlatButton70_Click;
            this.button1.Click += bunifuFlatButton71_Click;
            this.checkedListBox1.Items.Clear();
            this.label11.Text = "Pdf guía didáctica";
            foreach (var dato in listaC)
            {
                if (dato.Dguia == "")
                {
                }
                else
                {
                    checkedListBox1.Items.Add(dato.Dguia.ToString());
                }
            }
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            this.check.Checked = false;
            this.button1.Click -= BunifuFlatButton11_Click;
            this.button1.Click -= BunifuFlatButton9_Click;
            this.button1.Click -= BunifuFlatButton8_Click;
            this.button1.Click -= BunifuFlatButton7_Click;
            this.button1.Click -= Button1_Click;
            this.button1.Click -= bunifuFlatButton6_Click;
            this.button1.Click -= bunifuFlatButton70_Click;
            this.button1.Click -= bunifuFlatButton71_Click;
            this.button1.Click += bunifuFlatButton69_Click;
            this.checkedListBox1.Items.Clear();
            this.label11.Text = "Pdf sin guía";
            foreach (var dato in listaG)
            {
                if (dato.Sguia == "")
                {
                }
                else
                {
                    checkedListBox1.Items.Add(dato.Sguia.ToString());
                }
            }
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            this.check.Checked = false;
            this.button1.Click -= BunifuFlatButton11_Click;
            this.button1.Click -= BunifuFlatButton9_Click;
            this.button1.Click -= BunifuFlatButton8_Click;
            this.button1.Click -= BunifuFlatButton7_Click;
            this.button1.Click -= Button1_Click;
            this.button1.Click -= bunifuFlatButton6_Click;
            this.button1.Click -= bunifuFlatButton71_Click;
            this.button1.Click -= bunifuFlatButton69_Click;
            this.button1.Click += bunifuFlatButton70_Click;
            this.checkedListBox1.Items.Clear();
            this.label11.Text = "Pdf con guía";
            foreach (var dato in listaG)
            {
                if (dato.Cguia == "")
                {
                }
                else
                {
                    checkedListBox1.Items.Add(dato.Cguia.ToString());
                }
            }
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            this.check.Checked = false;
            this.button1.Click -= BunifuFlatButton11_Click;
            this.button1.Click -= BunifuFlatButton9_Click;
            this.button1.Click -= BunifuFlatButton8_Click;
            this.button1.Click -= BunifuFlatButton7_Click;
            this.button1.Click -= Button1_Click;
            this.button1.Click -= bunifuFlatButton6_Click;
            this.button1.Click -= bunifuFlatButton69_Click;
            this.button1.Click -= bunifuFlatButton70_Click;
            this.button1.Click += bunifuFlatButton71_Click;
            this.checkedListBox1.Items.Clear();
            this.label11.Text = "Pdf guía didáctica";
            foreach (var dato in listaG)
            {
                if (dato.Dguia == "")
                {
                }
                else
                {
                    checkedListBox1.Items.Add(dato.Dguia.ToString());
                }
            }
        }

        private void bunifuFlatButton69_Click(object sender, EventArgs e)
        {

            foreach (string s in this.checkedListBox1.CheckedItems)
            {
                this.listasguia.Add(s);
            }
            this.descargasguia(listasguia, flowLayoutPanel1);
            for (int i = 0; i < this.checkedListBox1.Items.Count; i++)
            {
                this.checkedListBox1.SetItemChecked(i, false);
            }
            listasguia.Clear();
            this.check.Checked = false;

        }

        private void bunifuFlatButton70_Click(object sender, EventArgs e)
        {

            foreach (string s in this.checkedListBox1.CheckedItems)
            {
                this.listacguia.Add(s);
            }
            this.descargacguia(listacguia, flowLayoutPanel1);
            for (int i = 0; i < this.checkedListBox1.Items.Count; i++)
            {
                this.checkedListBox1.SetItemChecked(i, false);
            }
            listacguia.Clear();
            this.check.Checked = false;

        }

        private void bunifuFlatButton71_Click(object sender, EventArgs e)
        {

            foreach (string s in this.checkedListBox1.CheckedItems)
            {
                this.listadguia.Add(s);
            }
            this.descargadguia(listadguia, flowLayoutPanel1);
            for (int i = 0; i < this.checkedListBox1.Items.Count; i++)
            {
                this.checkedListBox1.SetItemChecked(i, false);
            }
            listadguia.Clear();
            this.check.Checked = false;

        }

        void descargasguia(List<string> listasguia, FlowLayoutPanel panel)
        {
            string web = "https://prolipadigital.com.ec/software/PlataformaProlipa/public/upload/pdfsinguia/";
            string destino = "C:\\Users\\Public\\Prolipa\\www\\pdfsinguia\\";
            string abrir = "http://localhost:54112/pdfsinguia/";
            rutaDirectorio = destino;
            CreateDirectoryIfDoesNotExist(rutaDirectorio);
            foreach (string carpeta in listasguia)
            {
                codigo++;
                this.iniciarDescarga(carpeta, web, destino, codigo, panel, abrir, doc);
            }
        }

        void descargacguia(List<string> listacguia, FlowLayoutPanel panel)
        {
            string web = "https://prolipadigital.com.ec/software/PlataformaProlipa/public/upload/pdfconguia/";
            string destino = "C:\\Users\\Public\\Prolipa\\www\\pdfconguia\\";
            string abrir = "http://localhost:54112/pdfconguia/";
            rutaDirectorio = destino;
            CreateDirectoryIfDoesNotExist(rutaDirectorio);
            foreach (string carpeta in listacguia)
            {
                codigo++;
                this.iniciarDescarga(carpeta, web, destino, codigo, panel, abrir, doc);
            }
        }

        void descargadguia(List<string> listadguia, FlowLayoutPanel panel)
        {
            string web = "https://prolipadigital.com.ec/software/PlataformaProlipa/public/upload/pdfguiadidactica/";
            string destino = "C:\\Users\\Public\\Prolipa\\www\\pdfguiadidactica\\";
            string abrir = "http://localhost:54112/pdfguiadidactica/";
            rutaDirectorio = destino;
            CreateDirectoryIfDoesNotExist(rutaDirectorio);
            foreach (string carpeta in listadguia)
            {
                codigo++;
                this.iniciarDescarga(carpeta, web, destino, codigo, panel, abrir, doc);
            }
        }

        private void Check_CheckedChanged(object sender, EventArgs e)
        {
            if (this.check.Checked == true)
            {
                for (int i = 0; i < this.checkedListBox1.Items.Count; i++)
                {
                    checkedListBox1.SetItemChecked(i, true);
                }
            }
            else
            {
                for (int i = 0; i < this.checkedListBox1.Items.Count; i++)
                {
                    checkedListBox1.SetItemChecked(i, false);
                }
            }
        }
    }
}
