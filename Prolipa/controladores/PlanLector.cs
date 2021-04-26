using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AppProlipa.controladores
{
    class PlanLector
    {
        private string idplanlector = "";
        private string nombreplanlector = "";
        private string zipplanlector = "";
        private string descripcion = "";

        public PlanLector()
        {
        }

        public PlanLector(string idplanlector, string nombreplanlector, string zipplanlector, string descripcion)
        {
            this.idplanlector = idplanlector;
            this.nombreplanlector = nombreplanlector;
            this.zipplanlector = zipplanlector;
            this.descripcion = descripcion;
        }

        public string Idplanlector { get => idplanlector; set => idplanlector = value; }
        public string Nombreplanlector { get => nombreplanlector; set => nombreplanlector = value; }
        public string Zipplanlector { get => zipplanlector; set => zipplanlector = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        public async Task<List<PlanLector>> buscarplanlector(string idusuario)
        {

            List<PlanLector> listaplanlector = new List<PlanLector>();
            await Task.Run(() =>
            {
                try
                {
                    string url = "https://prolipadigital.com.ec/software/PlataformaProlipa/public/api/planlector?idusuario="+ idusuario;
                    var json = new WebClient().DownloadString(url);
                    dynamic datos = JsonConvert.DeserializeObject(json);
                    foreach (var dato in datos)
                    {
                        if(dato.zipplanlector != null){
                            PlanLector planLector = new PlanLector();
                            planLector.Zipplanlector = dato.zipplanlector.ToString();
                            listaplanlector.Add(planLector);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.Write(ex);

                }
            });
            return listaplanlector;
        }
    }
}
