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
                /* if (Session["Username"] == null)
                {
                    Session["Username"] = "1";
                }
                else
                {
                    String counter = (String)Session["Username"];
                    int cInt = int.Parse(counter);
                    cInt++;
                    Session["Username"] = cInt + "-" + Request.QueryString["ourQueryParam"];
                }*/

                /* if (ViewState["Username"] == null)
                {
                    ViewState["Username"] = "1";
                }
                else
                {
                    String counter = (String)ViewState["Username"];
                    int cInt = int.Parse(counter);
                    cInt++;
                    ViewState["Username"] = cInt + "";
                } */
                /* if (Request.Cookies["Username"] == null)
                {
                    HttpCookie cookie = new HttpCookie("Username", "JohnDoe" + (new Random().Next(100)));
                    cookie.Expires = DateTime.Now.AddDays(1);
                    Response.Cookies.Add(cookie);
                }  */              

                // Response.Redirect("Default.aspx?ourQueryParam=" + Session["Username"]);

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