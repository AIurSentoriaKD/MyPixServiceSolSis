<%@ Page Title="" Language="C#" MasterPageFile="~/MP.Master" AutoEventWireup="true" CodeBehind="frmRegister.aspx.cs" Inherits="TestingWebServices.Pages.frmRegister" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Register or Add new User
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">
    <%--Maybe use a form without master page--%>
    <form id="FrmRegistro" runat="server">
        <div class="container d-flex justify-content-center">
            <div class="col-8">
                <div class="form-control card card-body">
                    <div class="row justify-content-center">
                        <asp:Label runat="server" CssClass="row justify-content-center h3">Registro de Autores</asp:Label>
                    </div>
                    <fieldset>
                        <legend class="row justify-content-center">Datos personales</legend>
                        <div class="input-group">
                            <asp:Label ID="Label7" CssClass="form-control" runat="server" Text="ID Author"></asp:Label>
                            <asp:TextBox ID="txtIdAuthor" CssClass="form-control" runat="server" placeholder="ej. 1234"></asp:TextBox>
                        </div>
                        <br />
                        <div class="input-group">
                            <asp:Label ID="Label1" CssClass="form-control" runat="server" Text="NickName"></asp:Label>
                            <asp:TextBox ID="txtNickName" CssClass="form-control" runat="server" placeholder="ej. Alias"></asp:TextBox>
                        </div>
                        <br />
                        <div class="input-group">
                            <asp:Label ID="Label2" CssClass="form-control" runat="server" Text="AccountName"></asp:Label>
                            <asp:TextBox ID="txtAccountName" CssClass="form-control" runat="server" placeholder="ej. Alrigo123"></asp:TextBox>
                        </div>
                        <br />
                        <div class="input-group">
                            <asp:Label ID="Label3" CssClass="form-control" runat="server" Text="Fecha de Nacimiento"></asp:Label>
                            <asp:TextBox ID="txtBirthDate" CssClass="form-control" runat="server" ></asp:TextBox>
                        </div>
                        <br />
                        <div class="input-group">
                            <asp:Label ID="Label9" CssClass="form-control" runat="server" Text="Country:"></asp:Label>
                            <asp:TextBox ID="txtCountry" CssClass="form-control" runat="server" placeholder="ej. Peru..."></asp:TextBox>
                        </div>
                    </fieldset>
                    <br />
                    <fieldset>
                        <legend class="row justify-content-center">Datos de inicio de sesión</legend>
                        <div class="input-group">
                            <asp:Label ID="Label8" CssClass="form-control" runat="server" Text="Email:"></asp:Label>
                            <asp:TextBox ID="txtEmail" CssClass="form-control" runat="server" placeholder="ej. alex@gmail.com"></asp:TextBox>
                        </div>
                        <br />
                        <div class="input-group">
                            <asp:Label ID="Label5" CssClass="form-control" runat="server" Text="Clave:"></asp:Label>
                            <asp:TextBox ID="txtClave" CssClass="form-control" runat="server" TextMode="Password" placeholder="Password"></asp:TextBox>
                        </div>
                        <br />
                        <div class="input-group">
                            <asp:Label ID="Label6" CssClass="form-control" runat="server" Text="Repetir Clave:"></asp:Label>
                            <asp:TextBox ID="tbClave2" CssClass="form-control" runat="server" placeholder="Password Again" TextMode="Password"></asp:TextBox>
                        </div>
                    </fieldset>
                    <br />
                    <asp:Label runat="server" CssClass="alert-danger" ID="lblError"></asp:Label>
                    <br />
                    <div class="row">
                        <asp:Button runat="server" CssClass="form-control btn btn-success" Text="Completar Registro" OnClick="btnAgregarUsuario" />
                        <hr />
                        <asp:Button runat="server" CssClass="form-control btn btn-warning" Text="Cancelar" OnClick="btnCancelar" />
                    </div>
                </div>

            </div>
        </div>
    </form>
</asp:Content>
