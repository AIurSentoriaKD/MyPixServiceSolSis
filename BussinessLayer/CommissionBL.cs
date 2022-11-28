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
    public class CommissionBL : Interfaces.I_Commission, Interfaces.I_CommDetail
    {
        private readonly DatosSQL capadatos = new DatosSQL(); // OJO
        // Obtiene una lista de usuarios que tienen comisiones abiertas
        public DataTable CommissionDashboardArtistsList()
        {
            return capadatos.TraerDataTable("spCommissionDashboardArtistsList");
        }
        // Obtiene una lista del estado de comisiones de artistas que el usuario sigue
        public DataTable CommissionDashboardFollowingList(string codUser)
        {
            return capadatos.TraerDataTable("spCommissionDashboardFollowingList", codUser);
        }
        // Obtiene una lista de ilustraciones de comision recientes que el usuario sigue
        public DataTable CommissionDashboardFollowingRecents(string codUser)
        {
            return capadatos.TraerDataTable("spCommissionDashboardFollowingRecents", codUser);
        }
        // Obtiene una lista de ilustraciones de comisiones recientemente realizadas
        public DataTable CommissionDashboardIllustsList()
        {
            return capadatos.TraerDataTable("spCommissionDashboardIllustsList");
        }
        // Obtener Lista de peticiones de comision del usuario
        public DataTable GetCommissionRequestsList(string codUser)
        {
            return capadatos.TraerDataTable("spGetCommissionRequestsList", codUser);
        }
        // Obtener Lista de comisiones pedidas al usuario
        public DataTable GetCommissionsList(string codUser)
        {
            return capadatos.TraerDataTable("spGetCommissionsList", codUser);
        }
        // Verifica el estado de apertura de comisiones de un autor 
        public bool IsCommissionActive(string author_id)
        {
            DataRow dr = capadatos.TraerDataRow("spIsCommissionActive", author_id);
            if (Convert.ToInt32( dr[1]) == 1)
                return true;
            else return false;
        }
        // Permite pedir una comision a un artista
        public string RequestNewCommission(Commission commission)
        {
            DataRow dr = capadatos.TraerDataRow("spRequestNewCommission", commission.Author_id, commission.Details, commission.Deliver_date, commission.Commissioner_id);
            return dr["Mensaje"].ToString();   
        }

        // I_COMMDETAIL
        // Terminar Comision
        public bool CommissionFinish(int comm_id, int illust_id = 0)
        {
            // no es obligatorio que ingrese id de illust
            DataRow dr = capadatos.TraerDataRow("spCommissionFinish", comm_id, illust_id);
            if (dr["CodError"].Equals("0"))
            {
                // todo sale bien
                return true;
            }else if (dr["CodError"].Equals("1"))
            {
                // ocurrió un percance 
                return false;
            }
            return false;
        }
        // Rechazar pedido de comision
        public bool CommissionReject(int comm_id)
        {
            DataRow dr = capadatos.TraerDataRow("spCommissionReject", comm_id);
            if (dr["CodError"].Equals("0"))
                return true;
            else return false;
        }
        // Aceptar comision
        public bool CommissionAccept(CommissionDetail commissionDetail)
        {
            // el price lo especifica el artista al aceptar la comision
            DataRow dr = capadatos.TraerDataRow("spCommissionAccept", commissionDetail.Comm_id, commissionDetail.Fact_id, commissionDetail.Price);
            if (dr["CodError"].Equals("0"))
                return true;
            else return false;
        }
    }
}
