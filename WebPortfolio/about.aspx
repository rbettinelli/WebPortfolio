<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="about.aspx.cs" Inherits="WebPortfolio.about" %>

<asp:Content ID="Content2" ContentPlaceHolderID="Main" runat="server">
    <div class="container">
        <div class="card">
            <h2 class="card-header">Robert Bettinelli</h2>
            <div class="card-body">

                <h4>Employment</h4>
                <hr class="border-primary border-3 opacity-75" />
                <asp:Panel ID="emp" runat="server"></asp:Panel>
                <br />
                <h4>Education</h4>
                <hr class="border-primary border-3 opacity-75" />
                <asp:Panel ID="edu" runat="server"></asp:Panel>
                <br />

            </div>
        </div>
    </div>
</asp:Content>
