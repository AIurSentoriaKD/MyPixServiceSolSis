using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Interfaces
{
    interface I_Commission
    {
        /*
            coduser es el id de usuario logeado
         */
        // Obtener Lista de comisiones pedidas al usuario
        DataTable GetCommissionsList(string codUser);

        // Obtener Lista de peticiones de comision del usuario
        DataTable GetCommissionRequestsList(string codUser);

        // Verifica el estado de apertura de comisiones de un autor 
        bool IsCommissionActive(string author_id);

        // Permite pedir una comision a un artista
        string RequestNewCommission(Commission commission);

        // Obtiene una lista de usuarios que tienen comisiones abiertas
        DataTable CommissionDashboardArtistsList();

        // Obtiene una lista de ilustraciones de comisiones recientemente realizadas
        DataTable CommissionDashboardIllustsList();

        // Obtiene una lista del estado de comisiones de artistas que el usuario sigue
        DataTable CommissionDashboardFollowingList(string codUser);

        // Obtiene una lista de ilustraciones de comision recientes que el usuario sigue
        DataTable CommissionDashboardFollowingRecents(string codUser);
    }
}
