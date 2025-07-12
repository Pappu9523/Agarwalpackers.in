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

public partial class feedback1 : System.Web.UI.Page
{
    SqlConnection cn = new SqlConnection("user id=sa;password=pa$$word;initial catalog=DRSSOUTHNEW;data source=43.252.88.61");
    SmtpClient client;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string NameM, mobileM, emailM, fromM, queryM;

            NameM = Request.Form["txtName"];
            mobileM = Request.Form["txtMobileNo"];
            emailM = Request.Form["txtEmail"];
            fromM = Request.Form["txtFrom"];
            queryM = Request.Form["txtEng"];




            // string Query = "insert into MailSms(Name,Mobile,Email,MFrom,MTo,Message,Date,ShiftType,Company) values('" + NameM + "','" + mobileM + "','" + emailM + "','" + fromM + "','" + toM + "','" + queryM + "','" + DateTime.Now + "','HTML','AMP')";

            SqlCommand cmd = new SqlCommand("PRC_FEEDBACK_APM_INSERT", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@NAME", SqlDbType.NVarChar).Value = NameM;
            cmd.Parameters.Add("@MOBILENO", SqlDbType.NVarChar).Value = mobileM;
            cmd.Parameters.Add("@EMAIL", SqlDbType.NVarChar).Value = emailM;
            cmd.Parameters.Add("@GCNO", SqlDbType.NVarChar).Value = fromM;
            cmd.Parameters.Add("@FEEDBACK", SqlDbType.NVarChar).Value = queryM;
            cmd.Parameters.Add("@FEEDBACKDATE", SqlDbType.DateTime).Value = DateTime.Now; ;
            cmd.Parameters.Add("@REPLY", SqlDbType.NVarChar).Value = "";
            cmd.Parameters.Add("@REPLYDATE", SqlDbType.NVarChar).Value = "";
            cmd.Parameters.Add("@REMARKS", SqlDbType.NVarChar).Value = "";

            cn.Open();
            int count = cmd.ExecuteNonQuery();
            cn.Close();
            if (count != 1)
            {
                Response.Write("Error");
            }

            

        }

       

    }
}