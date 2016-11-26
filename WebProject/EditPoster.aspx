<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditPoster.aspx.cs" Inherits="WebProject.EditPoster" %>


<asp:Content ID="content1" ContentPlaceHolderID="MainContent" runat="server">

    <style runat="server">
            .image1
           {
            filter: blur(1px)
           }
           .image2
           {
            filter: contrast(2);
           }
           .image3
           {
            filter: invert(1);
           }
           .image4
           {
            filter: grayscale(100);
           }
           .image5
           {
            filter: brightness(0.5);
           }
           .image6
           {
            filter: hue-rotate(90deg);
           }
           .image7
           {
             filter:saturate(30%)
           }
           .image8
           {
               filter:sepia(60%);
           }
           .test
           {
               padding-bottom: 10px;
           }
    </style>


    <h1>Upload Poster</h1>

    <div class="img-thumbnail">
    <asp:Image ImageUrl="~/Images/placeholder.png" id="imageDisplay" height="500" Width="800" runat="server"/> 
    </div>

    <div>
    <asp:FileUpload name="posterUpload" CssClass="btn btn-primary" ID="posterUpload" runat="server" accept=".jpg, .png"/>
    </div></br>

    <div id="test" class="test">
     <asp:Button text="Upload image" ID="btnUpload" runat="server" CssClass="btn btn-primary btn-md" name="btnUploadImage" OnClick="uploadImage_Click"/>
    
    <asp:Label ID="outputLabel" runat="server"/>
    </div>
    
    <h3>Image Filters</h3>
    <div id="FilterDiv" class="panel panel-primary">
    <asp:RadioButtonList id="filterListFinal" OnSelectedIndexChanged="filterListFinal_SelectedIndexChanged" runat="server">
         <asp:ListItem Value="1">Blur</asp:ListItem>
        <asp:ListItem Value="2">Contrast</asp:ListItem>
         <asp:ListItem Value="3">Invert</asp:ListItem>
         <asp:ListItem Value="4">Grayscale</asp:ListItem>
         <asp:ListItem Value="5">Brightness</asp:ListItem>
         <asp:ListItem Value="6">Hue-Rotate</asp:ListItem>
         <asp:ListItem Value="7">Saturate</asp:ListItem>
         <asp:ListItem Value="8">Sepia</asp:ListItem>
    </asp:RadioButtonList>
    </div>

    <h3>Poster Size</h3>
    <div class="panel panel-default">
    <asp:RadioButtonList runat="server" ID="sizeListFinal" OnSelectedIndexChanged="sizeListFinal_SelectedIndexChanged">
        <asp:ListItem Value="1">A3</asp:ListItem>
        <asp:ListItem Value="3">A2</asp:ListItem>
        <asp:ListItem Value="4">A1</asp:ListItem>
        <asp:ListItem Value="2">Movie</asp:ListItem>
    </asp:RadioButtonList>
    </div>


    <asp:Button Text="Apply Changes" runat="server" CssClass="btn" name="btnApplyChanges" OnClick="btnApplyChanges_Click" />


</asp:Content>