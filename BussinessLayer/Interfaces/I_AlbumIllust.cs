using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Interfaces
{
    interface I_AlbumIllust
    {
        // Agregar ilustracion a un album
        bool AddNewIllustAlbum(string codUser, AlbumIllust albumIllust);

        // Quitar ilustracion de un album
        bool RemoveIllustAlbum(string album_id, string illust_id, string owner_id);
    }
}
