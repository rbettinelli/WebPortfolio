<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="employment.aspx.cs" Inherits="WebPortfolio.employment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Main" runat="server">
    <br />
    <asp:Repeater ID="Repeater1" runat="server">
        <ItemTemplate>

            <div class="card">
                <h5 class="card-header"><%# DataBinder.Eval(Container.DataItem, "APPName") %></h5>
                <div class="card-body">
                    <h5 class="card-title"><%# DataBinder.Eval(Container.DataItem, "APPSlogan") %></h5>
                    <hr />
                    <div class="row">
                        <div class="col">
                            <asp:Image ID="Image1" runat="server" style="height:250px;"/>
                        </div>
                        <div class="col">
                            <%# DataBinder.Eval(Container.DataItem, "APPDesc") %>
                        </div>
                    </div>
                   
                    
                </div>
            </div>

        </ItemTemplate>
    </asp:Repeater>
    <br />
</asp:Content>
