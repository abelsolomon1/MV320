using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung_Auto
{
    internal class Motor 
    {
         Benzinpumpe benzinpumpe = new Benzinpumpe();

         Anlasser anlasser= new Anlasser();

        public void starten()
        {
            Console.WriteLine("Motor starten");

            benzinpumpe.pumpen();
            anlasser.starten();
            regeln();


            
        }
        private void regeln()
        {
            int i = 0;

            while (i <= 6)
            {
                i++;

                Console.WriteLine("Motor Regeln");

                
            }
            anlasser.stoppen();

            
        }
    }
}
