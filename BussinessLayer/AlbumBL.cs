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
    public class AlbumBL : Interfaces.I_Album
    {
        private readonly DatosSQL capadatos = new DatosSQL(); // OJO
        public void AddNewAlbum(Album album)
        {
            capadatos.Ejecutar("spNewAlbumCreate", album.Owner_id, album.Album_name, album.Public_status);
        }

        public void DeleteAlbum(string album_id, string owner_id)
        {
            capadatos.Ejecutar("spDeleteAlbum",album_id, owner_id);
        }

        public void EditAlbum(string owner_id, string album_id,string album_name)
        {
            capadatos.Ejecutar("spEditAlbum", owner_id, album_id, album_name);
        }

        public void EditAlbumPublic(string owner_id, string album_id)
        {
            capadatos.Ejecutar("spEditAlbumStatus", owner_id,album_id);
        }

        public DataTable GetAlbumIllustInfo(string codAlbum)
        {
            return capadatos.TraerDataTable("spListAlbumIllusts", codAlbum);
        }


        // LISTAR ALBUMES DE UN USER O AUTHOR
        public DataTable GetAlbumList(string author_id, string usertype)
        {
            return capadatos.TraerDataTable("spListAlbums", author_id, usertype);
        }


    }
}
