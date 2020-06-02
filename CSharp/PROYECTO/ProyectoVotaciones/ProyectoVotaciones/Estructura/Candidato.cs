using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVotaciones
{

    public class Candidato
    {
        public string ID { set; get; }//Identificador del candidato
        public string Nombre { set; get; }//nombre del candidato
        public string Apellidos { set; get; }   //Apellidos del Candidato    
        public String PartidoPolitico { set; get; }//Partido politico del candidato
        public int Votos { set; get; }//Cantidad de votos del candidato
        public string IDPeriodo { set; get; }//Periodo en el que el candidato sera usado

    }

}
