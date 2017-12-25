using Microsoft.VisualStudio.TestTools.UnitTesting;
using MobilePhoneClassLib;
using static MobilePhoneClassLib.SMSProvider;

namespace MobilePhoneTests {
    [TestClass]
    public class SMSFormatTest {
        private string Result;
        [TestMethod]
        public void SMSFormatterTest() {
            SMSProvider sMSProv = new SMSProvider();
            sMSProv.SMSRecieved += new SMSRecievedHandler(FakeShowSMS);
            string msg = "Test message";

            string format = "Uppercase";
            string expectedUppercaseResult = "TEST MESSAGE";
            sMSProv.SendSMS(msg, format);
            Assert.AreEqual(Result, expectedUppercaseResult);

            format = "Lowercase";
            string expectedLowercaseResult = "test message";
            sMSProv.SendSMS(msg, format);
            Assert.AreEqual(Result, expectedLowercaseResult);

            format = "None";
            string expectedNoneResult = "Test message";
            sMSProv.SendSMS(msg, format);
            Assert.AreEqual(Result, expectedNoneResult);
        }
        private void FakeShowSMS(string msg) {
            Result = msg;
        }
    }
}
