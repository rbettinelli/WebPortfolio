<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebPortfolio.index" %>

<asp:Content ID="Content2" ContentPlaceHolderID="Main" runat="server">

    <div class="card">
        <h5 class="card-header">My Bio!</h5>
        <div class="card-body">
            <div class="row">
                <div class="col-12 col-md-6">
                    <asp:Image ID="DevImage" runat="server" CssClass="img-fluid rounded" />
                </div>
                <div class="col-12 col-md-6">
                    <div class="row">
                        <div class="col mx-auto">
                            <asp:Label ID="LblBio" runat="server"></asp:Label>
                            <br />
                            <br />
                            <div style="font-size:xx-small;">**VIC-20 CODE**</div>
                            <asp:Image ID="V20" runat="server" CssClass="img-fluid rounded" src="images/V20-JJ.png" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <br />
</asp:Content>
