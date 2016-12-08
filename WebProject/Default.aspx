<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebProject._Default" %>
<%@ MasterType VirtualPath="~/Site.Master" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Monster Posters</h1>

    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Preview Posters</h2>

        </div>


        <div id="myCarousel" class="carousel slide" data-ride="carousel">
            <!-- Indicators -->
            <ol class="carousel-indicators">
                <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
                <li data-target="#myCarousel" data-slide-to="1"></li>
                <li data-target="#myCarousel" data-slide-to="2"></li>
                <li data-target="#myCarousel" data-slide-to="3"></li>
            </ol>

            <!-- Wrapper for slides -->
            <div class="carousel-inner" role="listbox">
                <div class="item active">
                    <img src="Images/Products/LordOfWar.jpg" width="300" height="300" />
                </div>

                <div class="item">
                    <img src="Images/Products/Borat.jpg" width="300" height="300" />
                </div>

                <div class="item">
                    <img src="Images/Products/RockyV.jpg" width="300" height="300" />
                </div>

                <div class="item ">
                    <img src="Images/Products/TheMartian.jpg" width="300" height="300" />
                </div>
            </div>

            <!-- Left and right controls -->
            <a class="left carousel-control" href="#myCarousel" role="button" data-slide="prev">
                <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
                <span class="sr-only">Previous</span>
            </a>
            <a class="right carousel-control" href="#myCarousel" role="button" data-slide="next">
                <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
                <span class="sr-only">Next</span>
            </a>
        </div>
    </div>

    <div>

        <asp:SqlDataSource ID="dsProducts" runat="server" ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" SelectCommand="SELECT * FROM [Product]"></asp:SqlDataSource>

    </div>
    <br />
    <br />

    <!--ThumbNails here-->
    <div class="row">
        <asp:Repeater ID="Repeater1" runat="server" DataSourceID="dsProducts">
            <ItemTemplate>
                <div class="col-sm-4">
                        <div class="thumbnail text-center">
                            <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("ImageFile")%>' Height="300px" Width="250px" />
                            <div class="caption">
                                <h3>
                                    <asp:Label ID="lblPosterName" runat="server" Text='<%# Eval("ProductName")%>'></asp:Label></h3>
                                <p>
                                    <asp:Label ID="lblPosterPrice" runat="server" Text='<%# Eval("Price", "{0:c}")%>'></asp:Label>
                                </p>
                                <p><a href="#" class="btn btn-primary" id="addtoCart" onclick="AddToCart()" role="button">Add to cart</a> <a href="#" class="btn btn-default" role="button">Buy Now!</a></p>
                            </div>
                        </div>
                    </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>

    <!--End Thumbnails-->

</asp:Content>
