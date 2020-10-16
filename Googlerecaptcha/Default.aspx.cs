using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Googlerecaptcha
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BTN_Click(object sender, EventArgs e)
        {
            var encodedResponse = Request.Form["g-Recaptcha-Response"];
            var isCaptchaValid = Googlev2.Validate(encodedResponse);
            if(isCaptchaValid)
            {
                Response.Write("başarılı");
                Response.End();
            
            }
            else
            {

                Response.Write("HATA");
                Response.End();
            }
        }
    }
}