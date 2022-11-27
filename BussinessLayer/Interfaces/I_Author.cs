using System.Data;
using EntityLayer;

namespace BussinessLayer.Interfaces
{
    interface I_Author
    {
        /*
            En la mayoria de Casos CodUser se refiere al id del autor que esta logeado
            y CodAuthor, hace referencia al id de otros usuarios/artistas
         */
        // Lista de autores...?
        DataTable Listar();
        DataTable SingleAuthorInfo(string codAuthor);

        // Login, retorna la info del user si los atrib son correctos
        DataTable LoginInfo(string mail);

        // Login con encrypt
        DataTable LoginInfoConEncrpyt(string email, string passw, string patttern);
        // Register con encrypt
        bool AgregarConEncrpyt(Author author, string patttern);
        // Registrar nuevo autor
        bool Agregar(Author author);

        // Actualizar informacion de autor, usado solo para bio, imagen de perfil y portada
        // nickname, country y genero
        string UpdateProfileInfo(string codUser, string opcion, string parametro);

        // metodos para actualizar estado de requests
        bool UpdateRequestStatus(string codUser);

        // metodo para actualizar la restriccion de contenido
        bool EnableSensitiveContent(string codUser);

        // metodo para agregar un page view
        void AddViewPageCounter(string codUser);

        // comprueba el trust_level dependiendo de las comisiones realizadas
        int TrustLevelReview(string codUser);

        // seguir a un autor, codAuthor es a quien se sigue, y cod User el que sigue
        // por ejm, codUser = 123 va a seguir a codAuthor = 12345
        string Follow(string codAuthor, string codUser);

        // Bool que indica si el autor sigue a otro
        bool Followed(string codAuthor, string codUser);

        // Datos de los artistas que sigue el user
        DataTable Following(string codUser);

        // Datos de los artistas que tienen comisiones abiertas
        DataTable OpenCommissionList();

        // Datos de los artistas que tienen requests abiertas
        DataTable OpenRequestList();

        // Datos de los artistas que siguen al usuarioi
        DataTable Followers(string codUser);
    }
}
