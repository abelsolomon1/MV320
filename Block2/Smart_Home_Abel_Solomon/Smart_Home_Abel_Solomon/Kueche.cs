using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Home_Abel_Solomon
{
    internal class Kueche : Zimmer
    {
        public KochherdStatus KochherdStatus { get; set; }

        public override void VerarbeiteWetterdaten(Wetterdaten wetterdaten)
        {

            KochherdStatus = KochherdStatus.Ein;
            
            Console.WriteLine("Der Kochherd ist" + KochherdStatus);
            
            
        }


    }
}
