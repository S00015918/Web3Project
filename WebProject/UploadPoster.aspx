<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UploadPoster.aspx.cs" Inherits="WebProject.UploadPoster" %>


<asp:Content ID="content1" ContentPlaceHolderID="MainContent" runat="server">
    <style runat="server">
        .padBtns
        {
           padding-bottom:10px;
           padding-top:10px;
        }
    </style>


   <h1>Upload poster</h1>

    <div class="img-thumbnail">
    <asp:Image ImageUrl="~/Images/placeholder.png" id="imageDisplay" height="500" Width="800" runat="server"/> 
    </div>

    <div>
    <asp:FileUpload name="posterUpload" CssClass="btn btn-primary" ID="posterUpload" runat="server" accept=".jpg, .png"/>
    </div></br>

    <div class="padBtns">
     <asp:Button text="Upload image" ID="btnUploadImage" runat="server" CssClass="btn btn-primary btn-md" name="btnUploadImage" OnClick="btnUploadImage_Clicked"/>
    </div>
    <div class="padBtns">
    <asp:Label ID="outputLabel" runat="server"/>
    </div>

    <asp:Button Text="Edit poster" ID="btnEditPoster" runat="server" CssClass="btn btn-primary btn-md" name="btnEditPoster" OnClick="btnEditPoster_Click" />

</asp:Content>