﻿using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Interfaces
{
    interface I_Requests
    {
        /*
            CodUser representa al usuario logeado
         */
        // obtener estado de requests de un autor
        bool RequestsOpen(int author_id);

        // Obtener Lista de requests hacia el usuario
        DataTable RequestsList(string codUser, string rec_type);

        // Pedir request, si requestopen es true
        bool RequestSolitude(Request request, AuthorRequest authorRequest);

        // Aceptar request
        bool RequestSolitudeAccept(int request_id);

        // Rechazar request
        bool RequestSolitudeReject(int request_id);

        // Finalizar request
        bool RequestFinish(int request_id, int illust_id);

        // Lista de requests aceptadas, para insertarlo con illust
        DataTable AcceptedRequestsList(int codUser);
    }
}
