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