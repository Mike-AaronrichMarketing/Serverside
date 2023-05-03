' This will allow you to block email addresses from the email value of the text field.
'apply If ElseIf statement with the blacklist emails.



If email.value.Contains("ericjonesmyemail@gmail.com") Then
			Response.Redirect("error")
		ElseIf email.value.Contains("eric.jones.z.mail@gmail.com") Then
			Response.Redirect("error")
	ElseIf email.value.Contains("ericjonesmyemail@gmail.com") Then
			Response.Redirect("error")

		Else


			Dim smtp As New SmtpClient()


			Try
				smtp.Credentials = New _
Net.NetworkCredential("PM-T-surfacespcb-com-VHgtIrAYueMckoV", "Uac3vubodHqySMf0izn3KGYcIEvn7EMkt2ch")
				smtp.Port = 587
				smtp.Host = "smtp.postmarkapp.com"
				smtp.Send(mail)
				Response.Redirect("thanks")
			Catch ehttp As System.Web.HttpException
				Response.Redirect("error?ret=1")
			End Try


		End If
		rAlert.Attributes.Add("style", "display: block;color:red;")
	End If
