using Newtonsoft.Json;
using Prolipa.vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace AppProlipa.controladores
{
    class Libros
    {
        private string idlibro = "";
        private string nombrelibro = "";
        private string ziplibro = "";
        private string descripcion = "";
        private string sguia = "";
        private string cguia = "";
        private string dguia = "";




        public Libros()
        {
        }

        public Libros(string idlibro, string nombrelibro, string ziplibro, string descripcion)
        {
            this.idlibro = idlibro;
            this.nombrelibro = nombrelibro;
            this.ziplibro = ziplibro;
            this.descripcion = descripcion;
        }

        public string Idlibro { get => idlibro; set => idlibro = value; }
        public string Nombrelibro { get => nombrelibro; set => nombrelibro = value; }
        public string Ziplibro { get => ziplibro; set => ziplibro = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Sguia { get => sguia; set => sguia = value; }
        public string Cguia { get => cguia; set => cguia = value; }
        public string Dguia { get => dguia; set => dguia = value; }

        public  async Task<List<Libros>> buscarlibros(String idusuario)
        {
            List<Libros> listalibro = new List<Libros>();
            await Task.Run(() =>
            {
                 try
            {
                string url = "https://prolipadigital.com.ec/software/PlataformaProlipa/public/api/libro?idusuario="+ idusuario;
                var json = new WebClient().DownloadString(url);
                dynamic datos = JsonConvert.DeserializeObject(json);
                foreach (var dato in datos)
                {
                    if(dato.ziplibro != null){
                        Libros libro = new Libros();
                        libro.Nombrelibro=dato.nombrelibro.ToString();
                        libro.Descripcion=dato.descripcionlibro.ToString();
                        libro.Ziplibro = dato.ziplibro.ToString();
                        libro.Sguia = dato.pdfsinguia.ToString();
                        libro.Cguia = dato.pdfconguia.ToString();
                        libro.Dguia = dato.guiadidactica.ToString();
                        listalibro.Add(libro);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex);

            }
            });
            return listalibro;
        }
    }
}
