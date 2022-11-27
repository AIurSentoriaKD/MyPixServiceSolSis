using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Interfaces
{
    interface I_FacturationCard
    {
        // Agregar informacion de tarjeta
        string FacturationCardAddNew(FacturationCard facturationCard);
    }
}
