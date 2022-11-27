using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Interfaces
{
    interface I_AuthorFacturation
    {
        /*
            CodUser representa el id del autor en todos los casos
         */
        // obtiene el estado de facturacion de un usuario
        bool FactStatus(string codUser);

        // obtiene la informacion de facturacion del usuario, si esta existe
        // esta informacion es privada, solo el usuario la puede ver
        // se deberia llamar solo en config del usuario.
        DataRow FactInfo(string codUser);

        // Agrega informacion de facturacion del usuario,
        // se debe llamar despues de UserCardAdd en I_FacturationCard
        bool AuthorFacturationAdd(AuthorFacturation authorFacturation);

        // Obtiene SOLO el balance de la cuenta de facturacion del usuario
        string FacturationBalance(string codUser);

        // Permite actualizar el estado de apertura de las comisiones una vez se agregó
        // la informacion de facturación
        bool FacturationCommisionOpens(string codUser);

        // Permite actualizar la informacion de facturacion, siendo solo, 
        // fact address postal y country
        bool FacturationInfoUpdate(string codUser, string[] parametros);
    }
}
