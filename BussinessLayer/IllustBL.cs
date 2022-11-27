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
    public class IllustBL : Interfaces.I_Illust
    {
        private readonly DatosSQL capadatos = new DatosSQL(); // OJO

        public bool AddIllustFavorites(string illust_id, string codUser)
        {
            // cuando el usuario da like a una illust se llama a este
            DataRow res = capadatos.TraerDataRow("spAddIllustToAFavorites",codUser, illust_id);
            int cod = Convert.ToInt32(res["CodError"]);
            if(cod != 0) return true;
            else return false;
        }

        public DataTable DashboardFollowingPosts(string codUser)
        {
            // lista de posts recientes de artistas que sigue el usuario 
            return capadatos.TraerDataTable("spDashboardFollowingPosts", codUser);
        }

        public DataTable DashboardFollowsIllust(string codUser)
        {
            // lista de illusts recientes de artistas que sigue el usuario 
            return capadatos.TraerDataTable("spDashboardFollowingIllusts", codUser);
        }

        public DataTable DashboardRankings()
        {
            return capadatos.TraerDataTable("spGlobalRankingIllusts");
        }

        public DataTable FemaleDashboardRankings()
        {
            return capadatos.TraerDataTable("spFemaleRankingIllusts");
        }

        public DataTable MaleDashboardRankings()
        {
            return capadatos.TraerDataTable("spMaleRankingIllusts");
        }

        public DataTable DashboardRecommendedArtists(string codUser)
        {
            return capadatos.TraerDataTable("spRecommendedArtists", codUser);
        }

        public DataTable DashboardRecommendedIllusts(string codUser)
        {
            // falta implementar procedure
            return capadatos.TraerDataTable("spRecommendedIllusts", codUser);
        }

        public bool DeleteIllust(string illust_id, string codUser)
        {
            DataRow res = capadatos.TraerDataRow("spDeleteIllust", illust_id, codUser);
            int cod = Convert.ToInt32(res["CodError"]);
            if (cod > 0) return false;
            else return true;
        }

        public bool EditIllustPublish(string illust_id, string codUser,string opcion, string parametro)
        {
            DataRow dr = null;
            // opcion el procedure se encarga de diferenciar opcion
            
            dr = capadatos.TraerDataRow("spIllustDetailUpdate", codUser, illust_id, opcion, parametro);
            
            int cod = Convert.ToInt32(dr["CodError"]);
            if (cod > 0) return false;
            else return true;
        }


        public bool NewIllustPublish(Illust illust)
        {
            // primero se agrega la illust
            DataRow dr = capadatos.TraerDataRow("spNewIllustCreate", illust.Id, illust.Title, illust.Sanity, illust.Author_id, illust.Illust_type, illust.Is_nsfw, illust.Thumb_dir, illust.Ugoira_dir);
            if (dr["CodError"].Equals("0"))
                return true;
            else
                return false;
            
        }
        public bool AttachPageNewIllust(IllustPages page)
        {
            DataRow dr = capadatos.TraerDataRow("spNewPageAttach", page.Parent_illust, page.Page_number, page.Large_dir);
            if (dr["CodError"].Equals("0"))
                return true;
            else
                return false;
        }
        public bool AttachTagNewIllust(IllustTags tag)
        {
            DataRow dr = capadatos.TraerDataRow("spNewTagAttach", tag.Tag_name, tag.Illust_id);
            if (dr["CodError"].Equals("0"))
                return true;
            else
                return false;
        }
        public void SumViewIllust(string illust_id)
        {
            capadatos.Ejecutar("spAddViewIllust", illust_id);
        }
        public DataTable GetIllust(string illust_id)
        {
            return capadatos.TraerDataTable("spGetIllust", illust_id);
        }
        public DataTable GetIllustPages(int illust_id)
        {
            return capadatos.TraerDataTable("spGetIllustPages", illust_id);
        }

        public DataTable GetUserIllusts(int author_id)
        {
            return capadatos.TraerDataTable("spGetUserIllusts", author_id);
        }
    }
}
