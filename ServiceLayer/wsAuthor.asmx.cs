using BussinessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Script.Serialization;
using System.Web.UI.WebControls;

namespace ServiceLayer
{
    /// <summary>
    /// Descripción breve de wsAuthor
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsAuthor : System.Web.Services.WebService
    {

        #region WEB SERVICE ILLUSTPAGE METHODS
        [WebMethod(Description = "Sumar view a illust - IllustPage")]
        public void SumViewIllust(string illust_id)
        {
            IllustBL illustBL = new IllustBL();
            illustBL.SumViewIllust(illust_id);
        }
        [WebMethod(Description = "Obtener la informacion de una illust - IllustPage")]
        public DataTable GetIllust(string illust_id)
        {
            IllustBL illustBL = new IllustBL();
            return illustBL.GetIllust(illust_id);
        }

        [WebMethod(Description = "Obtener las paginas de una illust - IllustPage")]
        public DataTable GetIllustPages(int illust_id)
        {
            IllustBL illustBL = new IllustBL();
            return illustBL.GetIllustPages(illust_id);
        }

        // METODOS DE TAGS BL
        [WebMethod(Description = "Obtener las etiquetas de una illust - IllustPage")]
        public DataTable GetIllustsTags(int illust_id)
        {
            TagsBL tagsBL = new TagsBL();
            return tagsBL.GetIllustsTags(illust_id);
        }

        [WebMethod(Description = "Obtener etiquetas mas populares - Dashboard")]
        public DataTable GetPopularTags()
        {
            TagsBL tagsBL = new TagsBL();
            return tagsBL.GetPopularTags();
        }
        #endregion

        #region WEB SERVICE ILLUST MANAGE METHODS
        [WebMethod(Description = "Obtener las ilustraciones de un autor por ID")]
        public DataTable GetUserIllusts(int author_id)
        {
            IllustBL illustBL = new IllustBL();
            return illustBL.GetUserIllusts(author_id);
        }
        [WebMethod(Description = "Permite dar like a una illust - IllustPage")]
        public bool AddIllustFavorites(string illust_id, string codUser)
        {
            IllustBL illustBL = new IllustBL();
            return illustBL.AddIllustFavorites(illust_id, codUser);
        }
        [WebMethod(Description = "Elimina una ilustracion del usuario")]
        public bool DeleteIllust(string illust_id, string codUser)
        {
            IllustBL illustBL = new IllustBL();
            return illustBL.DeleteIllust(illust_id, codUser);
        }

        [WebMethod(Description = "Editar una ilustracion del usuario")]
        public bool EditIllustPublish(string illust_id, string codUser, string opcion, string parametro)
        {
            IllustBL illustBL = new IllustBL();
            return illustBL.EditIllustPublish(illust_id, codUser, opcion, parametro);
        }

        #region Publicación de nueva illust
        [WebMethod(Description = "Agregar una nueva ilustracion")]
        public bool NewIllustPublish(int id, string title, int sanity, int author, string il_type, int is_nsfw, string thumb_dir, string ugoira_dir = "")
        {
            IllustBL illustBL = new IllustBL();
            Illust illust = new Illust
            {
                Id = id,
                Title = title,
                Sanity = sanity,
                Author_id = author,
                Illust_type = il_type,// ILLUST | UGOIRA
                Is_nsfw = is_nsfw, // 0 | 1
                Thumb_dir = thumb_dir,
                Ugoira_dir = ugoira_dir
            };
            // Agregar paginas y etiquetas es repetitivo x.
            // llaman varias veces a paginas y tags, son los 2 sig
            // se hace en el cliente web
            return illustBL.NewIllustPublish(illust);
        }

        [WebMethod(Description = "Metodo para agregar una pagina de una illust - llamar justo luego de NewIllustPublish")]
        public bool AttachPageNewIllust(int parent, int page_num, string large_dir)
        {
            IllustBL illustBL = new IllustBL();
            IllustPages page = new IllustPages
            {
                Parent_illust = parent,
                Page_number = page_num,
                Large_dir = large_dir
            };
            return illustBL.AttachPageNewIllust(page);
        }

        [WebMethod(Description = "Metodo para agregar etiquetas a una illust - llamar justo luego de NewIllustPublish")]
        public bool AttachTagNewIllust(string tag_name, string illust_id)
        {
            IllustBL illustBL = new IllustBL();
            IllustTags tag = new IllustTags
            {
                Tag_name = tag_name,
                Illust_id = illust_id
            };
            return illustBL.AttachTagNewIllust(tag);
        }
        #endregion

        #endregion

        #region WEB SERVICE DASHBOARD METHODS
        [WebMethod(Description = "Lista las illust de los usuarios que sigue  - Dashboard")]
        public DataTable DashboardFollowsIllust(string codUser)
        {
            IllustBL illustBL = new IllustBL();
            return illustBL.DashboardFollowsIllust(codUser);
        }
        [WebMethod(Description = "Lista los posts de los usuarios que sigue  - Dashboard")]
        public DataTable DashboardFollowingPosts(string codUser)
        {
            IllustBL illustBL = new IllustBL();
            return illustBL.DashboardFollowingPosts(codUser);
        }
        [WebMethod(Description = "Lista illust populares del dia global - Rankings | Dashboard")]
        public DataTable DashboardRankings()
        {
            IllustBL illustBL = new IllustBL();
            return illustBL.DashboardRankings();
        }

        [WebMethod(Description = "Lista illust populares del dia entre mujeres - Rankings")]
        public DataTable FemaleDashboardRankings()
        {
            IllustBL illustBL = new IllustBL();
            return illustBL.FemaleDashboardRankings();
        }

        [WebMethod(Description = "Lista illust populares del dia entre hombres - Rankings")]
        public DataTable MaleDashboardRankings()
        {
            IllustBL illustBL = new IllustBL();
            return illustBL.MaleDashboardRankings();
        }

        [WebMethod(Description = "Lista artistas recomendados para el usuario - Dashboard")]
        public DataTable DashboardRecommendedArtists(string codUser)
        {
            IllustBL illustBL = new IllustBL();
            return illustBL.DashboardRecommendedArtists(codUser);
        }

        [WebMethod(Description = "lista illusts recomendados para el usuario - Dashboard")]
        public DataTable DashboardRecommendedIllusts(string codUser)
        {
            IllustBL illustBL = new IllustBL();
            return illustBL.DashboardRecommendedIllusts(codUser);
        }
        #endregion

        #region WEB SERVICE AUTHOR METHODS

        [WebMethod(Description = "Info de un artista")]
        public DataTable SingleAuthor(string codAuthor)
        {
            AuthorBL authorBL = new AuthorBL();
            DataTable dt = authorBL.SingleAuthorInfo(codAuthor);
            return dt;
        }

        [WebMethod(Description = "Listar los artistas")]
        public DataTable ListAuthors()
        {
            AuthorBL authorBL = new AuthorBL();
            return authorBL.Listar();
            //DataTable dt = authorBL.Listar();
            //JavaScriptSerializer jsSerializer = new JavaScriptSerializer();
            //List<Dictionary<string, object>> parentRow = new List<Dictionary<string, object>>();
            //Dictionary<string, object> childRow;
            //foreach (DataRow row in dt.Rows)
            //{
            //    childRow = new Dictionary<string, object>();
            //    foreach (DataColumn col in dt.Columns)
            //    {
            //        childRow.Add(col.ColumnName, row[col]);
            //    }
            //    parentRow.Add(childRow);
            //}
            //Context.Response.Write(jsSerializer.Serialize(parentRow));
        }

        [WebMethod(Description = "Registrar un nuevo artista")]
        public bool Agregar(int authorid, string nickname, string accountname, string email, string pass, string birthdate, string country)
        {
            Author author = new Author();
            author.Author_id = authorid;
            author.Nickname = nickname;
            author.Accountname = accountname;
            author.Email = email;
            author.Password = BCrypt.Net.BCrypt.HashPassword(pass);
            author.Birthdate = birthdate;
            author.Country = country;

            AuthorBL authorBL = new AuthorBL();

            return authorBL.Agregar(author);
        }
        [WebMethod(Description = "Registrar un nuevo artista con encrypt")]
        public bool AgregarEncrypt(int authorid, string nickname, string accountname, string email, string pass, string birthdate, string country, string pattern)
        {
            Author author = new Author();
            author.Author_id = authorid;
            author.Nickname = nickname;
            author.Accountname = accountname;
            author.Email = email;
            author.Password = pass;
            author.Birthdate = birthdate;
            author.Country = country;

            AuthorBL authorBL = new AuthorBL();

            return authorBL.AgregarConEncrpyt(author, pattern);
        }

        [WebMethod(Description = "Activar contenido sensible")]
        public bool HabilitarContenidoR34(string codigoUsuario)
        {
            AuthorBL authorBL = new AuthorBL();
            return authorBL.EnableSensitiveContent(codigoUsuario);
        }

        [WebMethod(Description = "Seguir a un Artista - Se puede volver a llamar para hacer la accion contraria")]
        public string SeguirArtista(string codigoUsuario, string IDArtistaSeguir)
        {
            AuthorBL authorBL = new AuthorBL();
            return authorBL.Follow(IDArtistaSeguir, codigoUsuario);
        }
        [WebMethod(Description = "Respuesta si se Sigue a un artista")]
        public bool EstaSiguiendo(string codigoUsuario, string IDArtista)
        {
            AuthorBL authorBL = new AuthorBL();
            return authorBL.Followed(IDArtista, codigoUsuario);
        }
        [WebMethod(Description = "Lista de artistas que sigues")]
        public DataTable Siguiendo(string codigoUsuario)
        {
            AuthorBL authorBL = new AuthorBL();
            return authorBL.Following(codigoUsuario);
        }
        [WebMethod(Description = "Login Function")]
        public DataTable LoginIn(string mail, string passw)
        {
            AuthorBL authorBL = new AuthorBL();
            DataTable dt = authorBL.LoginInfo(mail);
            //passUser = dt.row[4] <=  [pasw]
            string passEncrypt = dt.Rows[0][4].ToString();
            bool verifyPass = BCrypt.Net.BCrypt.Verify(passw, passEncrypt);

            if (verifyPass)
            {
                return dt;
            }
            else
            {
                return null;
            }
        }
        [WebMethod(Description = "Login Function con Encrypt")]
        public DataTable LoginInEncrypt(string mail, string passw, string pattern)
        {
            AuthorBL authorBL = new AuthorBL();
            return authorBL.LoginInfoConEncrpyt(mail, passw, pattern);
        }
        [WebMethod(Description = "Comisiones abiertas")]
        public DataTable ComisionesAbiertas()
        {
            AuthorBL authorBL = new AuthorBL();
            return authorBL.OpenCommissionList();
        }
        [WebMethod(Description = "Requests abiertas")]
        public DataTable RequestsAbiertas()
        {
            AuthorBL authorBL = new AuthorBL();
            return authorBL.OpenRequestList();
        }
        [WebMethod(Description = "Retorna el trust level de un usuario")]
        public int UserTrustLevel(string codUser)
        {
            AuthorBL authorBL = new AuthorBL();
            return authorBL.TrustLevelReview(codUser);
        }
        [WebMethod(Description = "Actualizar informacion de perfil")]
        public string ActualizarPerfil(string codUser, string opcion, string parametro)
        {
            // se llama varias veces copn cada campo actualizado
            // permite: PROFILE, BIO, COUNTRY, GENDER
            // se deben validar el country y gender en el front
            AuthorBL authorBL = new AuthorBL();
            return authorBL.UpdateProfileInfo(codUser, opcion, parametro);
        }
        [WebMethod(Description = "Actualizar el estado de requests del usuario - UserSettings")]
        public bool AbrirRequests(string codUser)
        {
            AuthorBL authorBL = new AuthorBL();
            return authorBL.UpdateRequestStatus(codUser);
        }

        // AUTHORFACTURATIONBL
        [WebMethod(Description = "Agregar informacion de facturacion - UserSettings")]
        public bool AuthorFacturationAdd(string author_id, string fact_address, string fact_postal, string fact_country, float balance, string card_numb, string card_date)
        {
            AuthorFacturationBL authorFacturationBL = new AuthorFacturationBL();
            FacturationCard facturationCard = new FacturationCard
            {
                Card_date = card_date,
                Card_number = card_numb
            };
            int card_id = Convert.ToInt32(authorFacturationBL.FacturationCardAddNew(facturationCard));
            AuthorFacturation authorFacturation = new AuthorFacturation
            {
                Author_id = author_id,
                Fact_address = fact_address,
                Fact_postal = fact_postal,
                Fact_country = fact_country,
                Balance = balance,
                Card_id = card_id
            };
            return authorFacturationBL.AuthorFacturationAdd(authorFacturation);
        }

        [WebMethod(Description = "Obtener informacion de facturacion del usuario - UserSettings")]
        public DataTable FactInfo(string codUser)
        {
            AuthorFacturationBL authorFacturationBL = new AuthorFacturationBL();
            DataRow dr = authorFacturationBL.FactInfo(codUser);
            DataTable dt = new DataTable();
            dt.ImportRow(dr);
            return dt;
        }

        [WebMethod(Description = "Estado de facturacion - UserSettings")]
        public bool FactStatus(string codUser)
        {
            AuthorFacturationBL authorFacturationBL = new AuthorFacturationBL();
            return authorFacturationBL.FactStatus(codUser);
        }

        [WebMethod(Description = "Estado de balance de cuenta - UserSettings | Dashboard")]
        public float FacturationBalance(string codUser)
        {
            AuthorFacturationBL authorFacturationBL = new AuthorFacturationBL();
            return float.Parse(authorFacturationBL.FacturationBalance(codUser));
        }

        [WebMethod(Description = "Cambiar disponibilidad de aceptacion de comisiones - UserSettings | Dashboard")]
        public bool FacturationCommisionOpens(string codUser)
        {
            AuthorFacturationBL authorFacturationBL = new AuthorFacturationBL();
            return authorFacturationBL.FacturationCommisionOpens(codUser);
        }

        [WebMethod(Description = "Actualizar info de facturacion - UserSettings")]
        public bool FacturationInfoUpdate(string codUser)
        {
            AuthorFacturationBL authorFacturationBL = new AuthorFacturationBL();
            // TODO
            //return authorFacturationBL.FacturationInfoUpdate(codUser);
            return false;
        }
        #endregion

        #region WEB SERVICE TAGS METHODS
        [WebMethod(Description = "Obtener etiquetas preferidas del usuario - UserProfile")]
        public DataTable GetPreferredTags(int coduser)
        {
            TagsBL tagsBL = new TagsBL();
            return tagsBL.GetPreferredTags(coduser);
        }

        [WebMethod(Description = "Obtener etiquetas de las publicaciones de un autor  - AuthorProfile")]
        public DataTable GetIllustsAuthorTags(int coduser)
        {
            TagsBL tagsBL = new TagsBL();
            return tagsBL.GetIllustsAuthorTags(coduser);
        }

        [WebMethod(Description = "Editar etiquetas de una ilustracion  - IllustPage")]
        public bool EditIllustsTags(int illustId, int codUser, string operation = "ADD")
        {
            // operation : ADD (default) || REMOVE
            TagsBL tagsBL = new TagsBL();
            return tagsBL.EditIllustsTags(illustId, codUser, operation);
        }
        #endregion

        #region WEB SERVICE ALBUM METHODS

        [WebMethod(Description = "Obtener lista de albumes de un usuario o autor  - AuthorProfile")]
        public DataTable GetAlbumList(string coduser, string usertype)
        {
            AlbumBL albumBL = new AlbumBL();
            return albumBL.GetAlbumList(coduser, usertype);
        }

        [WebMethod(Description = "Obtener ilustraciones de un album  - AlbumPopOut")]
        public DataTable GetAlbumIllustInfo(string codalbum)
        {
            AlbumBL albumBL = new AlbumBL();
            return albumBL.GetAlbumIllustInfo(codalbum);
        }

        [WebMethod(Description = "Crear nuevo album  - UserProfile")]
        public void AddNewAlbum(int owner_id, string album_name)
        {
            AlbumBL albumBL = new AlbumBL();
            Album album = new Album { Album_name = album_name, Owner_id = owner_id, Public_status = 0 };
            // 0 : public (default) || 1 : private (on edit)

            albumBL.AddNewAlbum(album);
            // volver a listar albumes despues de crear
        }

        [WebMethod(Description = "Eliminar album  - UserProfile")]
        public void DeleteAlbum(string album_id, string owner_id)
        {
            AlbumBL albumBL = new AlbumBL();
            albumBL.DeleteAlbum(album_id, owner_id);
            // volver a listar albumes despues de eliminar
        }

        [WebMethod(Description = "Editar album - solo se permite el nombre  - UserProfile")]
        public void EditAlbum(string album_id, string owner_id, string album_name)
        {
            AlbumBL albumBL = new AlbumBL();
            albumBL.EditAlbum(album_id, owner_id, album_name);
            // volver a listar albumes despues de editar
        }

        [WebMethod(Description = "Editar album public - UserProfile")]
        public void EditAlbumPublic(string album_id, string owner_id)
        {
            AlbumBL albumBL = new AlbumBL();
            albumBL.EditAlbumPublic(album_id, owner_id);
            // volver a listar albumes despues de editar
        }

        // METODOS DE ALBUMILLUSTBL
        [WebMethod(Description = "Agregar ilustracion a un album - IllustPage || UserProfile")]
        public bool AddNewIllustAlbum(int album_id, int illust_id, string coduser)
        {
            /*
                si esta en IllustPage
                    puede agregar la ilustracion a un album x, pero esta se
                    agrega a Favorites independientemente.
                si esta en UserProfile
                    puede mover ilustraciones entre albumes
                    si el album es favorites, basicamente se crea una copia
                    y se mueve a otro album
                    si el album no es favorites, se mueve o copia la ilustracion
             */
            AlbumIllustBL albumillustBL = new AlbumIllustBL();
            AlbumIllust albumIllust = new AlbumIllust
            {
                Album_id = album_id,
                Illust_id = illust_id
            };
            return albumillustBL.AddNewIllustAlbum(coduser, albumIllust);
            // volver a listar ilustraciones de album despues de editar
        }
        [WebMethod(Description = "Eliminar ilustracion de un album - UserProfile")]
        public bool RemoveIllustAlbum(string album_id, string illust_id, string owner_id)
        {
            /*
                si el album es Favorites, pues se quita de sus favorites
                si el album es otro, se elimina de el
             */
            AlbumIllustBL albumillustBL = new AlbumIllustBL();
            return albumillustBL.RemoveIllustAlbum(album_id, illust_id, owner_id);
            // volver a listar albumes despues de editar
        }
        #endregion

        #region WEB SERVICE REQUESTS METHODS
        [WebMethod(Description = "Lista de requests aceptadas por el usuario - IllustPublish")]
        public DataTable AcceptedRequestsList(int codUser)
        {
            RequestBL requestBL = new RequestBL();
            return requestBL.AcceptedRequestsList(codUser);
        }

        [WebMethod(Description = "Finalizar Request - Requests")]
        public bool RequestFinish(int request_id, int illust_id)
        {
            RequestBL requestBL = new RequestBL();
            return requestBL.RequestFinish(request_id, illust_id);
        }

        [WebMethod(Description = "Listar las requests hacia el usuario - Requests")]
        public DataTable RequestsList(string codUser, string rec_type = "")
        {
            RequestBL requestBL = new RequestBL();
            if (rec_type.Equals("FROM"))
                return requestBL.RequestsList(codUser, "FROM");
            else // SELF
                return requestBL.RequestsList(codUser);
        }

        [WebMethod(Description = "Realizar pedido de Request - AuthorProfile")]
        public bool RequestSolitude(int authorid, string requester_comment, int requester_id)
        {
            RequestBL requestBL = new RequestBL();
            Request request = new Request
            {
                Author_id = authorid,
                Requester_comment = requester_comment
            };
            AuthorRequest authorRequest = new AuthorRequest
            {
                Requester_id = requester_id
            };
            return requestBL.RequestSolitude(request, authorRequest);
        }

        [WebMethod(Description = "Aceptar Request - Requests")]
        public bool RequestSolitudeAccept(int request_id)
        {
            RequestBL requestBL = new RequestBL();
            return requestBL.RequestSolitudeAccept(request_id);
        }

        [WebMethod(Description = "Rechazar Request - Requests")]
        public bool RequestSolitudeReject(int request_id)
        {
            RequestBL requestBL = new RequestBL();
            return requestBL.RequestSolitudeReject(request_id);
        }

        [WebMethod(Description = "Estado de requests - AuthorProfile")]
        public bool RequestsOpen(int author_id)
        {
            RequestBL requestBL = new RequestBL();
            return requestBL.RequestsOpen(author_id);
        }
        #endregion

        #region WEB SERVICE POSTS METHODS
        [WebMethod(Description = "Crear nuevo post - UserFeed")]
        public bool AddNewPost(int author_id, string post_content)
        {
            PostBL postBL = new PostBL();
            Post post = new Post
            {
                Author_id = author_id,
                Post_content = post_content
            };
            return postBL.AddNewPost(post);
        }
        [WebMethod(Description = "Listar posts de un usuario - AuthorProfile / AuthorFeed | UserProfile / UserFeed")]
        public DataTable GetPostList(int codUser)
        {
            PostBL postBL = new PostBL();
            return postBL.GetPostList(codUser);
        }
        [WebMethod(Description = "Listar posts de usuarios seguidos - Dashboard / PostFeed")]
        public DataTable GetSelfPostsList(int codUser)
        {
            PostBL postBL = new PostBL();
            return postBL.GetSelfPostsList(codUser);
        }

        [WebMethod(Description = "Eliminar Post - UserProfile / UserFeed")]
        public bool RemovePost(int post_id, int author_id)
        {
            PostBL postBL = new PostBL();
            return postBL.RemovePost(post_id, author_id);
        }
        #endregion

        #region WEB SERVICE COMMENTS METHODS
        [WebMethod(Description = "Agregar comentario a Illust o Post - IllustView | AuthorProfile / AuthorFeed")]
        public bool AddNewCommentOn(int author_id, bool is_response = false, int illust_id = 0, int post_id = 0, int parent_id = 0, int emoji_id = 0, string comment_content = "")
        {
            CommentBL commentBL = new CommentBL();
            Comments comments = new Comments
            {
                Illust_id = illust_id,
                Post_id = post_id,
                Author_id = author_id,
                Parent_id = parent_id,
                Emoji_id = emoji_id,
                Comment_content = comment_content
            };
            return commentBL.AddNewCommentOn(comments, is_response);
        }

        [WebMethod(Description = "Obtener comentarios de una illust o post - IllustView | AuthorProfile / AuthorFeed | UserProfile / UserFeed")]
        public DataTable GetCommentsFrom(string origin_id, string type_require)
        {
            // type :: ILLUST || POST
            CommentBL commentBL = new CommentBL();
            return commentBL.GetCommentsFrom(origin_id, type_require);
        }
        #endregion

        #region WEB SERVICE COMMISSION METHODS
        [WebMethod(Description = "Obtener lista de usuarios con comisiones abiertas - Dashboard / Commissions")]
        public DataTable CommissionDashboardArtistsList()
        {
            CommissionBL commissionBL = new CommissionBL();

            return commissionBL.CommissionDashboardArtistsList();
        }

        [WebMethod(Description = "Obtener lista de estado de comisiones de artistas seguidos - Dashboard / Commissions")]
        public DataTable CommissionDashboardFollowingList(string codUser)
        {
            CommissionBL commissionBL = new CommissionBL();

            return commissionBL.CommissionDashboardFollowingList(codUser);
        }

        [WebMethod(Description = "Obtiene lista de ilustraciones de comision recientes de usuarios seguidos - Dashboard / Commissions")]
        public DataTable CommissionDashboardFollowingRecents(string codUser)
        {
            CommissionBL commissionBL = new CommissionBL();

            return commissionBL.CommissionDashboardFollowingRecents(codUser);
        }

        [WebMethod(Description = "Obtiene lista de ilustraciones de comision recientes - Dashboard / Commissions")]
        public DataTable CommissionDashboardIllustsList()
        {
            CommissionBL commissionBL = new CommissionBL();

            return commissionBL.CommissionDashboardIllustsList();
        }

        [WebMethod(Description = "Obtiene lista de pedidos de comision del usuario - Commissions")]
        public DataTable GetCommissionRequestsList(string codUser)
        {
            CommissionBL commissionBL = new CommissionBL();

            return commissionBL.GetCommissionRequestsList(codUser);
        }

        [WebMethod(Description = "Obtiene lista comisiones pedidas al usuario - Commissions")]
        public DataTable GetCommissionsList(string codUser)
        {
            CommissionBL commissionBL = new CommissionBL();

            return commissionBL.GetCommissionsList(codUser);
        }

        [WebMethod(Description = "Muestra el estado de apertura de comisiones de un autor - AuthorProfile")]
        public bool IsCommissionActive(string author_id)
        {
            CommissionBL commissionBL = new CommissionBL();

            return commissionBL.IsCommissionActive(author_id);
        }

        [WebMethod(Description = "Permite pedir una comision a un artista - AuthorProfile / CommRequest")]
        public string RequestNewCommission(int author_id, string details, string deliver_date, string status, int commissioner_id)
        {
            CommissionBL commissionBL = new CommissionBL();
            Commission commission = new Commission
            {
                Author_id = author_id,
                Details = details,
                Deliver_date = deliver_date,
                Status = status,
                Commissioner_id = commissioner_id
            };
            return commissionBL.RequestNewCommission(commission);
        }

        [WebMethod(Description = "Terminar una comisión, se publica como illust y se marca que es de comisión")]
        public bool CommissionFinish(int comm_id, int illust_id = 0)
        {
            // no es obligatorio que ingrese id de illust
            // si es 0 entonces no hay illust
            CommissionBL commissionBL = new CommissionBL();
            return commissionBL.CommissionFinish(comm_id, illust_id);
        }

        [WebMethod(Description = "Rechazar pedido de comision - Commissions")]
        public bool CommissionReject(int comm_id)
        {
            CommissionBL commissionBL = new CommissionBL();
            return commissionBL.CommissionReject(comm_id);
        }

        [WebMethod(Description = "Aceptar pedido de comision - Commissions")]
        public bool CommissionAccept(int comm_id, int fact_id, float price)
        {
            // el fact_id debe estar en GetCommissionsList() al igual que el price
            CommissionBL commissionBL = new CommissionBL();
            CommissionDetail commissionDetail = new CommissionDetail
            {
                Comm_id = comm_id,
                Fact_id = fact_id,
                Price = price
            };
            return commissionBL.CommissionAccept(commissionDetail);
        }
        #endregion
    }
}
