using ProyectoVotaciones.CapaLogica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ionic.Zip;

namespace ProyectoVotaciones.ManejoDeArchivos
{
    public class Directorios
    {

        String rutaAcopiar;//La ruta que se va a copiar que seria los datos donde se estan guardando los datos
        public Directorios()
        {

            rutaAcopiar = UrlArchivos.DatosProyecto;
        }
        //Metodo que hace un Backup de los archivos en un rar
        #region Hacer Backup
        public void HacerBackup()
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Winrar|.rar";
            save.ShowDialog();
            ZipFile zipFile = new ZipFile();
            zipFile.CompressionLevel = Ionic.Zlib.CompressionLevel.BestCompression;
            zipFile.AddDirectory(rutaAcopiar);
            if (save.FileName == "")
            {
            }
            else
            {
                zipFile.Save(save.FileName);
                zipFile.Dispose();
            }
        }
        #endregion

        //Se extraen los datos del archivo rar seleccionado y se abre un opend dialog
        #region Extraer
        public void Extraer()
        {
            OpenFileDialog openrar = new OpenFileDialog();
            openrar.Filter = "|.rar";
            openrar.ShowDialog();
            ZipFile zipFile = new ZipFile();
            if (openrar.FileName == "")
            {
            }
            else
            {
                if (openrar.FileName == "")
                {
                }
                else
                {
                    if (System.IO.Directory.Exists(rutaAcopiar))
                    {
                        System.IO.Directory.Delete(rutaAcopiar, true);//Se elimina todo el directio 
                    }

                    if (!System.IO.Directory.Exists(rutaAcopiar))
                    {
                        System.IO.Directory.CreateDirectory(rutaAcopiar);//Se crea de nuevo el directorio
                    }
                    zipFile = ZipFile.Read(openrar.FileName);
                    zipFile.ExtractAll(rutaAcopiar);//Se extrae el rar en el directorio creado donde manemos los archivos
                    zipFile.Dispose();
                }
            }
        }
        #endregion
    }
}