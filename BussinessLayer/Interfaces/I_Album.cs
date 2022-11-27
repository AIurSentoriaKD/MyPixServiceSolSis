using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Interfaces
{
    interface I_Album
    {
        /*
            codUser es el id del usuario logeado
            author_id es el id de otro autor
         */


        // Listar albumes de un usuario o autor (info minima)
        DataTable GetAlbumList(string author_id, string usertype);

        // Obtener ilustraciones de un album
        DataTable GetAlbumIllustInfo(string codAlbum);

        // Crear nuevo album
        void AddNewAlbum(Album album);

        // Eliminar album
        void DeleteAlbum(string album_id, string owner_id);

        // Editar album - solo se permite el nombre
        void EditAlbum(string owner_id, string album_id, string album_name);

        // Cambiar estado publico del album
        void EditAlbumPublic(string owner_id, string album_id);
    }
}
