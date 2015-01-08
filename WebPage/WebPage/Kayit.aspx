<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Kayit.aspx.cs" Inherits="WebPage.Kayit" %>

<!DOCTYPE html>

<html>
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
                        <h4>Kayıt Formu</h4>
                        <div class="form">

                            
                       <div><asp:TextBox ID="kayit_username" runat="server" /></div>
                       <div><asp:TextBox ID="kayit_password" TextMode="Password" runat="server" /></div>
                       <div><asp:TextBox ID="kayit_name"  runat="server" /></div>
                       <div><asp:TextBox ID="kayit_surname"  runat="server" /></div>
                       <div><asp:Button ID="kayit_button"  OnClick="kayit_button_Click" CssClass="buton-sol" Text="Kayıt Ol" runat="server" /></div>
                       <div class="clear"></div>
                            <div>
                                <asp:Label Text="" ID="mesaj"  runat="server" /></div>
                                


                            </div>
                      
                        </div>
                    </div>


			</div>
			<div class="right">
				<div class="block">
					<h4>Kullanıcı Girişi</h4>
					<div class="form">
					
                        <asp:TextBox runat="server" ID="username"  />  
                        <asp:TextBox runat="server" ID="password" />  
                        <asp:Button Text="Giriş Yap" CssClass="buton-sag" runat="server" />
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
