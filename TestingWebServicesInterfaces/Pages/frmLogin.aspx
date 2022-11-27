<%@ Page Title="" Language="C#" MasterPageFile="~/MP.Master" AutoEventWireup="true" CodeBehind="frmLogin.aspx.cs" Inherits="TestingWebServices.Pages.frmLogin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    User Login Page
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">

    <div id="content">
        <div class="container background-white">
            <div class="container">
                <div class="row" style="padding: 25px;">
                    <div class="col-md-6">
                        <img src="../public/assets/img/artworks/19/large/102051931_p0_master1200.jpg" />
                    </div>
                    <div class="col-md-6">
                        <form class="login-page" runat="server">
                            <div class="login-header margin-bottom-30">
                                <h2>Login to your account</h2>
                            </div>
                            <div class="input-group margin-bottom-20">
                                <span class="input-group-addon">
                                    <i class="fa fa-user"></i>
                                </span>
                                <asp:TextBox ID="txtEmail" runat="server" class="form-control" required="" placeholder="Email"></asp:TextBox>
                            </div>
                            <div class="input-group margin-bottom-20">
                                <span class="input-group-addon">
                                    <i class="fa fa-lock"></i>
                                </span>
                                <asp:TextBox ID="txtPassword" TextMode="Password" runat="server" class="form-control" required="" placeholder="Password"></asp:TextBox>
                            </div>
                            <div class="row">
                                <%--<div class="col-md-6">
                                    <label class="checkbox">
                                        <asp:CheckBox ID="cbxStay" runat="server" />Stay signed in</label>
                                </div>--%>
                                <div class="col-md-8">
                                    <asp:Button ID="btnLogin" runat="server" Text="Login" class="btn btn-primary pull-center" OnClick="btnLogIn" />
                                    <br />
                                    <br />
                                </div>
                            </div>
                            <hr>
                            <asp:Label runat="server" ID="lblError" class="alert-danger"></asp:Label>
                            <h4>Forget your Password ?</h4>
                            <p>
                                <a href="#">Click here</a> to reset your password.
                            </p>
                            Don't have an account?<a href="frmRegister.aspx"> Register Here</a>
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
