<%@ Page Title="" Language="C#" MasterPageFile="~/Inicio.Master" AutoEventWireup="true" CodeBehind="Contacto.aspx.cs" Inherits="Interfaz.aspx.Contacto" %>
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
											<li><a href="Audio.aspx">Audio</a></li>
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
								<article class="grid_8">
									<div class="padding-grid-1">
										<h3>Servicio <strong>Tecnico</strong></h3>
										
											
												<label>
													<span class="name-input">Nombre:</span>
													<input name="name" value=""    />
												<br />
                                        <br />
													<span class="name-input">Email:</span>	
													<input name="name1" value="" style="margin-top: 0px"  />&nbsp;
                                        <br />
                                        <br />
                                        <span class="name-input">Mensaje:</span><textarea style="height: 108px; width: 357px" ></textarea>
												</label>
											
											<div class="link-form">
												<a class="link link-margin" href="#" onClick="document.getElementById('contact-form').reset()">Borrar					<a class="link" href="#" onClick="document.getElementById('contact-form').submit()">Enviar</a>
											</div> 
											<div class="clear"></div>		
										
									</div>
								</article>
								<article class="grid_4 alpha">
									<div class="padding-grid-3">
										<h3>Informacion <strong>De Contacto</strong></h3>
										<div class="wrapper p2">
											<figure class="style-img-2 fleft">
												<iframe width="252" height="195" src="http://maps.google.com/maps?f=q&amp;source=s_q&amp;hl=en&amp;geocode=&amp;q=Brooklyn,+New+York,+NY,+United+States&amp;aq=0&amp;sll=37.0625,-95.677068&amp;sspn=61.282355,146.513672&amp;ie=UTF8&amp;hq=&amp;hnear=Brooklyn,+Kings,+New+York&amp;ll=40.649974,-73.950005&amp;spn=0.01628,0.025663&amp;z=14&amp;iwloc=A&amp;output=embed"></iframe>
											</figure>
										</div>
										<dl class="list-4">
											<dt>8901 Marmora Road,<br>Glasgow, D04 89GR.</dt>
											<dd>Telephone: +34 966 603 6035</dd>
											<dd>E-mail: <a class="link" href="#">ServicioTecnicoIM@itxenaMusic.com</a></dd>
										</dl>
									</div>
								</article>	
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
										<span class="footer-link"><span>ItxenaMusic.com &copy; 2015</span> </span>
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
