<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Admin_AddItemsPage.aspx.cs" Inherits="WebProject_PostersWorking.Admin_AddItemsPage" Title="%Admin%_Add Items." %>

<asp:Content runat="server" ID="Content1" ContentPlaceHolderID="MainContent">
    <h2><%: Title %>.</h2>

    <div class="form-horizontal">
        <h4>Add a Poster</h4>
        <hr />
        <asp:ValidationSummary runat="server" CssClass="text-danger" />
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="PosterID" CssClass="col-md-2 control-label">Poster ID</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="PosterID" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="PosterID"
                    CssClass="text-danger" ErrorMessage="The posterID field is required." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Postername" CssClass="col-md-2 control-label">Poster name</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Postername" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Postername"
                    CssClass="text-danger" ErrorMessage="The Postername field is required." />
            </div>
        </div>

        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Genre" CssClass="col-md-2 control-label">Genre</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Genre" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Genre"
                    CssClass="text-danger" ErrorMessage="The Genre field is required." />
            </div>
        </div>

        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Quantity" CssClass="col-md-2 control-label">Quantity</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Quantity" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Quantity"
                    CssClass="text-danger" ErrorMessage="The Quantity field is required." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Price" CssClass="col-md-2 control-label">Price</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Price" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Price"
                    CssClass="text-danger" ErrorMessage="The price field is required." />
            </div>
        </div>

        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="ImageUpload" CssClass="col-md-2 control-label">Upload Image</asp:Label>
            <div class="col-md-10">
                <asp:FileUpload runat="server" ID="ImageUpload" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="ImageUpload"
                    CssClass="text-danger" ErrorMessage="An image is required." />
            </div>
        </div>

        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="ddlImages" CssClass="col-md-2 control-label">Select Image</asp:Label>
            <div class="col-md-10">
                <asp:DropDownList ID="ddlImages" runat="server" AppendDataBoundItems="true" AutoPostBack="true" OnSelectedIndexChanged="FetchImage"></asp:DropDownList>
  
            </div>
        </div>

        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="posterImage" CssClass="col-md-2 control-label">Add Image</asp:Label>
            <div class="col-md-10">
                <asp:Image ID="posterImage" runat="server" Visible="true" Height="130px" Width="130px" />

            </div>
        </div>
    </div>

</asp:Content>




