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
                                    <input type="email" class="form-control" id="floatingInput" placeholder="name@example.com" />
                                    <label for="floatingInput">Email address</label>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <div class="form-floating mb-3">
                                    <input type="text" class="form-control" id="floatingInput1" placeholder="Your Name" />
                                    <label for="floatingInput1">Your Name</label>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <div class="form-floating mb-3">
                                    <input type="text" class="form-control" id="floatingInput2" placeholder="Subject" />
                                    <label for="floatingInput2">Subject</label>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <div class="form-floating mb-3">
                                    <textarea class="form-control" placeholder="Detail" id="floatingTextarea"></textarea>
                                    <label for="floatingTextarea">Detail</label>
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
