<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="LoLQueen.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>LoL Queen</title>
		 <link rel="shortcut icon" type="image/x-icon" href="/favicon.ico">
  		<link rel="icon" href="images/logoletters.ico" type="image/x-icon">

		<meta charset="utf-8">
		<meta name="viewport" content="width=device-width, initial-scale=1.0">
		<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
		

		<!-- custom css -->
		<link rel="stylesheet" type="text/css" href="css/indexStylesheet.css">

		<!-- Latest compiled and minified CSS -->
		<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous">
		<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
	<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
	<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
	<script src="js/pageFunctionality.js"></script>


		<!-- Optional theme -->
		<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap-theme.min.css" integrity="sha384-rHyoN1iRsVXV4nD0JutlnGaslCJuC7uwjduW9SVrLvRYooPp2bWYgmgJQIXwl/Sp" crossorigin="anonymous">

		<style type="text/css">
			.carousel-inner img 
			{
		      width: 100%;
		      height: 100%;
	  		}
		</style>
		</head>
<body>
    <!-- Navigation -->
<nav class="navbar navbar-default" role="navigation">
  <div class="container-fluid" style="background-color:#071D49">
    <!-- Brand and toggle get grouped for better mobile display -->
    <div class="navbar-header" >
      <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1" >
        <span class="sr-only">Toggle navigation</span>
        <span class="icon-bar"></span>
        <span class="icon-bar"></span>
        <span class="icon-bar"></span>
      </button>
      <a class="navbar-brand"><img id="headerlogo" src="images/logoletters.ico"  alt="logo" height="30" width="30"></a>
    </div>
       <form class="navbar-form navbar-left" role="search">
        <div class="form-group">
          <input id="searchBar" type="text" class="form-control" placeholder="Search">
        </div>
        <button type="button" class="btn btn-default"  onClick="searchFunction()">Submit</button>
      </form>
    </div><!-- /.navbar-collapse -->
  </div><!-- /.container-fluid -->
</nav>
    <!--Banner-->
<div class="main-wrapper">
<div class="carousel slide"  data-ride="carousel" id="main-carousel">
	<!-- Indicators -->
  <ol class="carousel-indicators">
    <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
    <li data-target="#myCarousel" data-slide-to="1"></li>
    <li data-target="#myCarousel" data-slide-to="2"></li>
  </ol>
    <!-- Slides -->
    <div id="bannerContainer" class="carousel-inner" role="listbox">
        <div id="bannerImg1" class="item active">
       
        </div>
        <div id="bannerImg2" class="item">
     
        </div>
        <div id="bannerImg3" class="item">
       
        </div>
    </div>

    <div >
    <form id="form1" runat="server" class="col-sm-12">
    <div class="form-group col-sm-4 col-sm-offset-4">
    	<h1 class="text-center">LoL Queen</h1>
      <div class="input-group input-group-lg center-block">
          <asp:TextBox ID="SummonerName" class="form-control" runat="server"></asp:TextBox>
          <asp:Button ID="Button1" type="button" class="btn btn-default" runat="server" Text="Search" OnClick="SubmitSummonerName"/>
      </div>
    </div>
        <p>
         Summoner Name:
         <asp:Label ID="summonerNameLabel" runat="server" Text=""></asp:Label>
        </p>
         <p>
            Summoner Level:
            <asp:Label ID="summonerLevelLabel" runat="server" Text=""></asp:Label>
        </p>
        <p>
            Summoner ID:
            <asp:Label ID="summonerAccIdLabel" runat="server" Text=""></asp:Label>
        </p>
        <asp:Button ID="Button2" runat="server" OnClick="RedirectOW" Text="OverWatch" />
         </i></span>
      </div>
  </form>
</div>

    <!-- Controls -->
    <a class="left carousel-control" href="#main-carousel" role="button" data-slide="prev">
        <span class="fa fa-arrow-left"></span>
    </a>
    <a class="right carousel-control"  href="#main-carousel" role="button" data-slide="next">
        <span class="fa fa-arrow-right"></span>
    </a>

</div>
    </div>
</body>
</html>
