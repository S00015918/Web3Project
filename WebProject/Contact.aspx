<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="WebProject.Contact" %>
<%@ MasterType VirtualPath="~/Site.Master" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Contact Monster Posters.</h3>
    <address>
        IT SLIGO<br />
        Ash Lane, Bellanode, Sligo<br />
        <abbr title="Phone">P:</abbr>
        087 1030 431
    </address>

    <address>
        <strong>Support:</strong>   <a href="mailto:Support@example.com">Jim's_Support@gmail.com</a><br />
        <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">Monster_Marketing@example.com</a>
    </address>
</asp:Content>
