using BCrypt.Net;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestingWebServices.Pages
{
    public partial class frmRegister : System.Web.UI.Page
    {
        private static ServiceReferenceAuthor.wsAuthorSoapClient serviceAuthor = new ServiceReferenceAuthor.wsAuthorSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregarUsuario(object sender, EventArgs e)
        {
            try
            {
                //string hashedPass = BCrypt.Net.BCrypt.HashPassword(txtClave.Text);
                //DateTime fechaNac = Convert;
                //DateTime fecha = DateTime.ParseExact(txtBirthDate.Text, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
                //string birthDate = fecha.ToString("yyyy-MM-dd");
                string test = "2001-04-28";
                //'2022-11-08'

                if (txtAccountName.Text == "" || txtCountry.Text == "" || txtBirthDate.Text == "" || txtEmail.Text == "" || txtNickName.Text == "" || txtIdAuthor.Text == "")
                {
                    lblError.Text = "Los campos no pueden quedar vacíos!";
                }
                //else if (user >= 1)
                //{
                //    lblError.Text = "El usuario " + tbUsuario.Text + " ya existe!";
                //}
                else if (txtClave.Text != tbClave2.Text)
                {
                    lblError.Text = "Los contraseñas no coinciden!";
                    //Response.Write("<script language=javascript>alert('" + txtBirthDate.Text + "');</script>");
                }
                //else if (txtClave.Text == tbClave2.Text)  
                //{
                //    Response.Write("<script language=javascript>alert('" + test + "');</script>");
                //}
                else
                {
                    string patron = "MBC";
                    //serviceAuthor.AgregarEncrypt(  , patron);
                    serviceAuthor.Agregar(int.Parse(txtIdAuthor.Text), txtNickName.Text, txtAccountName.Text, txtEmail.Text, txtClave.Text, "2000-10-10", txtCountry.Text);
                    Response.Redirect("/Pages/frmLogin.aspx");

                }
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
        }

        protected void btnCancelar(object sender, EventArgs e)
        {
            Response.Redirect("/Pages/frmLogin.aspx");
        }



        /// los servicios son agregarencrypt  . loginInEncrypt  
        ///                   agregarconencrytp  validateWithEncrypt AUTHOR BL
        ///        I_AUTHOR
        ///      DataTable LoginInfoConEncrpyt(string email, string passw, string patttern);
        //       bool AgregarConEncrpyt(Author author, string patttern);




    }
}