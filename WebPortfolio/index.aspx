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
    </div>
    <br />

</asp:Content>
