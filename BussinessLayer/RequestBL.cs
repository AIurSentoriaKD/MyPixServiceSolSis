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
    public class RequestBL : Interfaces.I_Requests
    {
        private readonly DatosSQL capadatos = new DatosSQL(); // OJO

        // Lista de requests aceptadas, para insertarlo con illust
        public DataTable AcceptedRequestsList(int codUser)
        {
            return capadatos.TraerDataTable("spAcceptedRequestsList", codUser);
        }

        // Finalizar request
        public bool RequestFinish(int request_id, int illust_id)
        {
            // al momento de publicar una illust nueva,
            // se puede especificar que es de request,
            // se usa AcceptedRequestsList() para traer las requests,
            // se selecciona la REQUEST correspondiente, el cual contiene el request_id
            // entonces se inserta con el id de illust que se generó en el
            // cliente
            DataRow dr = capadatos.TraerDataRow("spRequestFinish", request_id, illust_id);
            if (dr["CodError"].Equals("0"))
                return true;
            else return false;
        }
        // Obtener Lista de requests
        public DataTable RequestsList(string codUser, string rec_type = "SELF")
        {
            // rec_type : SELF || FROM
            //      SELF hacia el usuario
            //      FROM por el usuario
            return capadatos.TraerDataTable("spRequestsList", codUser, rec_type);
        }
        // Pedir request, si requestopen es true
        public bool RequestSolitude(Request request, AuthorRequest authorRequest)
        {
            if (RequestsOpen(request.Author_id))
            {
                DataRow dr = capadatos.TraerDataRow("spRequestSolitude", authorRequest.Requester_id, request.Author_id, request.Requester_comment);
                if (dr["CodError"].Equals("0"))
                    return true;
                else return false;
            }
            return false;
        }
        // Aceptar request
        public bool RequestSolitudeAccept(int request_id)
        {
            DataRow dr = capadatos.TraerDataRow("spRequestSolitudeAccept", request_id);
            if (dr["CodError"].Equals("0"))
                return true;
            else return false;
        }
        // Rechazar request
        public bool RequestSolitudeReject(int request_id)
        {
            DataRow dr = capadatos.TraerDataRow("spRequestSolitudeReject", request_id);
            if (dr["CodError"].Equals("0"))
                return true;
            else return false;
        }
        // obtener estado de requests de un autor
        public bool RequestsOpen(int author_id)
        {
            DataRow dr = capadatos.TraerDataRow("spRequestsOpen", author_id);
            if (dr["CodError"].Equals("0"))
            {
                if (dr["CurrentRequest"].Equals("0"))
                    return false;
                else 
                    return true;
            }
            else return false;
        }
    }
}
