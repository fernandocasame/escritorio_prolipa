using AppProlipa.controladores;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Prolipa.controladores
{
    class Planificaciones
    {
        private string idplanificacion = "";
        private string nombreplanificacion = "";
        private string webplanificacion = "";
        private string descripcionplanificacion = "";
        public Planificaciones()
        {
        }
        public string Idplanificacion { get => idplanificacion; set => idplanificacion = value; }
        public string Nombreplanificacion { get => nombreplanificacion; set => nombreplanificacion = value; }
        public string Webplanificacion { get => webplanificacion; set => webplanificacion = value; }
        public string Descripcionplanificacion { get => descripcionplanificacion; set => descripcionplanificacion = value; }

        public async Task<List<Planificaciones>> buscarplanificaciones(string idusuario)
        {
            List<Planificaciones> listaplanificaciones = new List<Planificaciones>();

            await Task.Run(() =>
            {
                try
                {
                    string url = "https://prolipadigital.com.ec/software/PlataformaProlipa/public/api/planificacion?idusuario="+ idusuario;
                    var json = new WebClient().DownloadString(url);
                    dynamic datos = JsonConvert.DeserializeObject(json);
                    foreach (var dato in datos)
                    {
                        if(dato.webplanificacion != null){
                            Planificaciones planificacion = new Planificaciones();
                            planificacion.Webplanificacion = dato.webplanificacion.ToString();
                            listaplanificaciones.Add(planificacion);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.Write(ex);

                }
            });
            Console.WriteLine(listaplanificaciones);
            return listaplanificaciones;
        }
    }
}
