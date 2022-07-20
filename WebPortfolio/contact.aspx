<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="contact.aspx.cs" Inherits="WebPortfolio.contact" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Main" runat="server">

    <div class="row">
        <div class="col mxauto">
            <div class="card">
                <div class="card-header">
                    Contact me!
                </div>
                <div class="card-body">

                    <div class="container">
                        <div class="row">
                            <div class="col">
                            ** Have something to chat about? A question to ask? Do it here...<br /><br />
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <div class="form-floating mb-3">
                                    <asp:TextBox ID="TxtEmail" runat="server" CssClass="form-control" placeholder="name@example.com"></asp:TextBox>
                                    <label for="TxtEmail">Email address</label>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <div class="form-floating mb-3">
                                    <asp:TextBox ID="TxtName" runat="server" CssClass="form-control" placeholder="Your Name"></asp:TextBox>
                                    <label for="TxtName">Your Name</label>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <div class="form-floating mb-3">
                                    <asp:TextBox ID="TxtSubject" runat="server" CssClass="form-control" placeholder="Subject"></asp:TextBox>
                                    <label for="TxtSubject">Subject</label>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <div class="form-floating mb-3">
                                    <asp:TextBox ID="TxtDetail" runat="server" CssClass="form-control" placeholder="Detail"></asp:TextBox>
                                    <label for="TxtDetail">Detail</label>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col" style="text-align:right;">
                                <asp:Button ID="BtnSend" runat="server" Text="Send" CssClass="btn btn-warning btn-sm" />
                            </div>
                        </div>

                    </div>
                </div>
            </div>
            <br />
            <br />
        </div>
    </div>

</asp:Content>
