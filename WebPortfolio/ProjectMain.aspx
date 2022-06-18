<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="ProjectMain.aspx.cs" Inherits="WebPortfolio.ProjectMain" EnableEventValidation="false" %>


<asp:Content ID="Content2" ContentPlaceHolderID="Main" runat="server">

    <div class="card">
        <h5 class="card-header">Projects List</h5>
        <div class="card-body">

            <asp:GridView ID="GridView1" runat="server" CssClass="table" AutoGenerateColumns="False" Width="100%" OnRowDataBound="Grid_RowDataBound" OnSelectedIndexChanged="OnSelectedIndexChanged" >
                <Columns>
                    <asp:BoundField DataField="ID" HeaderText="ID"></asp:BoundField>
                    <asp:BoundField DataField="APPName" HeaderText="Application"></asp:BoundField>
                    <asp:TemplateField HeaderText="Date">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%# Bind("APPDate", "{0:d/M/yyyy}") %>' ID="Label1"></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Screen">
                        <ItemTemplate>
                            <asp:Image runat="server" ImageUrl='<%# Bind("imagefile","~/images/apppics/{0}") %>' ID="img" Width="75"></asp:Image>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:BoundField DataField="APPRole" HeaderText="Role"></asp:BoundField>
                </Columns>
            </asp:GridView>

        </div>
    </div>
    <br />
</asp:Content>