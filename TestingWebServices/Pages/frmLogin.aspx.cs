using BCrypt.Net;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestingWebServices.Pages
{
    public partial class frmLogin : System.Web.UI.Page
    {
        private static ServiceReferenceAuthor.wsAuthorSoapClient serviceAuthor = new ServiceReferenceAuthor.wsAuthorSoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrarse(object sender, EventArgs e)
        {
            Response.Redirect("/Pages/frmRegister.aspx");
        }

        protected void btnLogIn(object sender, EventArgs e)
        {
            if (txtEmail.Text == "" || txtPassword.Text == "")
            {
                lblError.Text = "Los campos no pueden quedar vacíos!";
            }
            else
            {
                DataTable dt = serviceAuthor.LoginIn(txtEmail.Text, txtPassword.Text);

                if (dt != null)
                {
                Response.Redirect("/Pages/Test.aspx");
                }
                else
                {
                    lblError.Text = "Credentials are inconrrect";
                }

                //Session["loggedUser"] = dr["Id"].ToString();

            }
        }


    }
}