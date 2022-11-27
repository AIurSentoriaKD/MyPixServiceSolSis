<%@ Page Title="" Language="C#" MasterPageFile="~/MP.Master" AutoEventWireup="true" CodeBehind="frmLogin.aspx.cs" Inherits="TestingWebServices.Pages.frmLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    User Login Page
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">
    <form id="FrmLogin" runat="server" class="container d-flex justify-content-center align-items-center">
        <div class="col-5">
            <div class="form-control card card-body align-items-center">
                <div class="modal-title align-content-center h3">
                    <asp:Label runat="server" Text="Inicio de sesión" Font-Size="Larger"></asp:Label>
                </div>
                <br />
                <div class="input-group">
                    <asp:TextBox runat="server" CssClass="form-control" placeholder="Email" ID="txtEmail"></asp:TextBox>
                </div>
                <br />
                <div class="input-group">
                    <asp:TextBox runat="server" CssClass="form-control" placeholder="Password" TextMode="Password" ID="txtPassword"></asp:TextBox>
                </div>
                <br />
                <div class="input-group">
                    <asp:Button runat="server" CssClass="form-control btn btn-dark" Text="LOG IN" OnClick="btnLogIn" ></asp:Button>
                </div>
                <br />
                <br />
                <div>
                    <asp:Label runat="server" ID="lblError" class="alert-danger"></asp:Label>
                    <br />
                    <asp:Label runat="server" Text="¿No tienes una cuenta?, Regístrate"></asp:Label>
                    <asp:LinkButton runat="server" Text=" aquí" OnClick="btnRegistrarse" ></asp:LinkButton>
                </div>
            </div>
        </div>
    </form>
</asp:Content>
