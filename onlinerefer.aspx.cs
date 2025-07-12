using System;
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

public partial class onlinerefer : System.Web.UI.Page
{
//    SqlConnection cn = new SqlConnection("user id=SQLDRS;password=dr$$ql;initial catalog=DrsGroup;data source=174.37.197.161");
	SmtpClient client;
    protected void Page_Load(object sender, EventArgs e)
   {
    if (!IsPostBack)
        {       
        string enameM, cardM, nameM, mobileM, emailM, fromM, toM, queryM;
		
		enameM = Request.Form["txtName"];
        cardM = Request.Form["textfield2"];
        nameM = Request.Form["textfield5"];
        mobileM = Request.Form["textfield6"];
		emailM = Request.Form["textfield3"];
        fromM = Request.Form["textfield4"];
		toM = Request.Form["textfield7"];
		queryM = Request.Form["textarea"];
		
		
		

       // string Query = "insert into MailSms(Name,Mobile,Email,MFrom,MTo,Message,Date,ShiftType,Company) values('" + NameM + "','" + mobileM + "','" + emailM + "','" + fromM + "','" + toM + "','" + queryM + "','" + DateTime.Now + "','HTML','AMP')";

//        SqlCommand cmd = new SqlCommand(Query, cn);
//        cn.Open();
//        cmd.ExecuteNonQuery();
//        cn.Close();
        

//        MailMessage MMail = new MailMessage();
		MailMessage mg = new MailMessage();
      //  MMail.To = "seo@drseducation.com";
//        MMail.Cc = "seo@drsindia.in";
//        //MMail.Bcc = "seo@drseducation.com";
//        MMail.From = "it@drseducation.com";


        mg.From = new MailAddress("autoserver@drsindia.in", "Agarwal Packers & Movers");
        mg.To.Add(new MailAddress("info@agarwalpackers.in"));
        mg.To.Add(new MailAddress("sk@drseducation.com"));
        mg.CC.Add(new MailAddress("membership@agarwalpackers.in"));
		mg.CC.Add(new MailAddress("seo@drseducation.com"));
		
		
        mg.Subject = "..::REFERALS FROM AGARWAL PACKERS::..";
		
        string MMessage = "Member Name :" + enameM + "<br>"; 
        MMessage += "APM Card No :" + cardM + "<br>";
        MMessage += "Name :" + nameM + "<br>";
        MMessage += "Mobile:" + mobileM + "<br>";
		MMessage += "Email:" + emailM + "<br>";
		MMessage += "From:" + fromM + "<br>";
		MMessage += "To:" + toM + "<br>";
        MMessage += "Message :" + queryM + "<br><br><br>";
        MMessage += "<strong>IT DRS INDIA</strong>";
		
		
//        MMail.Body = AAMessage;
//        MMail.BodyFormat = MailFormat.Html;
		mg.Body = MMessage; //optional code
        mg.IsBodyHtml = true;

        client = new SmtpClient("mail.drsindia.in", 25);
        client.DeliveryMethod = SmtpDeliveryMethod.Network;
        System.Net.NetworkCredential credentials = new System.Net.NetworkCredential("autoserver@drsindia.in", "Mail2@drs");
        //System.Net.NetworkCredential credentials = new System.Net.NetworkCredential("apm@agarwalpacker.net", "Apm@123456");
        client.UseDefaultCredentials = false;
        client.Credentials = credentials;
        client.Send(mg);
       // SmtpMail.Send(MMail);
	   
       // string MobileNumber ="9391566551";   

       // string MMessage1 = "..::Referals::.. Member:" + enameM + ":APM CARD:" + cardM + ":Name:" + nameM + ":Mobile:" + mobileM + ":Email:" + emailM + ":From:" + fromM + ":To:" + toM + ":Msg:" + queryM;
        //for (int i = 0; i <= lbxGroupMobile.Items.Count - 1; i++)
        //{
        //    MobileNumber = lbxGroupMobile.Items[i].Value.ToString();
       // SmsMethod(MobileNumber, MMessage1);
        //}
        Response.Redirect("thankyou.html");
       
    }
    
}
    
    //public void SendSms()
    //{

    //    string MobileNumber = "9701524452";

    //    string MMessage = "..::ENQUIRE PACMAC::.. Name:" + NameM + ":Mobile:" + mobileM + ":Email:" + emailM + ":From:" + fromM + ":To:" + toM + ":Msg:" + queryM;
    //    //for (int i = 0; i <= lbxGroupMobile.Items.Count - 1; i++)
    //    //{
    //    //    MobileNumber = lbxGroupMobile.Items[i].Value.ToString();
    //        SmsMethod(MobileNumber, MMessage);
    //    //}
        
    //}

  public void SmsMethod(string mobile, string msg)
    {
        
        WebRequest req = null;
        string pp = "";
//		string uid = "drsdilip";
//        string pwd = "1233211";
		//req = WebRequest.Create("http://smsc11.com/corp/extendingsms2.jsp?uname=" + uid + "&pass=" + pwd + "&mobile=" + mobile + "&msg=" + msg);
		
		        string uid = "drsdilip";
        //string pwd = "1233211";
        string pwd = "DDrs@@123";
        //	string uid = "drstrans";
        //  string pwd = "456987";
        //  req = WebRequest.Create("http://www.smsc11.com/corp/SendingSms.jsp?uname=" + uid + "&pass=" + pwd + "&mobile=" + mobile + "&msg=" + msg);
        //	req = WebRequest.Create("http://smsc11.com/corp/extendingsms2.jsp?uname=" + uid + "&pass=" + pwd + "&mobile=" + mobile + "&msg=" + msg);

        req = WebRequest.Create("http://smsstreet.in/websms/sendsms.aspx?userid=" + uid + "&password=" + pwd + "&sender=APMDRS" + "&mobileno=" + mobile + "&msg=" + msg);
		
		
		
        //string uid = "drstrans";
//        string pwd = "456987";
//        req = WebRequest.Create("http://www.smsc11.com/corp/SendingSms.jsp?uname=" + uid + "&pass=" + pwd + "&mobile=" + mobile + "&msg=" + msg);
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

        //Response.Write(pp);

        //ScriptManager.RegisterStartupScript(Page, Page.GetType(), "1011", "open('" + pp + "');", True);

        
    }
}
