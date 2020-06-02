using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoVotaciones.ManejoDeArchivos
{
    public class UsoArchivos : IintefazDeArchivos
    {
        public int VotanteOCandidato
        { //La variable se utiliza para saber cual ruta utilizaremos para manejar cada archivo de texto
            set;
            get;
        }
        public string IDPeriodo { set; get; }//Se utliza solo para crear un archivo de nulos y blancos para cada periodo
        string ruta = "";//Se utiliza para asignar la ruta
        public void SetRutaAUsar()
        {
            if (VotanteOCandidato == 1)
            {
                ruta = UrlArchivos.Votantes;//Se utiliza para manejar al archivo votantes.txt
            }
            else if (VotanteOCandidato == 2)
            {
                ruta = UrlArchivos.Candidatos;//Se utiliza para manejar al archivo Candidatos.txt
            }
            else if (VotanteOCandidato == 3)
            {
                ruta = UrlArchivos.Periodo;//Se utiliza para manejar al archivo Periodo.txt
            }
            else if (VotanteOCandidato == 4)
            {
                ruta = UrlArchivos.NulosOBlancos + IDPeriodo + ".txt";//Se utiliza para manejar al archivo Nulos y blancos del periodo usado.txt
            }
            else
            {
            }
        }


        #region Conectarse_al_archivo
        public void Conectar()
        {
            try
            {
                if (!File.Exists(ruta))
                {
                    if (!Directory.Exists(UrlArchivos.DatosProyecto)) { Directory.CreateDirectory(UrlArchivos.DatosProyecto); }
                    File.Create(ruta).Close();
                }
            }
            catch (Exception e)
            {
                Is_Error = true;
                ErrorDescripcion = e.Message;
            }
        }
        #endregion

        #region Metodos del uso del archivo
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
                using (StreamReader sr = new StreamReader(ruta))
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
                while ((linea = sr.ReadLine()) != null)
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
        #endregion
    }
}
