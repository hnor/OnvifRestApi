using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Text;
using System.Diagnostics;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace SgiOnvifRestApiGW.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SgiOnvifEventPortTypeController : ControllerBase
    {
        public SgiOnvifEventPortTypeController()
        {

        }

        [SwaggerOperation(Summary = "دریافت مشخصات رویدادهای دستگاه")]
        [HttpGet("GetEventProperties")]
        public OnvifObjects.GetEventPropertiesResponse.GetEventPropertiesResponse GetEventProperties(string CameraIP, string Username, string Password)
        {
            SgiOnvif.SgiOnvifEventPortType soept = new SgiOnvif.SgiOnvifEventPortType();
            return soept.GetEventProperties(CameraIP, Username, Password);
        }


        public void testSub()
        {
            string xm = "<s:Envelope xmlns:s=\"http://www.w3.org/2003/05/soap-envelope\" xmlns:a=\"http://www.w3.org/2005/08/addressing\">" +
                "           <s:Header>" +
                "               <a:Action s:mustUnderstand=\"1\">http://docs.oasis-open.org/wsn/bw-2/NotificationProducer/SubscribeRequest</a:Action><a:MessageID>urn:uuid:a551b100-c4b6-44ba-af84-c38208fa2bd7</a:MessageID><a:ReplyTo><a:Address>http://www.w3.org/2005/08/addressing/anonymous</a:Address></a:ReplyTo><Security s:mustUnderstand=\"1\" xmlns=\"http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd\"><UsernameToken><Username>admin</Username><Password Type=\"http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-username-token-profile-1.0#PasswordDigest\">5THMqzD9lC3ZvzsiKEGRg7MP5Xo=</Password><Nonce EncodingType=\"http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-soap-message-security-1.0#Base64Binary\">XOln1lCPw0eCPkOU4sNTwjg4AAAAAA==</Nonce><Created xmlns=\"http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd\">2021-10-08T10:01:09.127Z</Created></UsernameToken></Security><a:To s:mustUnderstand=\"1\">http://172.16.11.217/onvif/event_service</a:To></s:Header><s:Body xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"><Subscribe xmlns=\"http://docs.oasis-open.org/wsn/b-2\"><ConsumerReference><a:Address>http://172.16.11.252:8085/subscription-22</a:Address></ConsumerReference><InitialTerminationTime>PT60S</InitialTerminationTime></Subscribe></s:Body></s:Envelope>";
            
        }

        public void StartServer()
        {
            IPHostEntry host = Dns.GetHostEntry("localhost");
            IPAddress ipAddress = host.AddressList[0];
            IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 11000);
            try
            {
                Socket listener = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                listener.Bind(localEndPoint);
                listener.Listen(10);
                Console.WriteLine("Waiting for a connection...");
                Socket handler = listener.Accept();

                // Incoming data from the client.    
                string data = null;
                byte[] bytes = null;

                while (true)
                {
                    bytes = new byte[1024];
                    int bytesRec = handler.Receive(bytes);
                    data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                    if (data.IndexOf("<EOF>") > -1)
                    {
                        break;
                    }
                }

                Console.WriteLine("Text received : {0}", data);

                byte[] msg = Encoding.ASCII.GetBytes(data);
                handler.Send(msg);
                handler.Shutdown(SocketShutdown.Both);
                handler.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine("\n Press any key to continue...");
            Console.ReadKey();
        }
    }

}
