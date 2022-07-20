<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="projects.aspx.cs" Inherits="WebPortfolio.Projects" %>

<asp:Content ID="Content2" ContentPlaceHolderID="Main" runat="server">
    <asp:Repeater ID="Repeater1" runat="server">
        <ItemTemplate>
            <div class="card">
                <h4 class="card-header">Application : [<%# DataBinder.Eval(Container.DataItem, "APPName") %>]</h4>
                <div class="card-body">
                    <h6 class="card-title">Slogan : &quot;<%# DataBinder.Eval(Container.DataItem, "APPSlogan") %>&quot;</h6>
                    <hr />
                    <div class="row">
                        <div class="col-12">
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
                                    <td>About / Process</td>
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
    <div class="row">
        <asp:Repeater ID="Repeater2" runat="server" OnItemDataBound="Rptr_ItemDataBound">
            <ItemTemplate>
                <div class="col-12 col-md-4 col-lg-3 col-xl-2" style="padding: 5px 5px;">
                    <div class="card mx-auto h-100">
                        <div class="card-body" style="text-align: center;">

                            <asp:Image ID="Image1" runat="server" ImageUrl='<%# DataBinder.Eval(Container.DataItem, "imagefile") %>' CssClass="img-fluid rounded" />
                            <asp:Panel ID="Panel1" runat="server">
                                <br />
                                <br />
                                <br />
                                <a href='<%# DataBinder.Eval(Container.DataItem, "Link") %>' target="_blank" class="btn btn-warning">
                                    <img src="images/Film.jpg" class="img-fluid rounded" /><br />
                                    <br />
                                    Video!</a>
                            </asp:Panel>
                        </div>
                        <div class="card-footer" style="text-align: center;">
                            <asp:Label ID="LblData" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "FileDesc") %>' ReadOnly="True" CssClass="text-wrap"></asp:Label>
                        </div>
                    </div>
                </div>

            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>
