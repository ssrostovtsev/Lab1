namespace MobilePhoneClassLib {
    public class SMSProvider {
        public delegate void SMSRecievedDelegate(string message);
        public event SMSRecievedDelegate SMSRecieved;
    }
}
