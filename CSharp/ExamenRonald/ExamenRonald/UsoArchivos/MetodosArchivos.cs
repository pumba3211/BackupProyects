using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenRonald.UsoArchivos
{
    public class MetodosArchivos : IMetodosArchivos
    {
        public string Ruta { set; get; }

        public void Conectar()
        {
            try
            {
                if (!System.IO.File.Exists(Ruta))
                {
                    System.IO.File.Create(Ruta);
                }
            }
            catch (Exception Error)
            {
                Is_Error = true;
                ErrorDescripcion = Error.Message;
            }
        }

        public string leer()
        {
            StringBuilder resultado = new StringBuilder();
            try
            {
                this.Conectar();
                using (StreamReader sr = new StreamReader(Ruta))
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



        public bool Is_Error { set; get; }

        public string ErrorDescripcion { set; get; }
    }
}
