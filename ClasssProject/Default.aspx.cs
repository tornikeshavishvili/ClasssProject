using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClasssProject
{
    public partial class _DefaultD : Page
    {

         
        protected void Page_Load(object sender, EventArgs e)
        {
            
            myTextInput.TextChanged += MyTextInput_TextChanged;
            if (IsPostBack)
            {

                
                if (Request.Cookies["Username"] == null)
                {
                    HttpCookie cookie = new HttpCookie("Username", "JohnDoe" + new Random().Next(100));
                    cookie.Expires = DateTime.Now.AddDays(1);
                    Response.Cookies.Add(cookie);
                }
                
                /*
                if (ViewState["Username"] == null)
                {
                    ViewState["Username"] = "1";
                }
                else
                {
                    string counter = ""+ViewState["Username"];
                    int cInt = int.Parse(counter);
                    cInt++;
                    ViewState["Username"] = cInt+""; // + "-"+Request.QueryString["ourQueryparam"];
                }*/

                /*if (Session["Username"] == null)
                {
                    Session["Username"] = "1";
                }
                else
                {
                    string counter = (string)Session["Username"];
                    int cInt = int.Parse(counter);
                    cInt++;
                    Session["Username"] = cInt+""; // + "-"+Request.QueryString["ourQueryparam"];
                }*/


                //mypage.aspx?qp1=val1&qp2=val2&qp3=3
                //Response.Redirect("Default.aspx?ourQueryparam="+Session["Username"]);

                // Check for a specific condition if needed
                // For example, set focus only if a certain button is clicked
                if (Request.Form["__EVENTTARGET"] == myTextInput.UniqueID)
                {
                    // Set focus to the TextBox control
                    Page.SetFocus(myTextInput);
                }
            }
        }

        private void MyTextInput_TextChanged(object sender, EventArgs e)
        {
            myFirstASPControl.Text = myTextInput.Text;
        }
    }
}