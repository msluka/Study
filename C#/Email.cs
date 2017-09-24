   
   /// Sending Email ASP MVC
   
   /// Helpful source: https://www.youtube.com/watch?v=P7i1G6CeOiI
   
   //In Controller
   
   public void SendEmail(string toEmail, string subject, string emailBody)
        {
            try
            {
                string senderEmail = System.Configuration.ConfigurationManager.AppSettings["SenderEmail"].ToString();
                string senderPassword = System.Configuration.ConfigurationManager.AppSettings["SenderPass"].ToString();

                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Timeout = 100000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential(senderEmail, senderPassword);

                MailMessage msg = new MailMessage(senderEmail, toEmail, subject, emailBody);
                msg.IsBodyHtml = true;
                msg.BodyEncoding = Encoding.UTF8;
				
                client.Send(msg);

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Something went wrong ! ')</script>");
                Response.Write("The error :" + ex);
            }

        }

	public void Send()
	{
		string toEmail, subject, emailBody;
		toEmail = "someone@gmail.com";
		subject = "Email From ASP MVC";
		emailBody = "<h1>WELCOME<br>" +
					 "<img src='http://pa1.narvii.com/6522/96e1a72c7f16cc2909bd5eb3cd721466a11ec6b1_hq.gif'/ >";
		SendEmail(toEmail, subject, emailBody);		
	}
	
	//In Web.config
	
	<appSettings>
	
		<add key="webpages:Version" value="3.0.0.0" />
		<add key="webpages:Enabled" value="false" />
		<add key="ClientValidationEnabled" value="true" />
		<add key="UnobtrusiveJavaScriptEnabled" value="true" />
	  
		<add key="SenderEmail" value="from@gmail.com" /> // This is a new code
		<add key="SenderPass" value="xxxxxxx" />         // This is a new code
  
    </appSettings>
	
	
	/// Sending email to multiple address

	/// Helpful source:	https://stackoverflow.com/questions/7498968/how-to-send-email-to-multiple-address-using-system-net-mail

	// The same as above and additionally:
	
    public void Send()
	{
		string toEmail, subject, emailBody;
		toEmail = "someone@gmail.com, someone2@gmail.com,"; // This is a new code
		subject = "Email From ASP MVC";
		emailBody = "<h1>WELCOME<br>" +
					 "<img src='http://pa1.narvii.com/6522/96e1a72c7f16cc2909bd5eb3cd721466a11ec6b1_hq.gif'/ >";
		SendEmail(toEmail, subject, emailBody);		
	}
	
	// or
	
	public void Send()
	{
		string subject, emailBody;

		List<MailAddress> toEmail = new List<MailAddress>();

		toEmail.Add(new MailAddress("som1@gmail.com"));
		toEmail.Add(new MailAddress("some2@gmail.com"));
		toEmail.Add(new MailAddress("some3@gmail.com"));

		subject = "Email From ASP MVC";
		emailBody = "<h1>WELCOME<br>" +
					 "<img src='http://pa1.narvii.com/6522/96e1a72c7f16cc2909bd5eb3cd721466a11ec6b1_hq.gif'/ >";

		foreach (var address in toEmail)
		{
			SendEmail(address.Address, subject, emailBody);
		}
	
	}
	
	
	/// Sending Email with CC and Bcc
	
	// The same as above and additionally:
	
	public void SendEmail(string toEmail, string subject, string emailBody)
	{
		try
		{
			string senderEmail = System.Configuration.ConfigurationManager.AppSettings["SenderEmail"].ToString();
			string senderPassword = System.Configuration.ConfigurationManager.AppSettings["SenderPass"].ToString();

			SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
			client.EnableSsl = true;
			client.Timeout = 100000;
			client.DeliveryMethod = SmtpDeliveryMethod.Network;
			client.UseDefaultCredentials = false;
			client.Credentials = new NetworkCredential(senderEmail, senderPassword);

			MailMessage msg = new MailMessage(senderEmail, toEmail, subject, emailBody);
			msg.IsBodyHtml = true;
			msg.BodyEncoding = Encoding.UTF8;

			msg.CC.Add("some1@gmail.com");  // This is a new code
			msg.Bcc.Add("some2@gmail.com"); // This is a new code

			client.Send(msg);


		}
		catch (Exception ex)
		{
			Response.Write("<script>alert('Something went wrong ! ')</script>");
			Response.Write("The error :" + ex);
		}

	}
	
	/// Sending Email with Attachment
	
	/// Helpful source: https://msdn.microsoft.com/ru-ru/library/system.net.mail.mailmessage.attachments(v=vs.110).aspx
	
	// The same as above and additionally:
	
	public void SendEmail(string toEmail, string subject, string emailBody)
	{
		try
		{
			string senderEmail = System.Configuration.ConfigurationManager.AppSettings["SenderEmail"].ToString();
			string senderPassword = System.Configuration.ConfigurationManager.AppSettings["SenderPass"].ToString();

			SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
			client.EnableSsl = true;
			client.Timeout = 100000;
			client.DeliveryMethod = SmtpDeliveryMethod.Network;
			client.UseDefaultCredentials = false;
			client.Credentials = new NetworkCredential(senderEmail, senderPassword);

			MailMessage msg = new MailMessage(senderEmail, toEmail, subject, emailBody);
			msg.IsBodyHtml = true;
			msg.BodyEncoding = Encoding.UTF8;

			msg.CC.Add("some1@gmail.com");
			msg.Bcc.Add("some2.info@gmail.com");

			string file = @"D:\welcome.jpg";
			//string file = @"D:\welcome.pdf";
			//string file = @"D:\welcome.xlsx";
			//string file = @"D:\welcome.docx";
			//string file = @"D:\welcome.mp4";

			file =  @"D:\welcome.jpg"             
			
			Attachment data = new Attachment(file, MediaTypeNames.Application.Octet);
			msg.Attachments.Add(data);                

			client.Send(msg);

		}
		catch (Exception ex)
		{
			Response.Write("<script>alert('Something went wrong ! ')</script>");
			Response.Write("The error :" + ex);
		}

	}
	