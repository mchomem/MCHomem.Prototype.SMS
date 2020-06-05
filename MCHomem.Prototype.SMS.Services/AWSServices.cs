using Amazon.SimpleNotificationService;
using Amazon.SimpleNotificationService.Model;
using System;

namespace MCHomem.Prototype.SMS.Services
{
    public class AWSServices
    {
        public String SendSMS(String recipientPhoneNumber, String message)
        {
            String accessKey = "";
            String secretKey = "";

            var awsCredentials = new Amazon.Runtime.BasicAWSCredentials(accessKey, secretKey);

            AmazonSimpleNotificationServiceClient snsClient = new AmazonSimpleNotificationServiceClient(awsCredentials, Amazon.RegionEndpoint.USEast1);
            PublishRequest pubRequest = new PublishRequest();
            pubRequest.PhoneNumber = recipientPhoneNumber;
            pubRequest.Message = message;

            PublishResponse pubResponse = snsClient.Publish(pubRequest);
            return pubResponse.MessageId;
        }
    }
}
