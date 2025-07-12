<%@ Page Language="C#" AutoEventWireup="true" CodeFile="applyonline.aspx.cs" Inherits="applyonline" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
<!-- Global site tag (gtag.js) - Google Ads -->
    <script async src="https://www.googletagmanager.com/gtag/js?id=AW-692453580"></script>
    <script>
        window.dataLayer = window.dataLayer || [];
        function gtag() { dataLayer.push(arguments); }
        gtag('js', new Date());

        gtag('config', 'AW-692453580');
    </script>

</head>
<body>
    
   
     <form id="form2" runat="server">
    <div>
    <br />
     <br />
      <br />
       <br />
        <br />
     <br />
      <br />
       <br />
        <br /><center><label style="color:Orange;font-size :40px;font-weight:bold">Submitted Successfully</label></center>
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
