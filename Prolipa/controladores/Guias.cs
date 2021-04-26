using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


namespace AppProlipa.controladores
{
    class Guias
    {
        private string idguias = "";
        private string nombreguias = "";
        private string zipguias = "";
        private string descripcion = "";
        private string sguia = "";
        private string cguia = "";
        private string dguia = "";

        public Guias()
        {
        }

        public Guias(string idguias, string nombreguias, string zipguias, string descripcion)
        {
            this.idguias = idguias;
            this.nombreguias = nombreguias;
            this.zipguias = zipguias;
            this.descripcion = descripcion;
        }

        public string Idguias { get => idguias; set => idguias = value; }
        public string Nombreguias { get => nombreguias; set => nombreguias = value; }
        public string Zipguias { get => zipguias; set => zipguias = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Sguia { get => sguia; set => sguia = value; }
        public string Cguia { get => cguia; set => cguia = value; }
        public string Dguia { get => dguia; set => dguia = value; }

        public async Task<List<Guias>> buscarguias( string idusuario)
        {

            List<Guias> listaguias = new List<Guias>();
            await Task.Run(() =>
            {
            try
            {
                string url = "https://prolipadigital.com.ec/software/PlataformaProlipa/public/api/guia?idusuario="+ idusuario;
                var json = new WebClient().DownloadString(url);
                dynamic datos = JsonConvert.DeserializeObject(json);
                foreach (var dato in datos)
                {
                    if(dato.zipguia != null){
                        Guias guia = new Guias();
                        guia.Zipguias = dato.zipguia.ToString();
                        guia.Sguia = dato.pdfsinguia.ToString();
                        guia.Cguia = dato.pdfconguia.ToString();
                        guia.Dguia = dato.guiadidactica.ToString();
                        listaguias.Add(guia);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex);

            }
            });
            return listaguias;
        }
    }
}
