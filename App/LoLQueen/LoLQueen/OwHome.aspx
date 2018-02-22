<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OwHome.aspx.cs" Inherits="LoLQueen.OwHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
      <link rel="shortcut icon" type="image/x-icon" href="/favicon.ico">
  		<link rel="icon" href="images/ow-logo.ico" type="image/x-icon">

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
  <div class="container-fluid" style="background-color:#f99e1a">
    <!-- Brand and toggle get grouped for better mobile display -->
    <div class="navbar-header" >
      <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1" >
        <span class="sr-only">Toggle navigation</span>
        <span class="icon-bar"></span>
        <span class="icon-bar"></span>
        <span class="icon-bar"></span>
      </button>
      <a class="navbar-brand"><img id="headerlogo" src="images/ow-logo.ico"  alt="logo" height="30" width="30"></a>
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
        <div id="bannerImg4" class="item active">
       
        </div>
        <div id="bannerImg5" class="item">
     
        </div>
        <div id="bannerImg6" class="item">
       
        </div>
    </div>

    <div >
    <form id="form1" runat="server" class="col-sm-12">
    <div class="form-group col-sm-4 col-sm-offset-4">
    	<h1 class="text-center">OverWatch</h1>
      <div class="input-group input-group-lg center-block">
          <asp:TextBox ID="HeroNameBox" class="form-control" runat="server" Placeholder="Enter Player Name"></asp:TextBox>
          <asp:TextBox ID="HeroTag" class="form-control" runat="server" Placeholder="Enter Battletag"></asp:TextBox>
          <asp:Button ID="Button3" type="button" class="btn btn-default" runat="server" Text="Get Hero Data" OnClick="DataGen" />
      </div>
    </div>
        <p>
         Hero Name:
         <asp:Label ID="HeroName" runat="server" Text=""></asp:Label>
        </p>
         <p>
            Hero Level:
            <asp:Label ID="HeroLevel" runat="server" Text=""></asp:Label>
        </p>
            QuickPlay Wins:
        <asp:Label ID="QuickWin" runat="server" Text=""></asp:Label>
        <p>
            Competitive Wins:
            <asp:Label ID="CompWin" runat="server" Text=""></asp:Label>

        </p>
        <asp:Button ID="Button1" runat="server" Text="LoLQueen" OnClick="RedirectToLoL" />
        <asp:Button ID="Button2" runat="server" Text="Home" OnClick="RedirectHome" />
         </div>
        <section>
        <div class="container">
        <div class="row">
        <div class="col">
            <div class="card"">
            <div class="card-body">
                <h1>Quickplay Match History</h1>
                <br>
                <div class="show-reviews">
                    <table class="table table-bordered table-condensed">
            		<thead>
                		<tr align="left">
							<th>Top Heroes: </th>
                   			<th>Assists:</th>
                            <th>Best Combat Stat:</th>
                            <th>Game Time:</th>
                            <th>Cards Awarded:</th>
                            <th>Turrets Destroyed</th>
                		</tr>
           		   </thead>           
           	        <tbody>
                           <tr>
                               <td><asp:Label ID="TopHeroesLabel1" runat="server" Text=""></asp:Label>,
                         <asp:Label ID="TopHeroesLabel2" runat="server" Text=""></asp:Label>,
                         <asp:Label ID="TopHeroesLabel3" runat="server" Text=""></asp:Label>,
                         <asp:Label ID="TopHeroesLabel4" runat="server" Text=""></asp:Label>,
                         <asp:Label ID="TopHeroesLabel5" runat="server" Text=""></asp:Label>,
                         </td>
                                <td>
                             <asp:Label ID="AssistsLabel" runat="server" Text=""></asp:Label>
                            </td>
                         <td>
                             <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                             <asp:Label ID="CombatQuickLabel" runat="server" Text=""></asp:Label> 
                            </td>
                         <td>
                             <asp:Label ID="GameQuickLabel" runat="server" Text=""></asp:Label>:
                             <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
                            </td>
                        <td>
                            <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
                             <asp:Label ID="Match_AwardsQuickLabel" runat="server" Text=""></asp:Label> Awarded
                            </td>

                        <td>
                            <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
                             <asp:Label ID="MiscQuickLabel" runat="server" Text=""></asp:Label>
                            </td>
                           </tr>
                            <tr>
                        <td> </td>
                        <td>
                             <asp:Label ID="AssistsLabel1" runat="server" Text=""></asp:Label>
                            </td>
                         <td>
                             <asp:Label ID="CombatQuickLabel11" runat="server" Text=""></asp:Label>
                             <asp:Label ID="CombatQuickLabel1" runat="server" Text=""></asp:Label> 
                            </td>
                         <td>
                             <asp:Label ID="GameQuickLabel1" runat="server" Text=""></asp:Label>:
                             <asp:Label ID="GameQuickLabel11" runat="server" Text=""></asp:Label>
                            </td>
                        <td>
                            <asp:Label ID="Match_AwardsQuickLabel11" runat="server" Text=""></asp:Label>
                             <asp:Label ID="Match_AwardsQuickLabel1" runat="server" Text=""></asp:Label> Awarded
                            </td>

                        <td>
                            <asp:Label ID="MiscQuickLabel11" runat="server" Text=""></asp:Label>
                             <asp:Label ID="MiscQuickLabel1" runat="server" Text=""></asp:Label>
                            </td>
                    </tr>
                           <tr>
                        <td> </td>
                        <td>
                             <asp:Label ID="AssistsLabel2" runat="server" Text=""></asp:Label>
                            </td>
                         <td>
                             <asp:Label ID="CombatQuickLabel12" runat="server" Text=""></asp:Label>
                             <asp:Label ID="CombatQuickLabel2" runat="server" Text=""></asp:Label> 
                            </td>
                         <td>
                             <asp:Label ID="GameQuickLabel2" runat="server" Text=""></asp:Label>:
                             <asp:Label ID="GameQuickLabel12" runat="server" Text=""></asp:Label>
                            </td>
                        <td>
                            <asp:Label ID="Match_AwardsQuickLabel12" runat="server" Text=""></asp:Label>
                             <asp:Label ID="Match_AwardsQuickLabel2" runat="server" Text=""></asp:Label> Awarded
                            </td>

                        <td>
                            <asp:Label ID="MiscQuickLabel12" runat="server" Text=""></asp:Label>
                             <asp:Label ID="MiscQuickLabel2" runat="server" Text=""></asp:Label>
                            </td>
                    </tr>
                    <tr>
                        <td> </td>
                        <td>
                             <asp:Label ID="AssistsLabel3" runat="server" Text=""></asp:Label>
                            </td>
                         <td>
                             <asp:Label ID="CombatQuickLabel13" runat="server" Text=""></asp:Label>
                             <asp:Label ID="CombatQuickLabel3" runat="server" Text=""></asp:Label> 
                            </td>
                         <td>
                             <asp:Label ID="GameQuickLabel3" runat="server" Text=""></asp:Label>:
                             <asp:Label ID="GameQuickLabel13" runat="server" Text=""></asp:Label>
                            </td>
                        <td>
                            <asp:Label ID="Match_AwardsQuickLabel13" runat="server" Text=""></asp:Label>
                             <asp:Label ID="Match_AwardsQuickLabel3" runat="server" Text=""></asp:Label>  Awarded
                            </td>

                        <td>
                            <asp:Label ID="MiscQuickLabel13" runat="server" Text=""></asp:Label>
                             <asp:Label ID="MiscQuickLabel3" runat="server" Text=""></asp:Label>
                            </td>
                    </tr>
                           <tr>
                        <td> </td>
                        <td>
                             <asp:Label ID="AssistsLabel4" runat="server" Text=""></asp:Label>
                            </td>
                         <td>
                             <asp:Label ID="CombatQuickLabel14" runat="server" Text=""></asp:Label>
                             <asp:Label ID="CombatQuickLabel4" runat="server" Text=""></asp:Label> 
                            </td>
                         <td>
                             <asp:Label ID="GameQuickLabel4" runat="server" Text=""></asp:Label>:
                             <asp:Label ID="GameQuickLabel14" runat="server" Text=""></asp:Label>
                            </td>
                        <td>
                            <asp:Label ID="Match_AwardsQuickLabel14" runat="server" Text=""></asp:Label>
                             <asp:Label ID="Match_AwardsQuickLabel4" runat="server" Text=""></asp:Label> Awarded
                            </td>

                        <td>
                            <asp:Label ID="MiscQuickLabel14" runat="server" Text=""></asp:Label>
                             <asp:Label ID="MiscQuickLabel4" runat="server" Text=""></asp:Label>
                            </td>
                    </tr>


                    </tbody>
        		  </table>
                </div>
            </div>
            </div>
            </div>
            </div>
        </div>
 
             <div class="container">
        <div class="row">
        <div class="col">
            <div class="card"">
            <div class="card-body">
                <h1>Competitive Match History</h1>
                <br>
                <div class="show-reviews">
                    <table class="table table-bordered table-condensed">
            		<thead>
                		<tr align="left">
							<th>Top Heroes: </th>
                   			<th>Assists:</th>
                            <th>Best Combat Stat:</th>
                            <th>Game Time:</th>
                            <th>Cards Awarded:</th>
                            <th>Turrets Destroyed</th>
                		</tr>
           		   </thead>           
           	        <tbody>
                           <tr>
                               <td><asp:Label ID="TopHeroLabel1" runat="server" Text=""></asp:Label>,
                         <asp:Label ID="TopHeroLabel2" runat="server" Text=""></asp:Label>,
                         <asp:Label ID="TopHeroLabel3" runat="server" Text=""></asp:Label>,
                         <asp:Label ID="TopHeroLabel4" runat="server" Text=""></asp:Label>,
                         <asp:Label ID="TopHeroLabel5" runat="server" Text=""></asp:Label>,
                         </td>
                             <td>
                             <asp:Label ID="CompAssistsLabel1" runat="server" Text=""></asp:Label>
                            </td>
                         <td>
                             <asp:Label ID="CombatCompLabel1" runat="server" Text=""></asp:Label>
                             <asp:Label ID="CombatCompLabel" runat="server" Text=""></asp:Label>
                            </td>
                         <td>
                             <asp:Label ID="GameCompLabel" runat="server" Text=""></asp:Label>:
                             <asp:Label ID="GameCompLabel1" runat="server" Text=""></asp:Label>
                            </td>
                        <td>
                            <asp:Label ID="Match_AwardsCompLabel1" runat="server" Text=""></asp:Label>
                             <asp:Label ID="Match_AwardsCompLabel" runat="server" Text=""></asp:Label> Awarded
                            </td>

                        <td>
                            <asp:Label ID="MiscCompLabel1" runat="server" Text=""></asp:Label>
                             <asp:Label ID="MiscCompLabel" runat="server" Text=""></asp:Label>
                            </td>
                           </tr>
                            <tr>
                        <td>    </td>
                        <td>
                             <asp:Label ID="CompAssistsLabel19" runat="server" Text=""></asp:Label>
                            </td>
                         <td>
                             <asp:Label ID="CombatCompLabel19" runat="server" Text=""></asp:Label>
                             <asp:Label ID="CombatCompLabel9" runat="server" Text=""></asp:Label>
                            </td>
                         <td>
                             <asp:Label ID="GameCompLabel9" runat="server" Text=""></asp:Label>:
                             <asp:Label ID="GameCompLabel19" runat="server" Text=""></asp:Label>
                            </td>
                        <td>
                            <asp:Label ID="Match_AwardsCompLabel19" runat="server" Text=""></asp:Label>
                             <asp:Label ID="Match_AwardsCompLabel9" runat="server" Text=""></asp:Label> Awarded
                            </td>

                        <td>
                            <asp:Label ID="MiscCompLabel19" runat="server" Text=""></asp:Label>
                             <asp:Label ID="MiscCompLabel9" runat="server" Text=""></asp:Label>
                            </td>
                    </tr>
                           <tr>
                        <td>    </td>
                        <td>
                             <asp:Label ID="CompAssistsLabel18" runat="server" Text=""></asp:Label>
                            </td>
                         <td>
                             <asp:Label ID="CombatCompLabel18" runat="server" Text=""></asp:Label>
                             <asp:Label ID="CombatCompLabel8" runat="server" Text=""></asp:Label>
                            </td>
                         <td>
                             <asp:Label ID="GameCompLabel8" runat="server" Text=""></asp:Label>:
                             <asp:Label ID="GameCompLabel18" runat="server" Text=""></asp:Label>
                            </td>
                        <td>
                            <asp:Label ID="Match_AwardsCompLabel18" runat="server" Text=""></asp:Label>
                             <asp:Label ID="Match_AwardsCompLabel8" runat="server" Text=""></asp:Label> Awarded
                            </td>

                        <td>
                            <asp:Label ID="MiscCompLabel18" runat="server" Text=""></asp:Label>
                             <asp:Label ID="MiscCompLabel8" runat="server" Text=""></asp:Label>
                            </td>
                    </tr>
                           <tr>
                        <td>    </td>
                        <td>
                             <asp:Label ID="CompAssistsLabel17" runat="server" Text=""></asp:Label>
                            </td>
                         <td>
                             <asp:Label ID="CombatCompLabel17" runat="server" Text=""></asp:Label>
                             <asp:Label ID="CombatCompLabel7" runat="server" Text=""></asp:Label>
                            </td>
                         <td>
                             <asp:Label ID="GameCompLabel7" runat="server" Text=""></asp:Label>:
                             <asp:Label ID="GameCompLabel17" runat="server" Text=""></asp:Label>
                            </td>
                        <td>
                            <asp:Label ID="Match_AwardsCompLabel17" runat="server" Text=""></asp:Label>
                             <asp:Label ID="Match_AwardsCompLabel7" runat="server" Text=""></asp:Label>Awarded
                            </td>

                        <td>
                            <asp:Label ID="MiscCompLabel17" runat="server" Text=""></asp:Label>
                             <asp:Label ID="MiscCompLabel7" runat="server" Text=""></asp:Label>
                            </td>
                    </tr>
                    <tr>
                        <td>   </td>
                        <td>
                             <asp:Label ID="CompAssistsLabel16" runat="server" Text=""></asp:Label>
                            </td>
                         <td>
                             <asp:Label ID="CombatCompLabel16" runat="server" Text=""></asp:Label>
                             <asp:Label ID="CombatCompLabel6" runat="server" Text=""></asp:Label>
                            </td>
                         <td>
                             <asp:Label ID="GameCompLabel6" runat="server" Text=""></asp:Label>:
                             <asp:Label ID="GameCompLabel16" runat="server" Text=""></asp:Label>
                            </td>
                        <td>
                            <asp:Label ID="Match_AwardsCompLabel16" runat="server" Text=""></asp:Label>
                             <asp:Label ID="Match_AwardsCompLabel6" runat="server" Text=""></asp:Label> Awarded
                            </td>

                        <td>
                            <asp:Label ID="MiscCompLabel16" runat="server" Text=""></asp:Label>
                             <asp:Label ID="MiscCompLabel6" runat="server" Text=""></asp:Label>
                            </td>
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
        <div>
                <p>
            User Icon:
            <asp:Image ID="PlayerImg" ImageUrl="" runat="server"  />
                </p>
                <p>
            <asp:Image ID="RankImg" ImageUrl="" runat="server" />
            </p>
            </div>
    </div>
    </section>
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
