using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MobilePhone;

namespace MobilePhoneTests {
    [TestClass]
    public class ChargerTest {
        [TestMethod]
        public void WirelessChargerTest() {
            ///Arrange
            double voltage = 5;
            double amperage = 1;
            FakeOutput fakeOutput = new FakeOutput();
            WirelessCharger wirelessCharger = new WirelessCharger(fakeOutput);
            string expectedWriteLineResult = "WirelessCharger wireless charge ("+voltage+" V, "+amperage+" A)";
            //Act
            wirelessCharger.Charge(voltage, amperage);
            string writeLinedResult = fakeOutput.WriteLineResult;
            //Assert
            Assert.AreEqual(writeLinedResult, expectedWriteLineResult);
        }
    }
}
