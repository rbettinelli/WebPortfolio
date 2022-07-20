<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="projectMain.aspx.cs" Inherits="WebPortfolio.projectMain" EnableEventValidation="false" %>

<asp:Content ID="Content2" ContentPlaceHolderID="Main" runat="server">
    <div class="card">
        <h5 class="card-header">Projects List</h5>
        <div class="card-body">
            <div class="row">
                <asp:Repeater runat="server" ID="Repeater1" OnItemCommand="OnSelectedIndexChanged">
                    <ItemTemplate>
                        <div class="col-12 col-md-4 col-lg-3 col-xl-2" style="padding: 5px 5px;">
                            <asp:LinkButton runat="server" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "ID") %>'>
                                <div class="card mx-auto h-100">
                                    <div class="card-body" style="text-align: center;">
                                        <asp:Image ID="Image1" runat="server" ImageUrl='<%# DataBinder.Eval(Container.DataItem, "imagefile") %>' CssClass="img-fluid rounded" />
                                    </div>
                                    <div class="card-footer" style="text-align: center;">
                                        <asp:Label ID="Label1" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "APPNAME") %>' CssClass="btn btn-light btn-sm"></asp:Label>
                                    </div>
                                </div>
                            </asp:LinkButton>
                            <br />
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
    </div>
</asp:Content>