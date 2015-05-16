<%@ Page Title="" Language="C#" MasterPageFile="~/Inicio.Master" AutoEventWireup="true" CodeBehind="Galeria.aspx.cs" Inherits="Interfaz.aspx.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="extra">
<!--==============================header=================================-->
			<header>
				<div class="main">
					<div class="bg-1">
						<h1><a href="../default.aspx">Rock Band</a></h1>
					</div>
					<nav>
						<div class="menu-bg-tail">
							<div class="menu-bg">
								<div class="container_12">
									<div class="grid_12">
										<ul class="menu">
											<li class="item"><a href="../default.aspx">Principal</a></li>
											<li><a " href="Audio.aspx">Audio</a></li>
											<li><a href="Videos.aspx">Video</a></li>
											<li><a href="Galeria.aspx">Galeria</a></li>
											<li class="item-1"><a href="Conciertos.aspx">Conciertos</a></li>
											<li class="last"><a href="Contacto.aspx">Contacto</a></li>
										</ul>
										<div class="clear"></div>
									</div>
									<div class="clear"></div>
								</div>
							</div>
						</div>
					</nav>
				</div>
			</header>
<!--==============================content================================-->
			<section id="content"><div class="ic">More Website Templates @ TemplateMonster.com. November 21, 2011!</div>
				<div class="main">
					<div class="content-padding-2">
						<div class="container_12">
							<div class="wrapper">
								<div class="grid_12">
									<div class="padding-grid-1">
										<h3 class="letter">Our <strong>Gallery</strong></h3>
										<div id="js">
											<div class="js-padding">
												<div id="gallery" class="content">
													<div class="wrapper">
														<div class="slideshow-container">
															<div id="slideshow" class="slideshow"></div>
														</div>
													</div>
												</div>
											</div>
											<div id="thumbs" class="navigation">
												<ul class="thumbs noscript">
													<li>
														<a class="thumb" href="../images/page4-img1.jpg" title=""> <img src="../images/thumb-1.jpg" alt="" /> </a>
													</li>
													<li>
														<a class="thumb" href="../images/page4-img2.jpg" title=""> <img src="../images/thumb-2.jpg" alt="" /> </a>
													</li>
													<li class="last">
														<a class="thumb" href="../images/page4-img3.jpg" title=""> <img src="../images/thumb-3.jpg" alt="" /> </a>
													</li>
													<li>
														<a class="thumb" href="../images/page4-img2.jpg" title=""> <img src="../images/thumb-2.jpg" alt="" /> </a>
													</li>
													<li>
														<a class="thumb" href="../images/page4-img3.jpg" title=""> <img src="images/thumb-3.jpg" alt="" /> </a>
													</li>
													<li class="last">
														<a class="thumb" href="../images/page4-img1.jpg" title=""> <img src="images/thumb-1.jpg" alt="" /> </a>
													</li>
												</ul>
												<div class="clear"></div>
											</div>
										</div>
									</div>
								</div>
							</div>
						</div>
					</div>
				</div>
				<div class="block"></div>
			</section>
		</div>
<!--==============================footer=================================-->
		<footer>
			<div class="main">
				<div class="footer-bg">
					<div class="container_12">
						<div class="wrapper">
							<div class="grid_12">
								<div class="footer-padding">
									<div class="wrapper">
										<span class="footer-link"><span>Superior.com &copy; 2011</span> <a rel="nofollow" target="_blank" class="link" href="http://www.templatemonster.com/">Website Template</a> by TemplateMonster.com</span>
										<ul class="list-services">
											<li><a class="tooltips n-1" title="Twitter" href="#"></a></li>
											<li><a class="tooltips n-2" title="Facebook" href="#"></a></li>
											<li class="last"><a class="tooltips n-3" title="Youtube" href="#"></a></li>
										</ul>
									</div>
								</div>
							</div>
						</div>
					</div>
				</div>
			</div>
		</footer>
    
</asp:Content>
