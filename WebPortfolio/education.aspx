<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="education.aspx.cs" Inherits="WebPortfolio.education" %>

<asp:Content ID="Content2" ContentPlaceHolderID="Main" runat="server">
    <div class="row">
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <div class="col-md-6" style="padding: 5px 5px;">
                    <div class="card mx-auto h-100">
                        <h4 class="card-header">School : [<%# DataBinder.Eval(Container.DataItem, "EmpComp") %>]</h4>
                        <div class="card-body">
                            <div class="row">
                                <div class="col-12">
                                    <table class="table">
                                        <tr>
                                            <td>Title</td>
                                            <td><%# DataBinder.Eval(Container.DataItem, "EmpTitle") %></td>
                                        </tr>
                                        <tr>
                                            <td>Span</td>
                                            <td><%# DataBinder.Eval(Container.DataItem, "EmpSpanDate") %></td>
                                        </tr>
                                        <tr>
                                            <td>Detail</td>
                                            <td><%# DataBinder.Eval(Container.DataItem, "EmpDetail") %>'</td>
                                        </tr>
                                        <tr>
                                            <td>Address</td>
                                            <td><%# DataBinder.Eval(Container.DataItem, "EmpAddress") %></td>
                                        </tr>
                                        <tr>
                                            <td>Web</td>
                                            <td><a href='<%# DataBinder.Eval(Container.DataItem, "EmpWeb") %>'><%# DataBinder.Eval(Container.DataItem, "EmpWeb") %></a></td>
                                        </tr>
                                    </table>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <br />
            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>
