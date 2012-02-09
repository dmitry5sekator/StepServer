using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StepServer.our
{
    class Response
    {
        private string responseCode;
        private string body;
        string str = "HTTP/1.1 200 OK ";
        public Response(string Code, String body)
        {
            setResponseCode(Code);
            setBody(body);
        }
        public Response()
        {

        }
        public string getResponseCode()
        {
            return responseCode;
        }
        public void setResponseCode(string responseCode)
        {
            this.responseCode = responseCode;
        }
        public string getBody()
        {
            return body;
        }
        public void setBody(String body)
        {
            this.body = body;
        }

        public String TOSTR()
        {
            return str + "code: " + responseCode.ToString() + " " + body;
        }
        public String toString()
        {
            //return str+ "Code: "+responseCode.toString()+"\tBody: "+body;
            //Content-Type: text/xml
            return str + "code: " + responseCode.ToString() + " " + body;
        }
        
    }
}
