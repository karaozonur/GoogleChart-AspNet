using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Googlerecaptcha
{
    public class Googlev2
    {
        public bool Success { get; set; }
        public List<string> ErrorCodes { get; set; }
        public static bool Validate (string encodedResponse)
        {
            try
            {
                if (string.IsNullOrEmpty(encodedResponse)) return false;
                var client = new System.Net.WebClient();
                var secret = "6Lfx6qgZAAAAAKRQ9gZDncAsSvQh_z3iksusJ_rq";
                if(string.IsNullOrEmpty(secret) ) return false;
                var googleReply = client.DownloadString(string.Format("https://www.google.com/recaptcha/api/siteverify?secret={0}&response={1}",secret, encodedResponse));
                var serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
                var reCaptcha = serializer.Deserialize<Googlev2>(googleReply);
                return reCaptcha.Success;
            }
            catch
            {
               
                throw;
            }

        }
    }
}