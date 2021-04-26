using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;
using System.Windows.Forms;

namespace AppProlipa.controladores
{
    class Usuario
    {
        private string usr;
        private string password;
        public Usuario(string usr, string password)
        {
            this.usr = usr;
            this.password = password;
        }

        public Usuario()
        {

        }
        public string Usr { get => usr; set => usr = value; }
        public string Password { get => password; set => password = value; }

        public async Task<string> login(String usr, String pass)
        {
            string idusuario="";

            try{
                await Task.Run(() =>
                {
                    string usuario = usr;
                    string password = SHA1(MD5(pass));

                    string url = "https://prolipadigital.com.ec/software/PlataformaProlipa/public/api/usuario?username="+ usuario +"&password="+ password;
                    var json = new WebClient().DownloadString(url);
                    dynamic datos = JsonConvert.DeserializeObject(json);
                    Console.WriteLine(datos);
                    foreach(var dato in datos){
                        idusuario = dato.idusuario.ToString();
                    }
                });
            }catch(Exception e){
                MessageBox.Show("Error prolipadigital.com.ec no encontrado", "Mensaje informativo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return idusuario; 
        }

        public string MD5(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));
            byte[] result = md5.Hash;
            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                strBuilder.Append(result[i].ToString("x2"));
            }
            return strBuilder.ToString();
        }

        private string SHA1(string cadena)
        {
            UTF8Encoding enc = new UTF8Encoding();
            byte[] data = enc.GetBytes(cadena);
            byte[] result;
            SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider();
            result = sha.ComputeHash(data);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] < 16)
                {
                    sb.Append("0");
                }
                sb.Append(result[i].ToString("x"));
            }
            return sb.ToString().ToUpper();
        }
    }
}
