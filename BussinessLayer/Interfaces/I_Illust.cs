using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Interfaces
{
    interface I_Illust
    {
        /*
            codUser representa el id del usuario logeado
         */
        // Obtener ilustraciones en orden defecha descendente de los artistas que
        // el usuario sigue
        DataTable DashboardFollowsIllust(string codUser);

        // Obtener el ranking de imagenes del dia actual
        DataTable DashboardRankings();

        // Obtener el ranking de imagenes popular entre generos
        DataTable MaleDashboardRankings();
        DataTable FemaleDashboardRankings();

        // Obtener ilustraciones recomendadas al usuario actual
        DataTable DashboardRecommendedIllusts(string codUser);

        // Obtener artistas recomendados al usuario actual
        DataTable DashboardRecommendedArtists(string codUser);

        // Obtener posts recientes de artistas seguidos por el usuario
        DataTable DashboardFollowingPosts(string codUser);

        // Publicar Nueva ilustracion, paginas y etiquetas
        // se llaman cada vez por cada pagina o tag
        bool NewIllustPublish(Illust illust);
        bool AttachPageNewIllust(IllustPages page);
        bool AttachTagNewIllust(IllustTags tag);

        // Borrar Ilustracion del usuario
        bool DeleteIllust(string illust_id, string codUser);

        // Editar informacion de la ilustracion publicada
        bool EditIllustPublish(string illust_id, string codUser,string opcion, string parametro);

        // Sumar un view a una ilustracion cuando el usuario visita la pagina de la illust
        void SumViewIllust(string illust_id);

        // dar like a la ilustracion (lo agrega al album por defecto)
        bool AddIllustFavorites(string illust_id, string codUser);

        DataTable GetIllust(string illust_id);

        DataTable GetIllustPages(int illust_id);

        DataTable GetUserIllusts(int author_id);
    }
}
