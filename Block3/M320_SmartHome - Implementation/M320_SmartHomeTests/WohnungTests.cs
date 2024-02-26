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
        [TestMethod]
        public void HeizungOffenNormalesWetter()
        {
            // Arrange
            var wettersensor = new WettersensorDummy(false);
            Wohnung wohnung = new Wohnung(wettersensor);
            var wohnzimmer = new WohnzimmerMock();
            wohnung.AddZimmer(wohnzimmer);
            wohnzimmer.TemperaturVorgabe = 20;

            // Act
            wohnung.GenerateWetterdaten();

            // Assert
            Assert.IsTrue(wohnzimmer.HeizungsventilOffen);
        }

        [TestMethod]
        public void HeizungGeschlossenKälte()
        {
            // Arrange
            var wettersensor = new WettersensorDummy(false, 10);
            Wohnung wohnung = new Wohnung(wettersensor);
            var wohnzimmer = new WohnzimmerMock();
            wohnung.AddZimmer(wohnzimmer);
            wohnzimmer.TemperaturVorgabe = 20;

            // Act
            wohnung.GenerateWetterdaten();

            // Assert
            Assert.IsFalse(wohnzimmer.HeizungsventilOffen);
        }
        [TestMethod]
        public void HeizungGeschlossenHitze()
        {
            // Arrange
            var wettersensor = new WettersensorDummy(false, 30);
            Wohnung wohnung = new Wohnung(wettersensor);
            var wohnzimmer = new WohnzimmerMock();
            wohnung.AddZimmer(wohnzimmer);
            wohnzimmer.TemperaturVorgabe = 20;

            // Act
            wohnung.GenerateWetterdaten();

            // Assert
            Assert.IsFalse(wohnzimmer.HeizungsventilOffen);
        }
        [TestMethod]
        public void MarkiseNichtAusfahrenKälte()
        {
            // Arrange
            var wettersensor = new WettersensorDummy(false, 15);
            Wohnung wohnung = new Wohnung(wettersensor);
            var wintergarten = new WintergartenMock();
            wohnung.AddZimmer(wintergarten);
            wintergarten.TemperaturVorgabe = 30;

            // Act
            wohnung.GenerateWetterdaten();

            // Assert
            Assert.IsFalse(wintergarten.MarkiseEingefahren);
        }
        [TestMethod]
        public void MarkiseAusfahrenHitze()
        {
            // Arrange
            var wettersensor = new WettersensorDummy(false, 35);
            Wohnung wohnung = new Wohnung(wettersensor);
            var wintergarten = new WintergartenMock();
            wohnung.AddZimmer(wintergarten);
            wintergarten.TemperaturVorgabe = 30;

            // Act
            wohnung.GenerateWetterdaten();

            // Assert
            Assert.IsTrue(wintergarten.MarkiseEingefahren);
        }
        [TestMethod]
        public void MarkiseNichtAusfahrenStarkerWind()
        {
            // Arrange
            var wettersensor = new WettersensorDummy(false, 25, 35);
            Wohnung wohnung = new Wohnung(wettersensor);
            var wintergarten = new WintergartenMock();
            wohnung.AddZimmer(wintergarten);
            wintergarten.TemperaturVorgabe = 30;

            // Act
            wohnung.GenerateWetterdaten();

            // Assert
            Assert.IsFalse(wintergarten.MarkiseEingefahren);
        }
        [TestMethod]
        public void JalousieRunterfahrenKeinePersonen()
        {
            // Arrange
            var wettersensor = new WettersensorDummy(false, 25);
            Wohnung wohnung = new Wohnung(wettersensor);
            var schlafzimmer = new SchlafzimmerMock();
            wohnung.AddZimmer(schlafzimmer);
            schlafzimmer.TemperaturVorgabe = 20;
            schlafzimmer.PersonenImZimmer = false;

            // Act
            wohnung.GenerateWetterdaten();

            // Assert
            Assert.IsTrue(schlafzimmer.JalousieRuntergefahren);
        }
        [TestMethod]
        public void JalousieNichtRunterfahrenPersonenImZimmer()
        {
            // Arrange
            var wettersensor = new WettersensorDummy(false, 25);
            Wohnung wohnung = new Wohnung(wettersensor);
            var schlafzimmer = new SchlafzimmerMock();
            wohnung.AddZimmer(schlafzimmer);
            schlafzimmer.TemperaturVorgabe = 20;
            schlafzimmer.PersonenImZimmer = true;

            // Act
            wohnung.GenerateWetterdaten();

            // Assert
            Assert.IsFalse(schlafzimmer.JalousieRuntergefahren);
        }
        [TestMethod]
        public void HeizungGeschlossenNormalesWetter()
        {
            // Arrange
            var wettersensor = new WettersensorDummy(false);
            Wohnung wohnung = new Wohnung(wettersensor);
            var wohnzimmer = new WohnzimmerMock();
            wohnung.AddZimmer(wohnzimmer);
            wohnzimmer.TemperaturVorgabe = 20;

            // Act
            wohnung.GenerateWetterdaten();

            // Assert
            Assert.IsFalse(wohnzimmer.HeizungsventilOffen);
        }
        [TestMethod]
        public void MarkiseNichtAusfahrenNormalesWetter()
        {
            // Arrange
            var wettersensor = new WettersensorDummy(false);
            Wohnung wohnung = new Wohnung(wettersensor);
            var wintergarten = new WintergartenMock();
            wohnung.AddZimmer(wintergarten);
            wintergarten.TemperaturVorgabe = 30;

            // Act
            wohnung.GenerateWetterdaten();

            // Assert
            Assert.IsFalse(wintergarten.MarkiseEingefahren);
        }
        [TestMethod]
        public void HeizungGeschlossenGemäßigteTemperatur()
        {
            // Arrange
            var wettersensor = new WettersensorDummy(false);
            Wohnung wohnung = new Wohnung(wettersensor);
            var wohnzimmer = new WohnzimmerMock();
            wohnung.AddZimmer(wohnzimmer);
            wohnzimmer.TemperaturVorgabe = 25;

            // Act
            wohnung.GenerateWetterdaten();

            // Assert
            Assert.IsFalse(wohnzimmer.HeizungsventilOffen);
        }
        [TestMethod]
        public void JalousieRunterfahrenNormalesWetter()
        {
            // Arrange
            var wettersensor = new WettersensorDummy(false, 25);
            Wohnung wohnung = new Wohnung(wettersensor);
            var schlafzimmer = new SchlafzimmerMock();
            wohnung.AddZimmer(schlafzimmer);
            schlafzimmer.TemperaturVorgabe = 20;
            schlafzimmer.PersonenImZimmer = true;

            // Act
            wohnung.GenerateWetterdaten();

            // Assert
            Assert.IsFalse(schlafzimmer.JalousieRuntergefahren);
        }
        [TestMethod]
        public void MarkiseAusfahrenStarkerWind()
        {
            // Arrange
            var wettersensor = new WettersensorDummy(false, 25, 40);
            Wohnung wohnung = new Wohnung(wettersensor);
            var wintergarten = new WintergartenMock();
            wohnung.AddZimmer(wintergarten);
            wintergarten.TemperaturVorgabe = 30;

            // Act
            wohnung.GenerateWetterdaten();

            // Assert
            Assert.IsFalse(wintergarten.MarkiseEingefahren);
        }
        [TestMethod]
        public void MarkiseNichtAusfahrenLeichterRegen()
        {
            // Arrange
            var wettersensor = new WettersensorDummy(true, 25);
            Wohnung wohnung = new Wohnung(wettersensor);
            var wintergarten = new WintergartenMock();
            wohnung.AddZimmer(wintergarten);
            wintergarten.TemperaturVorgabe = 30;

            // Act
            wohnung.GenerateWetterdaten();

            // Assert
            Assert.IsFalse(wintergarten.MarkiseEingefahren);
        }
        [TestMethod]
        public void HeizungOffenHitze()
        {
            // Arrange
            var wettersensor = new WettersensorDummy(false, 35);
            Wohnung wohnung = new Wohnung(wettersensor);
            var wohnzimmer = new WohnzimmerMock();
            wohnung.AddZimmer(wohnzimmer);
            wohnzimmer.TemperaturVorgabe = 20;

            // Act
            wohnung.GenerateWetterdaten();

            // Assert
            Assert.IsFalse(wohnzimmer.HeizungsventilOffen);
        }
        [TestMethod]
        public void HeizungOffenStarkerRegen()
        {
            // Arrange
            var wettersensor = new WettersensorDummy(true);
            Wohnung wohnung = new Wohnung(wettersensor);
            var wohnzimmer = new WohnzimmerMock();
            wohnung.AddZimmer(wohnzimmer);
            wohnzimmer.TemperaturVorgabe = 20;

            // Act
            wohnung.GenerateWetterdaten();

            // Assert
            Assert.IsFalse(wohnzimmer.HeizungsventilOffen);
        }

    }
}






