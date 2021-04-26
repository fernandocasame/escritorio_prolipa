using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


namespace AppProlipa.controladores
{
    class Cuadernos
    {
        private string idcuadernos = "";
        private string nombrecuadernos = "";
        private string zipcuadernos = "";
        private string descripcion = "";
        private string sguia = "";
        private string cguia = "";
        private string dguia = "";

        public Cuadernos()
        {
        }

        public Cuadernos(string idcuadernos, string nombrecuadernos, string zipcuadernos, string descripcion)
        {
            this.idcuadernos = idcuadernos;
            this.nombrecuadernos = nombrecuadernos;
            this.zipcuadernos = zipcuadernos;
            this.descripcion = descripcion;
        }

        public string Idcuadernos { get => idcuadernos; set => idcuadernos = value; }
        public string Nombrecuadernos { get => nombrecuadernos; set => nombrecuadernos = value; }
        public string Zipcuadernos { get => zipcuadernos; set => zipcuadernos = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Sguia { get => sguia; set => sguia = value; }
        public string Cguia { get => cguia; set => cguia = value; }
        public string Dguia { get => dguia; set => dguia = value; }

        public async Task<List<Cuadernos>> buscarcuadernos( string idusuario)
        {
            List<Cuadernos> listacuadernos = new List<Cuadernos>();
            await Task.Run(() =>
            {
            try
            {
                string url = "https://prolipadigital.com.ec/software/PlataformaProlipa/public/api/cuaderno?idusuario="+ idusuario;
                var json = new WebClient().DownloadString(url);
                dynamic datos = JsonConvert.DeserializeObject(json);
                foreach (var dato in datos)
                {
                    if(dato.zipcuaderno != null){
                        Cuadernos cuaderno = new Cuadernos();
                        cuaderno.Zipcuadernos = dato.zipcuaderno.ToString();
                        cuaderno.Sguia = dato.pdfsinguia.ToString();
                        cuaderno.Cguia = dato.pdfconguia.ToString();
                        cuaderno.Dguia = dato.guiadidactica.ToString();
                        listacuadernos.Add(cuaderno);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex);

            }
            });
            return listacuadernos;
        }
    }
}
