﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Checkout2.aspx.cs" Inherits="WebProject.Checkout2" %>
<%@ MasterType VirtualPath="~/Site.Master" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <div class="form-horizontal">

        <h1>Shipping And Payment</h1>

        <h3>Shipping Method</h3>
        <div class="form-group">
            <label class="control-label col-sm-2">Choose one:</label>
            <div class="col-sm-10">
                <asp:RadioButtonList ID="rblShipping" runat="server">
                    <asp:ListItem Value="1" Selected="True">Courier Post</asp:ListItem>
                    <asp:ListItem Value="2">Express Post</asp:ListItem>
                    <asp:ListItem Value="3">International Service</asp:ListItem>
                </asp:RadioButtonList>
            </div>
        </div>

        <h3>Payment Information</h3>
        <div class="form-group">
            <label class="control-label col-sm-2">Card Type:</label>
            <div class="col-sm-5">
                <asp:DropDownList ID="ddlCardType" runat="server" CssClass="form-control">
                    <asp:ListItem Selected="True" Value="None">--Select a credit card--</asp:ListItem>
                    <asp:ListItem>VISA</asp:ListItem>
                    <asp:ListItem Value="MC">MasterCard</asp:ListItem>
                    <asp:ListItem Value="AMEX">American Express</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="col-sm-5">
                <asp:RequiredFieldValidator ID="rfvCardType" runat="server" ControlToValidate="ddlCardType"
                    Display="Dynamic" ErrorMessage="Required" InitialValue="None"
                    CssClass="text-danger"></asp:RequiredFieldValidator>
            </div>
        </div>

        <div class="form-group">
            <label class="control-label col-sm-2">Card number</label>
            <div class="col-sm-5">
                <asp:TextBox ID="txtCardNumber" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-sm-5">
                <asp:RequiredFieldValidator ID="rfvCardNumber" runat="server"
                    ErrorMessage="Required" CssClass="text-danger"
                    Display="Dynamic" ControlToValidate="txtCardNumber"></asp:RequiredFieldValidator>
            </div>
        </div>

        <div class="form-group">
            <label class="control-label col-sm-2">Expiration date:</label>
            <div class="col-sm-5">
                <asp:TextBox ID="txtExpiration" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-sm-5">
                <asp:RequiredFieldValidator ID="rfvExpiration" runat="server"
                    ErrorMessage="Required" CssClass="text-danger"
                    Display="Dynamic" ControlToValidate="txtExpiration"></asp:RequiredFieldValidator>
            </div>
        </div>

        <div class="form-group">
            <div class="col-sm-offset-2 col-sm-10">
                <asp:Button ID="btnAccept" runat="server" Text="Accept Order"
                    CssClass="btn" OnClick="btnAccept_Click" />
                <asp:Button ID="btnCancel" runat="server" Text="Cancel Order"
                    CausesValidation="False" CssClass="btn" OnClick="btnCancel_Click" />
                <asp:Button ID="btnContinue" runat="server" Text="Continue Shopping"
                    PostBackUrl="~/Order.aspx" CausesValidation="False" CssClass="btn" OnClick="btnContinue_Click" />
            </div>
        </div>
    </div>
</asp:Content>
