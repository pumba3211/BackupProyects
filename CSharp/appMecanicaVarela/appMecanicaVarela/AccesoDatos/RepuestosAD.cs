using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace appMecanicaVarela
{
    public class RepuestosAD:lAccesoDatos
    {
        string ruta = @Application.StartupPath + "/repuestos.txt";

        public void Conectar()
        {
            try
            {
                if (!File.Exists(ruta))
                {
                    File.Create(ruta).Close();
                }
            }
            catch (Exception exception)
            {

                IsError = true;
                ErrorDescripcion = exception.Message;
            }
        }

        public void Escribir(string hilera)
        {
            try
            {
                this.Conectar();
                using (StreamWriter sw = new StreamWriter(ruta,true))
                {
                    sw.WriteLine(hilera);
                }
            }
            catch (Exception exception)
            {
                IsError = true;
                ErrorDescripcion = exception.Message;
            }
        }

        public string leer()
        {
            StringBuilder resultado = new StringBuilder();

            try
            {
                this.Conectar();

                using (StreamReader sr = new StreamReader(ruta))
                {
                    while (sr.Peek() >=0)
                    {
                        resultado.AppendLine(sr.ReadLine());
                    }
                }
            }
            catch (Exception exception)
            {
                IsError = true;
                ErrorDescripcion = exception.Message;
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
                StreamWriter sw;
                string linea;
                while ((linea = sr.ReadLine())!= null)
                {
                    if (linea.Contains(id))
                        agregarLinea.AppendLine(modificar);
                    else
                        agregarLinea.AppendLine(linea);
                }
                sr.Close();
                sw = new StreamWriter(ruta);
                sw.Write(agregarLinea);
                sw.Close();
            }
            catch (Exception exception)
            {
                IsError = true;
                ErrorDescripcion = exception.Message;
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
                while ((linea = sr.ReadLine())!= null)
                {
                    if (!linea.Contains(id))
                        agregarLinea.AppendLine(linea);
                    
                }
                sr.Close();
                sw = new StreamWriter(ruta);
                sw.Write(agregarLinea);
                sw.Close();
            }
            catch (Exception exception)
            {
                IsError = true;
                ErrorDescripcion = exception.Message;
            }
        }

        public bool IsError
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
