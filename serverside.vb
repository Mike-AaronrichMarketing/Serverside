If emailContent.Contains("ericjonesmyemail@gmail.com") Then
									Response.Redirect("error")
								Else

									Dim smtp As New SmtpClient()


									Try
										smtp.Credentials = New _
										Net.NetworkCredential("PM-T-outbound-8SUpt6TjwUXj2NAAE4Xfff", "GuYMbzmstbzWVG8EuP9VKrucBgWx-_bgH4lS")
										smtp.Port = 587
										smtp.Host = "smtp.postmarkapp.com"
										smtp.Send(mail)
										Response.Redirect("thanks")
									Catch ehttp As System.Web.HttpException
										Response.Redirect("error?ret=1")
									End Try

									Response.Redirect("error?ret=2")

								End If
