﻿using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Threading;
using System.Net.Mail;
using System.IO;
using System.Data.SqlClient;
using System.Net;

public partial class mail : System.Web.UI.Page
{
  // SqlConnection cn = new SqlConnection("user id=apmdrs;password=dr$$ql;initial catalog=DrsGroup;data source=174.37.197.161");
  SqlConnection cn = new SqlConnection("user id=apmdrs;password=Shiva@$4242#^;initial catalog=DrsGroup;data source=43.252.88.61");

    SmtpClient client;
    SmtpClient client1;
    protected void Page_Load(object sender, EventArgs e)
   {
    if (!IsPostBack)
        {       
        string NameM, mobileM, emailM, fromM, toM, queryM, gclidM;

        NameM = Request.Form["txtName"];
        mobileM = Request.Form["txtMobileNo"];
        emailM = Request.Form["txtEmail"];
        fromM = Request.Form["txtFrom"];
        toM = Request.Form["txtTo"];
        queryM = Request.Form["message"];
        gclidM = Request.Form["gclid_field"];
        queryM += Request.Form["pageName"];


        int len = mobileM.Length;
        string ss;
        if (len > 10)
        {
            ss = mobileM.Substring(1);
        }
        else
            ss = mobileM;


        

          MailMessage mg = new MailMessage();


          mg.From = new MailAddress("enquiry@drsindia.in", "Agarwal Packers & Movers"); //create an account in gmail
       // mg.From = new MailAddress("apm@agarwalpacker.net", "Agarwal Packers & Movers"); //create an account in gmail
        
        //mg.To.Add(new MailAddress("ratnesh.gupta@techmagnate.com"));
       //mg.To.Add(new MailAddress("info@agarwalpackers.in"));
        mg.To.Add(new MailAddress("info@apmdrs.in"));


        //mg.To.Add(new MailAddress("info@drsindia.in"));
       // mg.To.Add(new MailAddress("subbarao@drsindia.in"));
        //mg.CC.Add(new MailAddress("seo@drseducation.com"));
        //mg.CC.Add(new MailAddress("sk@drseducation.com"));

 
        mg.Subject = "..::WEBSITE CALCULATOR FROM AGARWAL PACKERS::..";
        
        string MMessage = "Name :" + NameM + "<br>";
        MMessage += "Mobile No :" + mobileM + "<br>";
        MMessage += "Email ID :" + emailM + "<br>";
        MMessage += "From:" + fromM + "<br>";
        MMessage += "To:" + toM + "<br>";
        MMessage += "Message :" + queryM + "<br><br><br>";
        MMessage += "Gclid:" + gclidM + "<br><br><br>";
        MMessage += "<strong>IT DRS INDIA</strong>";


        mg.Body = MMessage; //optional code
        mg.IsBodyHtml = true;

        string cmessage = "   Dear " + NameM + "  <br />    Greeting From Agarwal Packers & Movers <br /><br />";
        cmessage += " <b><font color='red' >Download Agarwal Packers & Movers Mobile App :</font></b><br /><br /> With Agarwal Packers & Movers App:";
        cmessage += "<p>� You can request for a quotation 24/7 <br />";
        cmessage += "� You can pay your moving charges<br />";
        cmessage += "� You can track your consignment<br />";
        cmessage += "� You can view updates, APM News and Special Offers</p><br />";
        cmessage += "<a href='#'> <img src='http://www.agarwalpackers.in/images/Agarwalpackersandmoversapp.png' ,height='55', width='55' alt='' /></a> ";
        cmessage += "<a href='https://play.google.com/store/apps/details?id=com.logictreeit.packersnmovers'> <img src='http://www.agarwalpackerss.com/images/GooglePlay.png'  ,height='150', width='150' alt=''/></a>";
        cmessage += "<a href='https://itunes.apple.com/us/app/agarwal-packers-movers/id840087469?mt=8'> <img src='http://www.agarwalpackerss.com/images/Apple-iphoneapp.png'  ,height='150', width='150' alt=''/></a> <br /><br />";
        cmessage += "<p> We thank you for inquiring about our award winning services through the website.At APM we are committed to providing Ontime / Intact / Delivery always. </p>";
        cmessage += " <p> Our Customer Care Executive Will Contact You Soon. </p>";
        cmessage += "<p>For any Further query You may please call us at our Nos. 24X7 :- <b> 093 6001 4001</b></p><hr />";
        cmessage += "<h2><font color='red' >Beware of Fraudsters!</font></h2>";
        cmessage += "<a href='http://agarwalpackers.in/beware.html'><img src='http://www.agarwalpackers.in/moversandpackers/New%20images/fake.gif' alt=''/></a>";
        cmessage += "<p>There are plenty of fraud Movers similar or identical to our brand name,who may try to trap you by different paid ads or low rate offers.Please be aware of this and do pass this message to your colleagues! ";
        cmessage += "<a href='http://www.agarwalpackers.in/beware.html'>Click here for more</a></p><hr />";
        cmessage += "<p><b>Thanks & Regards,<br />";
        cmessage += "Agarwal Packers and Movers(Since 1984)<br />";
        cmessage += "DRS Group<br />";
        cmessage += "www.agarwalpackers.in<br />";
        cmessage +=  "</b></p><hr />";
        cmessage +="<img src='https://www.agarwalpackers.in/images/bade_bhaiya.jpg' alt='' /><br /><br /><hr />";
        cmessage +="<a href='https://www.facebook.com/agarwalpackersnmovers'> <img src='http://vignette1.wikia.nocookie.net/omori/images/f/fe/Facebook-Icon.png/revision/latest?cb=20140619160821' ,height='55', width='55' alt='' /></a> ";
        cmessage +="<a href='https://twitter.com/DRSAgarwal'> <img src='http://png-5.findicons.com/files/icons/524/web_2/512/twitter.png' ,height='55', width='55' alt='' /></a> ";
        cmessage +="<a href='https://www.linkedin.com/company/agarwal-packers-&-movers-drs-group'> <img src='http://www.smytheratcliffe.com/wp-content/themes/smytheratcliffe/images/linkedin.png' ,height='55', width='55' alt='' /></a> ";
        cmessage +="<a href='https://www.youtube.com/user/AgarwalPackersMovers'> <img src='http://icons.iconarchive.com/icons/marcus-roberto/google-play/512/YouTube-icon.png' ,height='55', width='55' alt='' /></a> ";

        MailMessage cmg = new MailMessage();

        cmg.Subject="::Agarwal Packers & Movers ::";
        cmg.From = new MailAddress("autoserver@drsindia.in", "Agarwal Packers & Movers");
        //cmg.From = new MailAddress("ratnesh.gupta@techmagnate.com", "Agarwal Packers & Movers");
        cmg.To.Add(new MailAddress(emailM));
        cmg.ReplyTo = new MailAddress("info@agarwalpackers.in");
        cmg.Body = cmessage;
        cmg.IsBodyHtml = true;


        client = new SmtpClient("mail.drsindia.in", 25);
        client.DeliveryMethod = SmtpDeliveryMethod.Network;
        System.Net.NetworkCredential credentials = new System.Net.NetworkCredential("enquiry@drsindia.in", "ZLM7{}>b^A}L!V");


        client.UseDefaultCredentials = false;
        client.Credentials = credentials;
        client.Send(mg);
        client.Send(cmg);



        string pid, tid;
        pid = "1201159887916504660";
        tid = "1207162408137425202";

        string mst = "2";

       // string MMessage1 = "..::ENQUIRY FROM AGARWAL PACKERS::.. Name:" + NameM + ":Mobile:" + mobileM + ":Email:" + emailM + ":From:" + fromM + ":To:" + toM+ ":Msg:" + queryM;
        string message2 = "Thanks for Choosing Agarwal Packers, DRS Group.U will receive a call shortly.Download App Android https://goo.gl/lfUX5f IOS: https://goo.gl/dxoc1R ph:9360014001";
  
        string Query = "insert into cost_calculator(name,mobile,fromlocation,tolocation,email,message) values('" + NameM + "','" + mobileM + "','" + fromM + "','" + toM + "','" + emailM + "','" + queryM + "')";

        SqlCommand cmd = new SqlCommand(Query, cn);
        cn.Open();
        cmd.ExecuteNonQuery();
        cn.Close();
      
        SmsMethod(ss, message2,pid,tid,mst);
        Response.Redirect("https://www.agarwalpackers.in/thanks-calculate.html");
       
    }
    
}
    

    public void SmsMethod(string mobile, string msg, string pid, string tid, string mst)
    {
        
        WebRequest req = null;
        string pp = "";
        string uid = "drsdilip";
        //string pwd = "1233211";
        string pwd = "DDrs@@123";
        //req = WebRequest.Create("http://smsstreet.in/websms/sendsms.aspx?userid=" + uid + "&password=" + pwd + "&sender=DRSAPM" + "&mobileno=" + mobile + "&msg=" + msg);
        req = WebRequest.Create("http://smsstreet.in/websms/sendsms.aspx?userid=" + uid + "&password=" + pwd + "&sender=drsapm" + "&mobileno=" + mobile + "&msg=" + msg + "&msgtype=" + mst + "&peid=" + pid + "&tpid=" + tid); //on 17/06/2020
        //Response.Write(req);

        //    Response.End();

        WebResponse resp = req.GetResponse();
        StreamReader reader = new StreamReader(resp.GetResponseStream());
        while (true)
        {
            string str;
            str = reader.ReadLine();
            if (str == null)
                break;
            pp += str;
        }
    }
}
