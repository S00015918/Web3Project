<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditPoster.aspx.cs" Inherits="WebProject.EditPoster" %>


<asp:Content ID="content1" ContentPlaceHolderID="MainContent" runat="server">

    <script type="text/javascript">
        
    </script>

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

     <style runat="server">
        .padBtns
        {
           padding-bottom:10px;
           padding-top:10px;
        }
    </style>


   <h1>Upload poster</h1>


    <div>
    <asp:FileUpload name="posterUpload" CssClass="btn btn-primary" ID="posterUpload" runat="server" accept=".jpg, .png"/>
    </div></br>

    <div class="padBtns">
     <asp:Button text="Upload image" ID="btnUploadImage" runat="server" CssClass="btn btn-primary btn-md" name="btnUploadImage" OnClick="btnUploadImage_Clicked"/>
    </div>
    <div class="padBtns">
    <asp:Label ID="outputLabel" runat="server"/>
    </div>

    
    <h1>Edit Poster</h1>

    <div class="img-thumbnail">
    <asp:Image ImageUrl="~/Images/placeholder.png" id="imageDisplay" CssClass="img-responsive" height="500" Width="800" runat="server"/> 
    </div>

   
    
    <h3>Image Filters</h3>
    <div id="FilterDiv" class="panel panel-primary">
    <asp:RadioButtonList id="filterList" OnSelectedIndexChanged="filterListFinal_SelectedIndexChanged" runat="server">
        <asp:ListItem Value="9" Selected="True">No Filter</asp:ListItem> 
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
    <div class="panel panel-primary">
    <asp:RadioButtonList runat="server" ID="sizeList" OnSelectedIndexChanged="sizeListFinal_SelectedIndexChanged">
        <asp:ListItem Value="1">A3</asp:ListItem>
        <asp:ListItem Value="3">A2</asp:ListItem>
        <asp:ListItem Value="4">A1</asp:ListItem>
        <asp:ListItem Value="2">Movie</asp:ListItem>
    </asp:RadioButtonList>
    </div>

    <h3>Poster Border</h3>
    <div class="panel panel-primary">
        <asp:RadioButtonList runat="server" ID="borderList" OnSelectedIndexChanged="borderList_SelectedIndexChanged">
            <asp:ListItem Value="1">No Border</asp:ListItem>
            <asp:ListItem Value="2">Circular</asp:ListItem>
            <asp:ListItem Value="3">White Border</asp:ListItem>
            <asp:ListItem Value="4">Round Corners</asp:ListItem>
        </asp:RadioButtonList>
    </div>

    <asp:Label runat="server" ID="lblSize"></asp:Label>
    <asp:Label runat="server" ID="lblBorder"></asp:Label>

    <asp:Button Text="Apply Changes" runat="server" CssClass="btn" name="btnApplyChanges" OnClick="btnApplyChanges_Click" />
    <asp:Button Text="Add To Cart" runat="server" CssClass="btn" name="btnAddToCart" OnClick="Unnamed_Click" />


</asp:Content>