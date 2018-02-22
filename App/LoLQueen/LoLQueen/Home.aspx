<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="LoLQueen.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>LoL Queen</title>
		 <link rel="shortcut icon" type="image/x-icon" href="/favicon.ico">
  		<link rel="icon" href="images/league-logo.ico" type="image/x-icon">

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
    <?php include 'ChIDToName.php'?>


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
      <a class="navbar-brand"><img id="headerlogo" src="images/league-logo.ico"  alt="logo" height="30" width="30"></a>
    </div>
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
          <asp:TextBox ID="SummonerName" class="form-control" runat="server" Placeholder="Enter Summoner Name"></asp:TextBox>
          <asp:DropDownList ID="RegionList" runat="server">
                <asp:ListItem Value="EUW"></asp:ListItem>
                <asp:ListItem Value="EUNW"></asp:ListItem>
                <asp:ListItem Value="NA"></asp:ListItem>
                <asp:ListItem Value="OCE"></asp:ListItem>
                <asp:ListItem Value="KOR"></asp:ListItem>
                <asp:ListItem Value="RU"></asp:ListItem>
                <asp:ListItem Value="JP"></asp:ListItem>
                <asp:ListItem Value="BR"></asp:ListItem>
            </asp:DropDownList>
          <asp:Button ID="Button1" type="button" class="btn btn-default" runat="server" Text="Search" OnClick="SubmitSummonerName"/>
          <asp:Button ID="Button3" type="button" class="btn btn-default" runat="server" Text="Search Live Game" OnClick="SubmitSummonerName"/>
      </div>
    </div>
        <p>
         Summoner Name:
         <asp:Label ID="summonerNameLabel" runat="server" Text=""></asp:Label>
         <p>
            Summoner Level:
            <asp:Label ID="summonerLevelLabel" runat="server" Text=""></asp:Label>
        </p>
        <p>
            Summoner ID:
            <asp:Label ID="summonerAccIdLabel" runat="server" Text=""></asp:Label>
        </p>
            <p>
            Total Games:
            <asp:Label ID="TotalGamesLabel" runat="server" Text=""></asp:Label>
                 <p>
            Summoner ImageID:
            <asp:Label ID="SummonerImg" Text="" runat="server"/>
                </p>
                <p>
            User Game Status:
            <asp:Label ID="UserGameStatusLabel" Text="" runat="server"/>
                </p>
        <asp:Button ID="Button2" runat="server" OnClick="RedirectOw" Text="OverWatch" />
         </i></span>
                 <asp:Image ID="ChampionImg" ImageUrl="GetSummonerImg.imgid" runat="server" />
      </div>
    <section>          
    <div class="container">
        <div class="row">
        <div class="col">
            <div class="card"">
            <div class="card-body">
                <h1>Match History</h1>
                <br>
                <div class="show-reviews">
                    <table class="table table-bordered table-condensed">
            		<thead>
                		<tr align="left">
							<th>Lane:</th>
                   			<th>Role:</th>
                            <th>Vision Score:</th>
                            <th>Champion:</th>
                            <th>KDA</th>
                            <th>Damage Dealt to Objectives</th>
                            <th>Total Damage Dealt to Champions</th>
                            <th>Total Damage Taken</th>
                            <th>Items</th>
                		</tr>
           		   </thead>           
           	        <tbody>
                    <tr>
                    <td><asp:Label ID="LaneLabel" runat="server" Text=""></asp:Label></td>
                     <td><asp:Label ID="SummonerRoleLabel" runat="server" Text=""></asp:Label></td>
                     <td><asp:Label ID="VisionScoreLabel" runat="server" Text=""></asp:Label></td>
                     <td><asp:Label ID="ChampionLabel" runat="server" Text=""></asp:Label></td>
                      <td> <asp:Label ID="KillsLabel" runat="server" Text=""></asp:Label>
                        <asp:Label ID="DeathsLabel" runat="server" Text=""></asp:Label>
                        <asp:Label ID="AssistsLabel" runat="server" Text=""></asp:Label></td>
                       <td><asp:Label ID="DamageDealtToObjectivesLabel" runat="server" Text=""></asp:Label></td>
                       <td><asp:Label ID="TotalDamageDealtToChampionsLabel" runat="server" Text=""></asp:Label></td>
                      <td><asp:Label ID="TotalDamageTakenLabel" runat="server" Text=""></asp:Label></td>
                       <td><asp:Label ID="Item1Label" runat="server" Text=""></asp:Label>
                         <asp:Label ID="Item2Label" runat="server" Text=""></asp:Label>
                         <asp:Label ID="Item3Label" runat="server" Text=""></asp:Label>
                         <asp:Label ID="Item4Label" runat="server" Text=""></asp:Label>
                         <asp:Label ID="Item5Label" runat="server" Text=""></asp:Label>
                         <asp:Label ID="Item6Label" runat="server" Text=""></asp:Label>
                         <asp:Label ID="Item7Label" runat="server" Text=""></asp:Label></td>
                    </tr>
                           <tr>
                               <td><asp:Label ID="LaneLabel1" runat="server" Text=""></asp:Label></td>
                     <td><asp:Label ID="SummonerRoleLabel1" runat="server" Text=""></asp:Label></td>
                     <td><asp:Label ID="VisionScoreLabel1" runat="server" Text=""></asp:Label></td>
                     <td><asp:Label ID="ChampionLabel1" runat="server" Text=""></asp:Label></td>
                      <td> <asp:Label ID="KillsLabel1" runat="server" Text=""></asp:Label>
                        <asp:Label ID="DeathsLabel1" runat="server" Text=""></asp:Label>
                        <asp:Label ID="AssistsLabel1" runat="server" Text=""></asp:Label></td>
                       <td><asp:Label ID="DamageDealtToObjectivesLabel1" runat="server" Text=""></asp:Label></td>
                       <td><asp:Label ID="TotalDamageDealtToChampionsLabel1" runat="server" Text=""></asp:Label></td>
                      <td><asp:Label ID="TotalDamageTakenLabel1" runat="server" Text=""></asp:Label></td>
                       <td><asp:Label ID="Item1Label1" runat="server" Text=""></asp:Label>
                         <asp:Label ID="Item2Label1" runat="server" Text=""></asp:Label>
                         <asp:Label ID="Item3Label1" runat="server" Text=""></asp:Label>
                         <asp:Label ID="Item4Label1" runat="server" Text=""></asp:Label>
                         <asp:Label ID="Item5Label1" runat="server" Text=""></asp:Label>
                         <asp:Label ID="Item6Label1" runat="server" Text=""></asp:Label>
                         <asp:Label ID="Item7Label1" runat="server" Text=""></asp:Label></td>
                           </tr>
                             <td><asp:Label ID="LaneLabel2" runat="server" Text=""></asp:Label></td>
                     <td><asp:Label ID="SummonerRoleLabel2" runat="server" Text=""></asp:Label></td>
                     <td><asp:Label ID="VisionScoreLabel2" runat="server" Text=""></asp:Label></td>
                     <td><asp:Label ID="ChampionLabel2" runat="server" Text=""></asp:Label></td>
                      <td> <asp:Label ID="KillsLabel2" runat="server" Text=""></asp:Label>
                        <asp:Label ID="DeathsLabel2" runat="server" Text=""></asp:Label>
                        <asp:Label ID="AssistsLabel2" runat="server" Text=""></asp:Label></td>
                       <td><asp:Label ID="DamageDealtToObjectivesLabel2" runat="server" Text=""></asp:Label></td>
                       <td><asp:Label ID="TotalDamageDealtToChampionsLabel2" runat="server" Text=""></asp:Label></td>
                      <td><asp:Label ID="TotalDamageTakenLabel2" runat="server" Text=""></asp:Label></td>
                       <td><asp:Label ID="Item1Label2" runat="server" Text=""></asp:Label>
                         <asp:Label ID="Item2Label2" runat="server" Text=""></asp:Label>
                         <asp:Label ID="Item3Label2" runat="server" Text=""></asp:Label>
                         <asp:Label ID="Item4Label2" runat="server" Text=""></asp:Label>
                         <asp:Label ID="Item5Label2" runat="server" Text=""></asp:Label>
                         <asp:Label ID="Item6Label2" runat="server" Text=""></asp:Label>
                         <asp:Label ID="Item7Label2" runat="server" Text=""></asp:Label></td>
                           </tr>
                           <tr>
                               <td><asp:Label ID="LaneLabel3" runat="server" Text=""></asp:Label></td>
                     <td><asp:Label ID="SummonerRoleLabel3" runat="server" Text=""></asp:Label></td>
                     <td><asp:Label ID="VisionScoreLabel3" runat="server" Text=""></asp:Label></td>
                     <td><asp:Label ID="ChampionLabel3" runat="server" Text=""></asp:Label></td>
                      <td> <asp:Label ID="KillsLabel3" runat="server" Text=""></asp:Label>
                        <asp:Label ID="DeathsLabel3" runat="server" Text=""></asp:Label>
                        <asp:Label ID="AssistsLabel3" runat="server" Text=""></asp:Label></td>
                       <td><asp:Label ID="DamageDealtToObjectivesLabel3" runat="server" Text=""></asp:Label></td>
                       <td><asp:Label ID="TotalDamageDealtToChampionsLabel3" runat="server" Text=""></asp:Label></td>
                      <td><asp:Label ID="TotalDamageTakenLabel3" runat="server" Text=""></asp:Label></td>
                       <td><asp:Label ID="Item1Label3" runat="server" Text=""></asp:Label>
                         <asp:Label ID="Item2Label3" runat="server" Text=""></asp:Label>
                         <asp:Label ID="Item3Label3" runat="server" Text=""></asp:Label>
                         <asp:Label ID="Item4Label3" runat="server" Text=""></asp:Label>
                         <asp:Label ID="Item5Label3" runat="server" Text=""></asp:Label>
                         <asp:Label ID="Item6Label3" runat="server" Text=""></asp:Label>
                         <asp:Label ID="Item7Label3" runat="server" Text=""></asp:Label></td>
                           </tr>

                           <tr>
                               <td><asp:Label ID="LaneLabel4" runat="server" Text=""></asp:Label></td>
                     <td><asp:Label ID="SummonerRoleLabel4" runat="server" Text=""></asp:Label></td>
                     <td><asp:Label ID="VisionScoreLabel4" runat="server" Text=""></asp:Label></td>
                     <td><asp:Label ID="ChampionLabel4" runat="server" Text=""></asp:Label></td>
                      <td> <asp:Label ID="KillsLabel4" runat="server" Text=""></asp:Label>
                        <asp:Label ID="DeathsLabel4" runat="server" Text=""></asp:Label>
                        <asp:Label ID="AssistsLabel4" runat="server" Text=""></asp:Label></td>
                       <td><asp:Label ID="DamageDealtToObjectivesLabel4" runat="server" Text=""></asp:Label></td>
                       <td><asp:Label ID="TotalDamageDealtToChampionsLabel4" runat="server" Text=""></asp:Label></td>
                      <td><asp:Label ID="TotalDamageTakenLabel4" runat="server" Text=""></asp:Label></td>
                       <td><asp:Label ID="Item1Label4" runat="server" Text=""></asp:Label>
                         <asp:Label ID="Item2Label4" runat="server" Text=""></asp:Label>
                         <asp:Label ID="Item3Label4" runat="server" Text=""></asp:Label>
                         <asp:Label ID="Item4Label4" runat="server" Text=""></asp:Label>
                         <asp:Label ID="Item5Label4" runat="server" Text=""></asp:Label>
                         <asp:Label ID="Item6Label4" runat="server" Text=""></asp:Label>
                         <asp:Label ID="Item7Label4" runat="server" Text=""></asp:Label></td>
                           </tr>
           	        </tbody>
        		  </table>
                </div>
            </div>
            </div>
            </div>
            </div>
        </div>
        </div>
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
