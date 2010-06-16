using System;
using System.Web.Services;
using PSWinCom.Gateway.Client;

namespace RandomPasswordService
{
    [WebService(Namespace = "http://pswin.com/SOAP/Receive")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class Password : WebService, ISMSReceiveSoap
    {
        #region ISMSReceiveSoap Members

        public ReturnValue ReceiveSMSMessage(IncomingSMSMessage m)
        {
            try
            {
                Send(new Message
                {
                    ReceiverNumber = m.SenderNumber, // return to sender
                    SenderNumber = m.ReceiverNumber,
                    Text = RandomDotOrg.GetNewPassword(),
                });
            }
            catch { /* Log this !! */ }
            return new ReturnValue { Code = 200 };
        }

        public ReturnValue ReceiveDeliveryReport(DeliveryReport dr) {
            throw new NotImplementedException(); // not interested
        }

        public ReturnValue ReceiveMMSMessage(IncomingMMSMessage m) {
            throw new NotImplementedException(); // not interested
        }
        #endregion

        private void Send(Message message)
        {
            var smsClient = new SMSClient()
            {
                Username = "",          // your Gateway username
                Password = "",          // your Gateway passord
                PrimaryGateway = "",    // the Gateway URL
                SecondaryGateway = "",  // backup Gatetway URL
            };
            smsClient.Messages.Add(0, message);
            smsClient.SendMessages();
        }
    }
}
