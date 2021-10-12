using System;
using System.IO;
using System.Net;
using System.Xml;
using System.Text;
using System.Linq;
using System.Diagnostics;
using System.Threading.Tasks;

namespace SgiOnvifRestApiGW
{
    public static class AppLogger
    {
        public static void LogInformation(string logtext)
        {
        }
        public static void LogDebug(string logtext)
        {
        }
        public static void LogException(string Handler, string logtext)
        {
        }
    }

    public static class NetFuncs
    {
        private static string GetEnvelop(string EnvelopContent)
        {
            return "<s:Envelope xmlns:s=\"http://www.w3.org/2003/05/soap-envelope\">" + EnvelopContent + "</s:Envelope>";
        }
        private static string getServiceUri(string DeviceIp,OnvifAddressing EndpointPath=OnvifAddressing.device_service)
        {
            return "http://" + DeviceIp + "/onvif/" + EndpointPath.ToString();
        }
        public static string PostXmlRequest(string CameraIp, string requestXml, string Username, string Password, string ActionName,OnvifAddressing EndpointPath = OnvifAddressing.device_service)
        {
            string responseStr = "";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(getServiceUri(CameraIp, EndpointPath));
            byte[] bytes;
            bytes = System.Text.Encoding.ASCII.GetBytes(GetEnvelop(SecurityFuncs.getSecurityHeaderXml(Username, Password) + requestXml));
            request.ContentType = "application/soap+xml; charset=utf-8; action=\"http://www.onvif.org/ver10/device/wsdl/" + ActionName + "\"";
            request.ContentLength = bytes.Length;
            request.Method = "POST";
            Stream requestStream = request.GetRequestStream();
            requestStream.Write(bytes, 0, bytes.Length);
            requestStream.Close();
            HttpWebResponse response;
            response = (HttpWebResponse)request.GetResponse();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                Stream responseStream = response.GetResponseStream();
                responseStr = new StreamReader(responseStream).ReadToEnd();
            }
            return responseStr;
        }
    }

    public static class SecurityFuncs
    {
        public static string ComputePasswordDigest(string password, string createdTime, byte[] nonceBytes)
        {
            byte[] createdTimeBytes = Encoding.UTF8.GetBytes(createdTime);
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            byte[] aggregationBytes = nonceBytes.Concat(createdTimeBytes).Concat(passwordBytes).ToArray();
            byte[] hashBytes = System.Security.Cryptography.SHA1.Create().ComputeHash(aggregationBytes);
            return Convert.ToBase64String(hashBytes);
        }
        public static string getSecurityHeaderXml(string Username, string Password)
        {
            DateTime created = DateTime.UtcNow;
            string createdStr = created.ToString("yyyy-MM-ddTHH:mm:ss.fffZ");
            byte[] nonceByte = new byte[20];
            var random = new Random();
            random.NextBytes(nonceByte);
            string nonce = Convert.ToBase64String(nonceByte);
            string dpass = SecurityFuncs.ComputePasswordDigest(Password, createdStr, nonceByte);
            return " <s:Header> " +
                       "<Security s:mustUnderstand=\"1\" xmlns=\"http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd\">" +
                           "<UsernameToken>" +
                              "<Username>" +
                                 Username +
                              "</Username>" +
                              "<Password Type=\"http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-username-token-profile-1.0#PasswordDigest\">" +
                                 dpass +
                              "</Password>" +
                              "<Nonce EncodingType=\"http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-soap-message-security-1.0#Base64Binary\">" +
                                  nonce +
                              "</Nonce>" +
                              "<Created xmlns=\"http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd\">" +
                                   createdStr +
                              "</Created>" +
                            "</UsernameToken>" +
                         "</Security>" +
                      "</s:Header>";

        }

    }

    public enum OnvifAddressing 
    {
        event_service,
        media_service,
        device_service,
        ptz_service
    }

}
