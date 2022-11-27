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
    public class AlbumIllustBL : Interfaces.I_AlbumIllust
    {
        private readonly DatosSQL capadatos = new DatosSQL(); // OJO
        public bool AddNewIllustAlbum(string codUser, AlbumIllust albumIllust)
        {
            // se llama cuando el usuario maneja sus favoritos y quiere agregar una illust a otro album
            DataRow res = capadatos.TraerDataRow("spAddIllustToAlbum",codUser, albumIllust.Album_id, albumIllust.Illust_id);
            int cod = Convert.ToInt32(res["CodError"]);
            if (cod != 0) return true;
            else return false;
        }

        public bool RemoveIllustAlbum(string album_id, string illust_id, string owner_id)
        {
            DataRow dr = capadatos.TraerDataRow("spRemoveIllustFromAlbum", album_id, owner_id, illust_id);
            if (dr["CodError"].Equals("0"))
                return true;
            else return false;
        }
    }
}
