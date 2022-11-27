<%@ Page Title="" Language="C#" MasterPageFile="~/MP.Master" AutoEventWireup="true" CodeBehind="frmRegister.aspx.cs" Inherits="TestingWebServices.Pages.frmRegister" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Register or Add new User
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">

    <div id="content">
        <div class="container background-white">
            <div class="row margin-vert-30">
                <!-- Register Box -->
                <div class="col-md-6 col-md-offset-3 col-sm-offset-3">
                    <form class="signup-page" runat="server">
                        <div class="signup-header">
                            <h2>Register a new account</h2>
                            <p>
                                Already a member? Click
                                <a href="frmLogin.aspx">HERE </a>to login to your account.
                            </p>
                        </div>

                        <label>ID Author</label>
                        <asp:TextBox ID="txtIdAuthor" runat="server" class="form-control margin-bottom-20" required="" placeholder="ej. 1234"></asp:TextBox>

                        <label>Nick Name</label>
                        <asp:TextBox ID="txtNickName" runat="server" class="form-control margin-bottom-20" required="" placeholder="ej. Alias"></asp:TextBox>

                        <label>Account Name</label>
                        <asp:TextBox ID="txtAccountName" runat="server" class="form-control margin-bottom-20" required="" placeholder="ej. Rigo123"></asp:TextBox>

                        <label>Fecha de Nacimiento</label>
                        <asp:TextBox ID="txtBirthDate" runat="server" class="form-control margin-bottom-20" required=""></asp:TextBox>

                        <label>Country</label>
                        <asp:TextBox ID="txtCountry" runat="server" class="form-control margin-bottom-20" required="" placeholder="ej. Peru..."></asp:TextBox>

                        <label>
                            Email Address
                                    <span class="color-red">*</span>
                        </label>
                        <asp:TextBox ID="txtEmail" runat="server" class="form-control margin-bottom-20" required="" placeholder="ej. alex@gmail.com"></asp:TextBox>

                        <div class="row">
                            <div class="col-sm-6">
                                <label>
                                    Password
                                            <span class="color-red">*</span>
                                </label>
                                <asp:TextBox ID="txtClave" runat="server" class="form-control margin-bottom-20" required="" TextMode="Password" placeholder="Password"></asp:TextBox>
                            </div>
                            <div class="col-sm-6">
                                <label>
                                    Confirm Password
                                            <span class="color-red">*</span>
                                </label>
                                <asp:TextBox ID="tbClave2" runat="server" class="form-control margin-bottom-20" required="" TextMode="Password" placeholder="Repeat Password"></asp:TextBox>
                            </div>
                        </div>

                        <hr>
                        <asp:Label runat="server" CssClass="alert-danger" ID="lblError"></asp:Label>
                        <div class="row">

                            <div class="col-lg-6">
                                <label class="checkbox">
                                    <asp:CheckBox ID="cbxConfirm" runat="server" />I read the
                                            <a href="#">Terms and Conditions</a>
                                </label>
                            </div>

                            <div class="col-lg-6 text-right">
                                <asp:Button runat="server" Text="Completar Registro" class="btn btn-primary" OnClick="btnAgregarUsuario" />
                            </div>

                        </div>
                    </form>
                </div>
                <!-- End Register Box -->
            </div>
        </div>
    </div>
</asp:Content>
