<%@ Page Language="C#" AutoEventWireup="true" CodeFile="feedback.aspx.cs" Inherits="feedback" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" />
    <title>Welcome to :: Agarwal Packers</title>
    <link href="css/maxcare.css" rel="stylesheet" type="text/css" />



    <meta name="KEYWORDS" content=" ">
    <meta name="DESCRIPTION" content=" ">
    <meta http-equiv="Imagetoolbar" content="false" />





<!-- Global site tag (gtag.js) - Google Ads -->
    <script async src="https://www.googletagmanager.com/gtag/js?id=AW-692453580"></script>
    <script>
        window.dataLayer = window.dataLayer || [];
        function gtag() { dataLayer.push(arguments); }
        gtag('js', new Date());

        gtag('config', 'AW-692453580');
    </script>

<!-- Facebook Pixel Code -->
<script>
!function(f,b,e,v,n,t,s)
{if(f.fbq)return;n=f.fbq=function(){n.callMethod?
n.callMethod.apply(n,arguments):n.queue.push(arguments)};
if(!f._fbq)f._fbq=n;n.push=n;n.loaded=!0;n.version='2.0';
n.queue=[];t=b.createElement(e);t.async=!0;
t.src=v;s=b.getElementsByTagName(e)[0];
s.parentNode.insertBefore(t,s)}(window,document,'script',
'https://connect.facebook.net/en_US/fbevents.js');
 fbq('init', '877653363484044'); 
fbq('track', 'PageView');
</script>
<noscript>
 <img height="1" width="1" 
src="https://www.facebook.com/tr?id=877653363484044&ev=PageView
&noscript=1"/>
</noscript>
<!-- End Facebook Pixel Code -->

</head>

<body>



    <form id="form1" runat="server">
        <div>
            <center>
                <label style="color: Chocolate; font-size: 25px">
                    THANK YOU</label></center><br />
                   <center> 
                   <div id="divMsg" runat="server"  style="border:solid 1px red; height:30px">
                        <asp:Label ID="lblMessage" runat="server" ></asp:Label>
                    </div>
                    </center>
        </div>
    </form>
   

<script src="js/captcha.js"></script>

	<script>
		function onSubmit(token) {
			document.getElementById("loginform").submit();
		}
	</script>

	<script src="/js/captchascript.js">
	</script>

</body>
</html>
