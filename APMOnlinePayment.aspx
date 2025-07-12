<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="APMOnlinePayment.aspx.cs" Inherits="DRLTRANS_New.APMOnlinePayment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            color: #CC3300;
        }
    </style>
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
    <form id="form1" runat="server">
    <div>
    <center><table>
        <tr>
            <th colspan="2">
                <h1 class="auto-style1">Payment Gateway</h1>
            </th>
        </tr>
        <tr>
            <td> <a href="PaymentGateWay/PaymentGateWay.aspx"> <img src="images/atom_img.jpg" /></a></td>
            <td> <a href="PaytmMain.aspx"><img src="images/paytm_img.png" /></a></td>
        </tr>
            </table></center>
        
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
