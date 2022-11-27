<%@ Page Title="" Language="C#" MasterPageFile="~/MP.Master" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="TestingWebServices.Pages.Test" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Testing page
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">
    <form runat="server">
        <br />
        <div class="mx-auto" style="width: 300px">
            <h2>Testing Listado de Artowroks</h2>
        </div>
        <br />
        <div class="container">
            <div class="row">
                <div class="col align-self-end">
                    <asp:Button runat="server" ID="bntCreate" CssClass="btn btn-success form-control" Text="Create" />
                </div>
            </div>
        </div>
        <br />
        <div class="container row">
            <div class="table small">
                <asp:GridView ID="gvUsuarios" runat="server" class="table table-borderless table-hover">
                    <Columns>
                        <asp:TemplateField HeaderText="Administrator Options">
                            <ItemTemplate>
                                <asp:Button runat="server" Text="READ" CssClass="btn form-control-sm btn-info" ID="btnRead" />
                                <asp:Button runat="server" Text="UPDATE" CssClass="btn form-control-sm btn-warning" ID="btnUpdate" />
                                <asp:Button runat="server" Text="DELETE" CssClass="btn form-control-sm btn-danger" ID="btnDelete" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </form>
</asp:Content>
