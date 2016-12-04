<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Checkout1.aspx.cs" Inherits="WebProject.Checkout1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <br />
    <br />
     <div class="form-horizontal">
        <h4>Shipping Details</h4>
        <hr />
        <asp:ValidationSummary runat="server" CssClass="text-danger" />
        <div class="form-group">
            <asp:Label runat="server" ID="lblFirstname" AssociatedControlID="Firstname" CssClass="col-md-2 control-label">Firstname</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Firstname" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Firstname"
                    CssClass="text-danger" ErrorMessage="The firstname field is required." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Surname" ID="lblSurname" CssClass="col-md-2 control-label">Surname</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Surname" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Surname"
                    CssClass="text-danger" ErrorMessage="The surname field is required." />
            </div>
        </div>

        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Email" CssClass="col-md-2 control-label">Email</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Email" CssClass="form-control" TextMode="Email" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Email"
                    CssClass="text-danger" ErrorMessage="The email field is required." />
            </div>
        </div>

        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Phone" CssClass="col-md-2 control-label">Phone Number</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Phone" CssClass="form-control" TextMode="Phone" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Email"
                    CssClass="text-danger" ErrorMessage="The Phone number field is required." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Address" CssClass="col-md-2 control-label">Address</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Address" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Address"
                    CssClass="text-danger" ErrorMessage="The address field is required." />
            </div>
        </div>

        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="City" CssClass="col-md-2 control-label">City</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="City" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="City"
                    CssClass="text-danger" Display="Dynamic" ErrorMessage="The city field is required." />
            </div>
        </div>

        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="County" CssClass="col-md-2 control-label">County</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="County" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="County"
                    CssClass="text-danger" ErrorMessage="The county field is required." />
            </div>
        </div>

         <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Postcode" CssClass="col-md-2 control-label">Post Code</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Postcode" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Postcode"
                    CssClass="text-danger" ErrorMessage="Your postcode is required." />
            </div>
        </div>

    </div>
    
    <div class="form-group">
        <div class="col-sm-offset-2 col-sm-10">
            <asp:Button ID="btnCheckOut" runat="server" Text="Continue Checkout" 
                CssClass="btn" OnClick="btnCheckOut_Click" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel Order" 
                CausesValidation="False" CssClass="btn" OnClick="btnCancel_Click" />
            <asp:Button ID="btnContinue" runat="server" Text="Continue Shopping" 
                CausesValidation="False" CssClass="btn" PostBackUrl="~/Order.aspx" />
        </div>
    </div>
    
</asp:Content>
