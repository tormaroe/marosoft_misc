using System;

namespace send_incoming_sms
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var sender = new SMSReceive { Url = args[0] })
            {
                var result = sender.ReceiveSMSMessage(new IncomingSMSMessage
                {
                    SenderNumber = Prompt("Sender number"),
                    ReceiverNumber = Prompt("Receiver number"),
                    Text = Prompt("Message text"),
                });

                Console.WriteLine("Message sent!");
                Console.WriteLine("Return code {0}. Description: {1}. Reference: {2}",
                    result.Code, result.Description, result.Reference);
            }
        }

        private static string Prompt(string label)
        {
            Console.Write(label + ": ");
            return Console.ReadLine();
        }
    }
}
