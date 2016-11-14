<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditPoster.aspx.cs" Inherits="WebProject.EditPoster" %>


<asp:Content ID="content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Upload Poster</h1>

    <asp:Image ImageUrl="~/Images/placeholder.png" id="imageDisplay" runat="server"/> 

   

    <asp:FileUpload name="posterUpload" CssClass="btn" ID="posterUpload" runat="server"/>

     <asp:Button text="Upload image" runat="server" CssClass="btn" name="btnUploadImage" OnClick="uploadImage_Click"/>
    
    <asp:Label ID="outputLabel" runat="server"/>

    <asp:CheckBoxList ID="filterList" OnSelectedIndexChanged="filterList_SelectedIndexChanged" runat="server">
        <asp:ListItem Value="1">Filter 1</asp:ListItem>
        <asp:ListItem Value="2">Filter 2</asp:ListItem>
         <asp:ListItem Value="3">Filter 3</asp:ListItem>
         <asp:ListItem Value="4">Filter 4</asp:ListItem>
         <asp:ListItem Value="5">Filter 5</asp:ListItem>
         <asp:ListItem Value="6">Filter 6</asp:ListItem>
         <asp:ListItem Value="7">Filter 7</asp:ListItem>
         <asp:ListItem Value="8">Filter 8</asp:ListItem>
    </asp:CheckBoxList>



</asp:Content>