﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="WebProject.Products" %>
<asp:Content ID="MainContent" ContentPlaceHolderID="mainPlaceholder" runat="server">

    <div class="row">
        <div class="col-sm-8">
            <div class="form-group">
                <label class="col-sm-6">Please select a product:</label>
                <div class="col-sm-6">
                    <asp:DropDownList ID="ddlProducts" runat="server" AutoPostBack="True" 
                        DataSourceID="dsProducts" DataTextField="ProductName" 
                        DataValueField="ProductID" CssClass="form-control">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="dsProducts" runat="server" 
                        ConnectionString='<%$ ConnectionStrings:DefaultConnection %>' 
                        SelectCommand="SELECT * FROM [Product] ORDER BY [ProductName]">
                    </asp:SqlDataSource>
                </div>
            </div>   
            <div class="form-group">
                <div class="col-sm-12"><h4><asp:Label ID="lblProductName" runat="server"></asp:Label></h4></div></div>

            <div class="form-group">
                <div class="col-sm-12"><asp:Label ID="lblUnitPrice" runat="server"></asp:Label></div></div>
        </div>
        <div class="col-sm-4">
            <asp:Image ID="imgProduct" runat="server" />
        </div>
    </div>
    <div class="row">
        <div class="col-sm-12">
            <div class="form-group">
                <label class="col-sm-2">Quantity:</label>
                <div class="col-sm-3">
                    <asp:TextBox ID="txtQuantity" runat="server" 
                        CssClass="form-control"></asp:TextBox></div>
                <div class="col-sm-7">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" CssClass="text-danger"
                        runat="server" ControlToValidate="txtQuantity" Display="Dynamic" 
                        ErrorMessage="Quantity is a required field."></asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="RangeValidator1" runat="server" CssClass="text-danger" 
                        ControlToValidate="txtQuantity" Display="Dynamic" 
                        ErrorMessage="Quantity must range from 1 to 500."
                        MaximumValue="500" MinimumValue="1" Type="Integer"></asp:RangeValidator></div>
            </div>

            <div class="form-group">
                <div class="col-sm-12">
                    <asp:Button ID="btnAdd" runat="server" Text="Add to Cart" 
                        onclick="btnAdd_Click" CssClass="btn" />
                    <asp:Button ID="btnCart" runat="server" Text="Go to Cart" 
                        PostBackUrl="~/Cart.aspx" CausesValidation="False" CssClass="btn" OnClick="btnCart_Click" />
                    <asp:Button ID="btnCheckOut" runat="server" Text="Check Out" 
                        PostBackUrl="~/CheckOut1.aspx" CausesValidation="False" CssClass="btn" OnClick="btnCheckOut_Click" />
                </div>
            </div>
        </div>
    </div>


</asp:Content>

