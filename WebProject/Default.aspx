<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebProject._Default" %>

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

     <!--ThumbNails here-->
    <div class="row">
        <div class="col-sm-6 col-md-3">
            <div id="thmN1" class="thumbnail">
                <asp:image CssClass="thumbnail-img" ID="Image1" runat="server"/>
                <div class="caption">
                    <h3>
                        <asp:Label ID="lblH3Img1" runat="server" Text=""></asp:Label></h3>
                    <p>
                        <asp:Label ID="lblParaImg1" runat="server" Text=""></asp:Label></p>
                    <p><a href="Details.html" class="btn btn-primary" role="button">Add to cart</a> <a href="#" class="btn btn-default" role="button">Buy Now!</a></p>
                </div>
            </div>
        </div>
        <div class="col-sm-6 col-md-3">
            <div class="thumbnail">
                <asp:image CssClass="thumbnail-img" ID="Image2" runat="server"/>
                <div class="caption">
                    <h3><asp:Label ID="lblH3Img2" runat="server" Text=""></asp:Label></h3>
                    <p>
                        <asp:Label ID="lblParaImg2" runat="server" Text="Label"></asp:Label></p>
                    <p><a href="Details.html" class="btn btn-primary" role="button">Add to cart</a> <a href="#" class="btn btn-default" role="button">Buy Now!</a></p>
                </div>
            </div>
        </div>
        <div class="col-sm-6 col-md-3">
            <div class="thumbnail">
                <asp:image CssClass="thumbnail-img" ID="Image3" runat="server" ImageUrl ="Default.aspx?ImageID=3"/>
                <div class="caption">
                    <h3>
                        <asp:Label ID="lblH3Img3" runat="server" Text="Label"></asp:Label></h3>
                    <p>
                        <asp:Label ID="lblParaImg3" runat="server" Text="Label"></asp:Label></p>
                    <p><a href="Details.html" class="btn btn-primary" role="button">Add to cart</a> <a href="#" class="btn btn-default" role="button">Buy Now!</a></p>
                </div>
            </div>
        </div>
        <div class="col-sm-6 col-md-3">
            <div class="thumbnail">
                <asp:image CssClass="thumbnail-img" ID="Image4" runat="server" ImageUrl ="LandingPage.aspx?ImageID=4"/>
                <div class="caption">
                    <h3>
                        <asp:Label ID="lblH3Img4" runat="server" Text="Label"></asp:Label></h3>
                    <p>
                        <asp:Label ID="lblParaImg4" runat="server" Text="Label"></asp:Label></p>
                    <p><a href="Details.html" class="btn btn-primary" role="button">Add to cart</a> <a href="#" class="btn btn-default" role="button">Buy Now!</a></p>
                </div>
            </div>
        </div>
        <div class="col-sm-6 col-md-3">
            <div class="thumbnail">
                <asp:image CssClass="thumbnail-img" ID="Image5" runat="server" ImageUrl ="LandingPage.aspx?ImageID=5"/>
                <div class="caption">
                    <h3>
                        <asp:Label ID="lblH3Img5" runat="server" Text="Label"></asp:Label></h3>
                    <p>
                        <asp:Label ID="lblParaImg5" runat="server" Text="Label"></asp:Label></p>
                    <p><a href="Details.html" class="btn btn-primary" role="button">Add to cart</a> <a href="#" class="btn btn-default" role="button">Buy Now!</a></p>
                </div>
            </div>
        </div>
        <div class="col-sm-6 col-md-3">
            <div class="thumbnail">
                <asp:image CssClass="thumbnail-img" ID="Image6" runat="server" ImageUrl ="LandingPage.aspx?ImageID=6"/>
                <div class="caption">
                    <h3>
                        <asp:Label ID="lblH3Img6" runat="server" Text="Label"></asp:Label></h3>
                    <p>
                        <asp:Label ID="lblParaImg6" runat="server" Text="Label"></asp:Label></p>
                    <p><a href="Details.html" class="btn btn-primary" role="button">Add to cart</a> <a href="#" class="btn btn-default" role="button">Buy Now!</a></p>
                </div>
            </div>
        </div>
        <div class="col-sm-6 col-md-3">
            <div class="thumbnail">
                <asp:image CssClass="thumbnail-img" ID="Image7" runat="server" ImageUrl ="LandingPage.aspx?ImageID=7"/>
                <div class="caption">
                    <h3>
                        <asp:Label ID="lblH3Img7" runat="server" Text="Label"></asp:Label></h3>
                    <p>
                        <asp:Label ID="lblParaImg7" runat="server" Text="Label"></asp:Label></p>
                    <p><a href="Details.html" class="btn btn-primary" role="button">Add to cart</a> <a href="#" class="btn btn-default" role="button">Buy Now!</a></p>
                </div>
            </div>
        </div>
        <div class="col-sm-6 col-md-3">
            <div class="thumbnail">
                <asp:image CssClass="thumbnail-img" ID="Image8" runat="server" ImageUrl ="LandingPage.aspx?ImageID=8"/>
                <div class="caption">
                    <h3>
                        <asp:Label ID="lblH3Img8" runat="server" Text="Label"></asp:Label>></h3>
                    <p>
                        <asp:Label ID="lblParaImg8" runat="server" Text="Label"></asp:Label></p>
                    <p><a href="Details.html" class="btn btn-primary" role="button">Add to cart</a> <a href="#" class="btn btn-default" role="button">Buy Now!</a></p>
                </div>
            </div>
        </div>
        <div class="col-sm-6 col-md-3">
            <div class="thumbnail">
                <asp:image CssClass="thumbnail-img" ID="Image9" runat="server" ImageUrl ="LandingPage.aspx?ImageID=9"/>
                <div class="caption">
                    <h3>
                        <asp:Label ID="lblH3Img9" runat="server" Text="Label"></asp:Label></h3>
                    <p>
                        <asp:Label ID="lblParaImg9" runat="server" Text="Label"></asp:Label></p>
                    <p><a href="#" class="btn btn-primary" role="button">Add to cart</a> <a href="#" class="btn btn-default" role="button">Buy Now!</a></p>
                </div>
            </div>
        </div>
        <div class="col-sm-6 col-md-3">
            <div class="thumbnail">
                <asp:image CssClass="thumbnail-img" ID="Image10" runat="server" ImageUrl ="LandingPage.aspx?ImageID=10"/>
                <div class="caption">
                    <h3>
                        <asp:Label ID="lblH3Img10" runat="server" Text="Label"></asp:Label></h3>
                    <p>
                        <asp:Label ID="lblParaImg10" runat="server" Text="Label"></asp:Label></p>
                    <p><a href="#" class="btn btn-primary" role="button">Add to cart</a> <a href="#" class="btn btn-default" role="button">Buy Now!</a></p>
                </div>
            </div>
        </div>
        <div class="col-sm-6 col-md-3">
            <div class="thumbnail">
                <asp:image CssClass="thumbnail-img" ID="Image11" runat="server" ImageUrl ="LandingPage.aspx?ImageID=11"/>
                <div class="caption">
                    <h3>
                        <asp:Label ID="lblH3Img11" runat="server" Text="Label"></asp:Label></h3>
                    <p>
                        <asp:Label ID="lblParaImg11" runat="server" Text="Label"></asp:Label></p>
                    <p><a href="#" class="btn btn-primary" role="button">Add to cart</a> <a href="#" class="btn btn-default" role="button">Buy Now!</a></p>
                </div>
            </div>
        </div>
        <div class="col-sm-6 col-md-3">
            <div class="thumbnail">
                <asp:image CssClass="thumbnail-img" ID="Image12" runat="server" ImageUrl ="LandingPage.aspx?ImageID=12"/>
                <div class="caption">
                    <h3>
                        <asp:Label ID="lblH3Img12" runat="server" Text="Label"></asp:Label></h3>
                    <p>
                        <asp:Label ID="lblParaImg12" runat="server" Text="Label"></asp:Label></p>
                    <p><a href="#" class="btn btn-primary" role="button">Add to cart</a> <a href="#" class="btn btn-default" role="button">Buy Now!</a></p>
                </div>
            </div>
        </div>
      </div>

    <!--End Thumbnails-->

</asp:Content>
