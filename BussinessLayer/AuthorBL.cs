using CapaDatos;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BussinessLayer
{
    public class AuthorBL : Interfaces.I_Author
    {
        private readonly DatosSQL capadatos = new DatosSQL(); // OJO

        public DataTable SingleAuthorInfo(string codAuthor)
        {
            return capadatos.TraerDataTable("spGetAuthorInfo",codAuthor);
        }
        public void AddViewPageCounter(string codUser)
        {
            // solo se llama al metodo cada vez que se entra a una pagina de illustview
            capadatos.TraerDataRow("spAddPageView", codUser);
            // retorna algo, pero si no recibimos ese return no deberia pasar nada, creo
        }

        public bool Agregar(Author author)
        {
            DataRow res = capadatos.TraerDataRow("spAgregarNuevoAutor", author.Author_id, author.Nickname, author.Accountname, author.Email, author.Password, author.Birthdate, author.Country);
            
            string cod = Convert.ToString(res["CodError"]);
            if (cod.Equals("0"))
                return true;
            else return false;
        }

        public bool EnableSensitiveContent(string codUser)
        {
            DataRow res = capadatos.TraerDataRow("spEnableNsfw", codUser);
            string cod = Convert.ToString(res["CodError"]);
            if (cod.Equals("0"))
                return true;
            else return false;
        }

        public string Follow(string codAuthor, string codUser)
        {
            // automaticamente el procedure sigue, si no lo seguia antes. 
            // si ya lo seguia, deja de seguirlo
            DataRow res = capadatos.TraerDataRow("spFollowNewArtist", codUser, codAuthor);
            string cod = Convert.ToString(res["CodError"]);
            return Convert.ToString(res["Mensaje"]);

        }

        public bool Followed(string codAuthor, string codUser)
        {
            DataRow res = capadatos.TraerDataRow("spIsFollowing", codUser, codAuthor);
            string cod = Convert.ToString(res["CodError"]);
            if (cod.Equals("0"))
                return true; // lo sigue
            else return false; // no lo sigue
        }

        public DataTable Following(string codUser)
        {
            // Lista de autores que sige el user

            DataTable dt = capadatos.TraerDataTable("spListFollowings", codUser);
            return dt;
            
        }
        public DataTable Followers(string codUser)
        {
            // Lista de usuarios o autores que sigen al user
            try
            {
                DataTable dt = capadatos.TraerDataTable("spListFollowers", codUser);
                string cod = Convert.ToString(dt.Rows[0]["CodError"]);
                if (cod.Equals("0"))
                    return dt;
                else throw new Exception("El codigo no existia");
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataTable Listar()
        {
            DataTable dt = capadatos.TraerDataTable("spListAllAuthors");

            return dt;
        }

        public DataTable LoginInfo(string mail)
        {
            DataTable dt = capadatos.TraerDataTable("spAuthorLogin", mail);
            try
            {
                int author_id = Convert.ToInt32(dt.Rows[0]["author_id"]);
                return dt;
            }
            catch
            {
                //throw new Exception(Convert.ToString(dt.Rows[0]["Mensaje"]));
                return null;
            }
        }

        public DataTable OpenCommissionList()
        {
            DataTable dt = capadatos.TraerDataTable("spCommissionOpenAuthors");
            return dt;
        }

        public DataTable OpenRequestList()
        {
            DataTable dt = capadatos.TraerDataTable("spRequestsOpenAuthors");
            return dt;
        }
       
        public int TrustLevelReview(string codUser)
        {
            // en este metodo, cod user se puede traer para ver el trust del usuario logeado
            // tmb se puede traer el id de otro autor para actualizar su trust level
            // al momento de ver su perfil, o hacerlo trigger, idk
            DataRow dt = capadatos.TraerDataRow("spAuthorTrustLevelGet", codUser);
            int trustlevel = Convert.ToInt32(dt["trust_level"]);
            return trustlevel;
        }

        public string UpdateProfileInfo(string codUser, string opcion, string parametro)
        {
            DataRow dr = null;
            // en opcion
            if (opcion.Equals("PROFILE"))
            {
                dr = capadatos.TraerDataRow("spAuthorDetailsUpdate", parametro);
            }
            else if (opcion.Equals("BIO")){
                dr = capadatos.TraerDataRow("spAuthorDetailsUpdate", parametro);
            } 
            else if (opcion.Equals("COUNTRY"))
            {
                dr = capadatos.TraerDataRow("spAuthorDetailsUpdate", parametro);
            }
            else if (opcion.Equals("GENDER"))
            {
                dr = capadatos.TraerDataRow("spAuthorDetailsUpdate", parametro);
            }
            else
            {
                return "No hay opcion";
            }
            string respuesta = Convert.ToString(dr["Mensaje"]);
            return respuesta;
        }

        public bool UpdateRequestStatus(string codUser)
        {
            DataRow dr = capadatos.TraerDataRow("spSetOpenRequests", codUser);
            int cod = Convert.ToInt32(dr["CodError"]);
            if (cod == 0) return true;
            else return false;
        }

        // login con encrypt
        public DataTable LoginInfoConEncrpyt(string email, string passw, string patttern)
        {
            return capadatos.TraerDataTable("spValidateWithEncrypt", email, passw, patttern);
        }

        // Register con encrypt
        public bool AgregarConEncrpyt(Author author, string pattern)
        {
            DataRow dr = capadatos.TraerDataRow("spRegisterWithEncrypt", author.Author_id, author.Nickname, author.Accountname, author.Email, author.Birthdate, author.Country, author.Password, pattern);
            if (dr["CodError"].Equals("0"))
                return true;
            else return false;
        }
    }
}
