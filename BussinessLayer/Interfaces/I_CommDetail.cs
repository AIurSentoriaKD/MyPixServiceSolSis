using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Interfaces
{
    interface I_CommDetail
    {
        // Terminar Comision
        bool CommissionFinish(int comm_id, int illust_id = 0);

        // Aceptar comision
        bool CommissionAccept(CommissionDetail commissionDetail);

        // Rechazar pedido de comision
        bool CommissionReject(int comm_id);
    }
}
