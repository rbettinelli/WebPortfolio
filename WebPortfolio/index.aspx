<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebPortfolio.index" %>

<asp:Content ID="Content2" ContentPlaceHolderID="Main" runat="server">

    <br />
    <div class="card">
        <h5 class="card-header">My Bio!</h5>
        <div class="card-body">
            <div class="row">
                <div class="col text-center">
                    <asp:Image ID="DevImage" runat="server" Style="width:80%;padding: 10px 10px 10px 10px;" />
                </div>
                <div class="col">
                    <asp:Label ID="LblBio" runat="server"></asp:Label>
                </div>
            </div>
        </div>
        <div class="card-footer bg-transparent border-success text-center">
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <a href='<%# DataBinder.Eval(Container.DataItem, "ProfileLink") %>'><%# DataBinder.Eval(Container.DataItem, "ProfileLink") %></a><br />
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
    <br />

</asp:Content>
