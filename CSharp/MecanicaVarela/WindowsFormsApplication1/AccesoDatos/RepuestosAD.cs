using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MecanicaVarela.AccesoDatos
{
    public class RepuestosAD : IAccesoDatos1
    {
        static string carpeta = "/Usarios";
        static string nombre = Guid.NewGuid().ToString().Substring(0, 10);
        string ruta = Application.StartupPath +carpeta+"/"+nombre+".txt";
        public void Conectar()
        {
            try
            {
                if (!File.Exists(ruta))
                {
                    File.Create(ruta).Close();
                }
            }
            catch (Exception e)
            {
                Is_Error = true;
                ErrorDescripcion = e.Message;
            }
        }

        public void Escribir(string hilera)
        {
            try
            {
                this.Conectar();
                using (StreamWriter sw = new StreamWriter(ruta, true))
                {
                    sw.WriteLine(hilera);
                }
            }
            catch (Exception e)
            {
                Is_Error = true;
                ErrorDescripcion = e.Message;
            }
        }

        public string leer()
        {
            StringBuilder resultado = new StringBuilder();
            try
            {
                this.Conectar();
                using (StreamReader sr=new StreamReader(ruta))
                {
                    while (sr.Peek() >= 0)
                    {
                        resultado.AppendLine(sr.ReadLine());
                    }
                }
            }
            catch (Exception e)
            {
                Is_Error = true;
                ErrorDescripcion = e.Message;
            }
            return resultado.ToString();
        }

        public void Editar(string id, string modificar)
        {

            try
            {
                this.Conectar();
                StringBuilder agregarLinea = new StringBuilder();
                StreamReader sr = new StreamReader(ruta);
                
                string linea;
                while ((linea = sr.ReadLine()) !=null)
                {
                    if (linea.Contains(id))
                    {
                        agregarLinea.AppendLine(modificar);
                    }
                    else
                    {
                        agregarLinea.AppendLine(linea);
                    }
                }
                sr.Close();
                StreamWriter sw = new StreamWriter(ruta);
                sw.WriteLine(agregarLinea);
                sw.Close();
            }
            catch (Exception e)
            {
                Is_Error = true;
                ErrorDescripcion = e.Message;
            }
        }

        public void Eliminar(string id)
        {
            try
            {
                this.Conectar();
                StringBuilder agregarLinea = new StringBuilder();
                StreamReader sr = new StreamReader(ruta);
                StreamWriter sw;
                string linea;
                while ((linea = sr.ReadLine()) != null)
                {
                    if (!linea.Contains(id))
                    {
                        agregarLinea.AppendLine(linea);
                    }
                    
                }
                sr.Close();
                sw = new StreamWriter(ruta);
                sw.WriteLine(agregarLinea);
                sw.Close();
            }
            catch (Exception e)
            {
                Is_Error = true;
                ErrorDescripcion = e.Message;
            }
        }

        public bool Is_Error
        {
            set;
            get;
        }

        public string ErrorDescripcion
        {
            set;
            get;
        }
    }
}
