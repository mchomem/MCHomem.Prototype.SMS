using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace MCHomem.Prototype.SMS.Services
{
    public class TwilioServices
    {
        public TwilioServices() { }

        public String SendSMS(String phoneNumberTo, String message)
        {
            String twilioPublicNumber = TwilioKey.Read("A");
            String userName = TwilioKey.Read("B");
            String password = TwilioKey.Read("C");

            TwilioClient.Init(userName, password);

            MessageResource mr = MessageResource.Create
                (
                    body: message
                    , from: new Twilio.Types.PhoneNumber(twilioPublicNumber)
                    , to: new Twilio.Types.PhoneNumber(phoneNumberTo)
                );

            return mr.Sid;
        }
    }
}
