using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;

namespace Prolipa.vistas
{
    public partial class Inicio : Form
    {

        Process process = new Process();
        Timer timer1 = new Timer();
        int plus = 2;

        public Inicio()
        {
            InitializeComponent();
            CreateDirectoryIfDoesNotExist(@"C:\Users\Public\InstaladorProlipa");
            this.update.Hide();
            this.login.Hide();
            this.local.Hide();
            this.web.Hide();
            Transition t = new Transition(new TransitionType_EaseInEaseOut(800));
            t.add(this.panel2, "Left", 6);
            t.add(this.panel1, "Top", 193);
            t.add(this.panel3, "Left", 634);
            verificarupdate();
            t.run();
        }

        public void levantarphp()
        {
            if (File.Exists(@"C:\Users\Public\Prolipa\server.bat"))
            {

                ProcessStartInfo psi = new ProcessStartInfo(@"C:\Users\Public\Prolipa\server.bat");
                psi.CreateNoWindow = true;
                psi.UseShellExecute = false;
                process.StartInfo = psi;
                process.Start();
                //InitializeChromium();
            }
            else
            {
                menu.Hide();
                update.Show();
                updated();
            }


        }

        public async void verificarupdate()
        {
            if (File.Exists(@"C:\Users\Public\InstaladorProlipa\LocalV9.exe"))
            {
                levantarphp();
            }
            else
            {
                menu.Hide();
                update.Show();
                updated();
            }
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            try
            {
                var resultado = from item in System.Diagnostics.Process.GetProcesses()
                                where item.ProcessName.ToUpper() == "PHP"
                                select item;

                foreach (var item in resultado)
                {
                    item.Kill();
               }
            }
            catch (Exception ee)
            {

            }
            Application.Exit();
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Maximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            Maximizar.Visible = false;
            Restaurar.Visible = true;
        }

        private void Restaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            Restaurar.Visible = false;
            Maximizar.Visible = true;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            //Transition t = new Transition(new TransitionType_EaseInEaseOut(800));
            //t.add(this.label2, "Left", 60);
            //t.add(this.rmenu, "Left", 24);
            //t.run();
            //this.menu.Hide();
            //this.local.Hide();
            //this.login.Hide();
            //this.web.Show();
            try
            {
                System.Diagnostics.Process.Start("chrome.exe", "https://plataforma.prolipadigital.com.ec/");
            }
            catch (Exception)
            {
                try
                {
                    System.Diagnostics.Process.Start("firefox.exe", "https://plataforma.prolipadigital.com.ec/");
                }
                catch (Exception)
                {
                    try
                    {
                        System.Diagnostics.Process.Start("opera.exe", "https://plataforma.prolipadigital.com.ec/");
                    }
                    catch (Exception)
                    {
                        System.Diagnostics.Process.Start("https://plataforma.prolipadigital.com.ec/");

                    }
                }
            }
        }

        private void regresarmenu_Click(object sender, EventArgs e)
        {
            Transition t = new Transition(new TransitionType_EaseInEaseOut(800));
            t.add(this.rmenu, "Left", -90);
            t.add(this.label2, "Left", -60);
            t.run();
            this.menu.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Transition t = new Transition(new TransitionType_EaseInEaseOut(800));
            t.add(this.label2, "Left", 60);
            t.add(this.rmenu, "Left", 24);
            t.run();
            this.web.Hide();
            this.menu.Hide();
            this.local.Hide();
            this.login.Show();
            Principal pr = new Principal();
            pr.TopLevel = false;
            pr.Dock = DockStyle.Fill;
            this.login.Controls.Add(pr);
            pr.Show();

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            //Transition t = new Transition(new TransitionType_EaseInEaseOut(800));
            //t.add(this.label2, "Left", 60);
            //t.add(this.rmenu, "Left", 24);
            //t.run();
            //this.menu.Hide();
            //this.local.Show();
            //this.login.Hide();
            //this.web.Hide();
            try
            {
                System.Diagnostics.Process.Start("chrome.exe", "http://localhost:54112");
            }
            catch (Exception)
            {
                try
                {
                    System.Diagnostics.Process.Start("firefox.exe", "http://localhost:54112");
                }
                catch (Exception)
                {
                    try
                    {
                        System.Diagnostics.Process.Start("opera.exe", "http://localhost:54112");
                    }
                    catch (Exception)
                    {
                        System.Diagnostics.Process.Start("http://localhost:54112");

                    }
                }
            }
        }

        private void rmenu_MouseHover(object sender, EventArgs e)
        {
            rmenu.BackColor = Color.FromArgb(30, 30, 46);
        }

        private void rmenu_MouseLeave(object sender, EventArgs e)
        {
            rmenu.BackColor = Color.FromArgb(39, 41, 61);
        }

        private void Salir_MouseHover(object sender, EventArgs e)
        {
            Salir.BackColor = Color.Red;

        }

        private void Salir_MouseLeave(object sender, EventArgs e)
        {
            Salir.BackColor = Color.FromArgb(39, 41, 61);
        }


        public void updated()
        {
            timer1.Tick += new EventHandler(move);
            timer1.Interval = 5;
            timer1.Start();
            descargar();
        }

        void move(object sender, EventArgs e)
        {
            panel5.Left = panel5.Left + plus;

            if (panel5.Left > 283)
            {
                plus = -2;
            }
            if (panel5.Left < 0)
            {
                plus = 2;
            }
        }

        public void descargar()
        {
            WebClient oCliente = new WebClient();
            Uri url = new Uri("https://prolipadigital.com.ec/Actualizacion/LocalV9.exe");
            string rutaDirectorio = @"C:\Users\Public\InstaladorProlipa\LocalV1.exe";
            string archivo = Path.GetFileName(url.AbsolutePath);

            oCliente.DownloadProgressChanged += new DownloadProgressChangedEventHandler((sender, e) => mostrarProgreso(sender, e));
            oCliente.DownloadFileCompleted += new AsyncCompletedEventHandler((sender, e) => finalizarDescarga(sender, e));
            oCliente.DownloadFileAsync(url, rutaDirectorio, archivo);
        }

        public void mostrarProgreso(object sender, DownloadProgressChangedEventArgs e)
        {
            int bytesRecibidos = (int)(e.BytesReceived / (1024 * 1024));
            int bytesTotales = (int)(e.TotalBytesToReceive / (1024 * 1024));
            label4.Text = e.ProgressPercentage.ToString() + "%";
        }
        public void finalizarDescarga(object sender, AsyncCompletedEventArgs e)
        {
            label3.Text = "Instalando...";
            label4.Hide();
            ejecute();
        }

        public async Task ejecute()
        {
            try
            {
                await Task.Run(() =>
                {
                    ProcessStartInfo pInfo = new ProcessStartInfo();
                    pInfo.FileName = @"C:\Users\Public\InstaladorProlipa\LocalV9.exe";
                    Process p = Process.Start(pInfo);
                    p.WaitForInputIdle();
                    p.WaitForExit();
                    levantarphp();
                });
                this.update.Hide();
                this.menu.Show();

            }
            catch (Exception e)
            {

            }

        }

        private void CreateDirectoryIfDoesNotExist(string dirName)
        {
            System.IO.Directory.CreateDirectory(dirName);
        }
    }
}
