using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Structures
{
    public class Juego
    {
        [DataMember(Name = "shuffled")]
        public Boolean shuffled { set; get; }
        [DataMember(Name = "remaining")]
        public int remaining { set; get; }
        [DataMember(Name = "deck_id")]
        public string deck_id { set; get; }
        [DataMember(Name = "success")]
        public Boolean success { set; get; }
    }
}
