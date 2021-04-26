using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AppProlipa.controladores
{
    class MaterialApoyo
    {
        private string idmaterial = "";
        private string nombrematerial = "";
        private string zipmaterial = "";
        private string descripcion = "";

        public MaterialApoyo()
        {
        }

        public MaterialApoyo(string idmaterial, string nombrematerial, string zipmaterial, string descripcion)
        {
            this.idmaterial = idmaterial;
            this.nombrematerial = nombrematerial;
            this.zipmaterial = zipmaterial;
            this.descripcion = descripcion;
        }

        public string Idmaterial { get => idmaterial; set => idmaterial = value; }
        public string Nombrematerial { get => nombrematerial; set => nombrematerial = value; }
        public string Zipmaterial { get => zipmaterial; set => zipmaterial = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        public async Task<List<MaterialApoyo>> buscarmaterial(string idusuario)
        {

            List<MaterialApoyo> listamaterial = new List<MaterialApoyo>();
            await Task.Run(() =>
            {
                try
                {
                    string url = "https://prolipadigital.com.ec/software/PlataformaProlipa/public/api/material?idusuario="+ idusuario;
                    var json = new WebClient().DownloadString(url);
                    dynamic datos = JsonConvert.DeserializeObject(json);
                    foreach (var dato in datos)
                    {
                        if(dato.zipmaterial != null){
                            MaterialApoyo material = new MaterialApoyo();
                            material.Zipmaterial = dato.zipmaterial.ToString();
                            listamaterial.Add(material);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.Write(ex);

                }
            });
            return listamaterial;
        }
    }
}
