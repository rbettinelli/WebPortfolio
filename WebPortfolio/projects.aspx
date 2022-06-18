<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="projects.aspx.cs" Inherits="WebPortfolio.projects" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Main" runat="server">

    <br />
     <asp:Repeater ID="Repeater1" runat="server">
        <ItemTemplate>

            <div class="card">
                <h4 class="card-header">Application : [<%# DataBinder.Eval(Container.DataItem, "APPName") %>]</h4>
                <div class="card-body">
                    <h6 class="card-title">Slogan : &quot;<%# DataBinder.Eval(Container.DataItem, "APPSlogan") %>&quot;</h6>
                    <hr />
                    <div class="row">
                        <div class="col">
                            <asp:Repeater ID="Repeater2" runat="server">
                                <ItemTemplate>
                                    <asp:Image runat="server" ImageUrl='<%# Bind("imagefile","~/images/apppics/{0}") %>' ID="img" Width="75"></asp:Image>
                                    <br />
                                </ItemTemplate>
                            </asp:Repeater>
                        </div>
                        <div class="col">

                            <table class="table">
                                <tr>
                                    <td>Role</td>
                                    <td><%# DataBinder.Eval(Container.DataItem, "APPRole") %></td>
                                </tr>
                                 <tr>
                                    <td>Date</td>
                                    <td><%# DataBinder.Eval(Container.DataItem, "APPDate", "{0:d/M/yyyy}") %></td>
                                </tr>
                                 <tr>
                                    <td>GitHub</td>
                                    <td><a href='http://github.com/rbettinelli/<%# DataBinder.Eval(Container.DataItem, "gitHubLink") %>' target="_blank"><%# DataBinder.Eval(Container.DataItem, "gitHubLink") %></a></td>
                                </tr>
                                 <tr>
                                    <td>Language</td>
                                    <td><%# DataBinder.Eval(Container.DataItem, "APPBaseLanguage") %></td>
                                </tr>
                                 <tr>
                                    <td>Platform</td>
                                    <td><%# DataBinder.Eval(Container.DataItem, "APPPlatform") %></td>
                                </tr>
                                 <tr>
                                    <td>Desc</td>
                                    <td><%# DataBinder.Eval(Container.DataItem, "APPDesc") %></td>
                                </tr>
                                 <tr>
                                    <td>Tech</td>
                                    <td><%# DataBinder.Eval(Container.DataItem, "APPTech") %></td>
                                </tr>
                            </table>
                        </div>
                    </div>
                   
                    
                </div>
            </div>
            <br />
        </ItemTemplate>
    </asp:Repeater>
    <br />

</asp:Content>
