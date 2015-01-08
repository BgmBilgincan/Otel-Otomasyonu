<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebPage.Default" %>

<!DOCTYPE html>

<html lang="tr">
<head runat="server">
    <meta charset="UTF-8">
	<title>SmartPro</title>
	<link rel="stylesheet" href="style.css">
</head>
<body>
    <form id="form1" runat="server">
   <div class="container">
		<div class="header">SmartPro Şeysinin 404 numaralı sınıfı</div>

		<div class="middle">
			<div class="left">
				<ul class="menu">
					<li class="item"><a href="default.aspx">Anasayfa</a></li>
					<li class="item"><a href="dersler.aspx">Dersler</a></li>
					<li class="item"><a href="kayit.aspx">Kayıt</a></li>
				</ul>
			</div>
			<div class="content">
				
				<div class="block">
					<h4>Yazı başlığı burada yer alacak</h4>
					<div class="post">
						<img src="images/resim1.jpg" alt="Alt yazı burada yer alacak">
						<article>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Reprehenderit incidunt voluptas laudantium autem consequatur necessitatibus tenetur consectetur ex. Ab incidunt distinctio nam! Nulla aliquid vero sit atque harum sapiente cum?</article>
						<a href="yazi.aspx?id=1" class="reading">Devamını Oku &raquo;</a>
						<div class="clear"></div>
					</div>
				</div>
				<div class="block">
					<h4>Yazı başlığı burada yer alacak</h4>
					<div class="post">
						<img src="images/resim2.jpg" alt="Alt yazı burada yer alacak">
						<article>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Reprehenderit incidunt voluptas laudantium autem consequatur necessitatibus tenetur consectetur ex. Ab incidunt distinctio nam! Nulla aliquid vero sit atque harum sapiente cum?</article>
						<a href="yazi.aspx?id=1" class="reading">Devamını Oku &raquo;</a>
						<div class="clear"></div>
					</div>
				</div>
				<div class="block">
					<h4>Yazı başlığı burada yer alacak</h4>
					<div class="post">
						<img src="images/resim3.jpg" alt="Alt yazı burada yer alacak">
						<article>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Reprehenderit incidunt voluptas laudantium autem consequatur necessitatibus tenetur consectetur ex. Ab incidunt distinctio nam! Nulla aliquid vero sit atque harum sapiente cum?</article>
						<a href="yazi.aspx?id=1" class="reading">Devamını Oku &raquo;</a>
						<div class="clear"></div>
					</div>
				</div>

			</div>
			<div class="right">
				<div class="block">
					<h4>Kullanıcı Girişi</h4>
					<div class="form">
					
                        <asp:TextBox runat="server" ID="username"  />  
                        <asp:TextBox runat="server" ID="password" TextMode="Password"/>  
                        <asp:Button Text="Giriş Yap" runat="server" />
                        <div class="clear"></div>
						
					</div>
				</div>
			</div>
			<div class="clear"></div>
		</div>

		<div class="footer">&copy; Sınıfım ve Ben</div>

	</div>

    </form>
</body>
</html>
