using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_4
{
    class Notities
    {
        //public string Name { get; set; }
        public string Notitie { get; set; }
        //public int Value { get; set; }

        public Notities(/*string name,*/ string notitie/*, int value*/)
        {
            //Name = name;
            Notitie = notitie;
            //Value = value;
        }
        public string Bijschrijven(string bijschrift)
        {
            return Notitie += " " + bijschrift ;
        }
     
        public string Bekijknotitie()
        {
            return Notitie;
        }
        
    }
}
