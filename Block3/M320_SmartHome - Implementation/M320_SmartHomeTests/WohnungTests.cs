using Microsoft.VisualStudio.TestTools.UnitTesting;
using M320_SmartHome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M320_SmartHomeTests;

namespace M320_SmartHome.Tests
{
    [TestClass()]
    public class WohnungTests
    {
        

        [TestMethod()]
        public void WohnungTest()
        {
            
            IWettersensor wettersensor = new WettersensorDummy(true);
            Wohnung wohnung = new Wohnung(wettersensor);

            Assert.IsTrue(heizungseventilOffen);
        }


        

       

     
    }
}