'change Date to new format
'@path           Admin/DynamicPage.aspx.vb
'@line           691



Dim myDateString As String = Trim(odbcReader("ItemDate").ToString)

					Dim myDate As DateTime

					DateTime.TryParse(myDateString, myDate).ToString()


					Dim FeaturedImage As String = ""
					If Not HeaderImage = ""Then
				FeaturedImage = "<img src='/Documents/News/" & Trim(odbcReader("ImageFile").ToString()) & "' class='img-fluid' style='margin-left: auto;margin-right: auto;display: block;'/>"
				End If

					Content = "" &
					"<div class='col-md-12'><h1 >" & Trim(odbcReader("Title").ToString()) & "</h1><br />" &
					"<div style='float:left;' class='sharethis-inline-share-buttons'></div>" &
					"<p>&nbsp;</p>" &
					FeaturedImage &
					"<p>&nbsp;</p>" &
					"<strong style='font-weight:bold;'>Event Start Date: <em>" & Trim(mydate).ToString() & "</em></strong>" &
					"<p style='margin-top:5px;''><span style='margin-top:5px; margin-bottom:10px'>" & Content & "</span></p>" &
					"<div style='float:left;' class='sharethis-inline-share-buttons'></div></div>"
