﻿Imports Xamarin.Forms

Public Class App
	Inherits Application

	Public Sub New()
		MainPage = New NavigationPage(New MainPage)
	End Sub

	Protected Overrides Sub OnStart()
		' Handle when your app starts
	End Sub

	Protected Overrides Sub OnSleep()
		' Handle when your app sleeps
	End Sub

	Protected Overrides Sub OnResume()
		' Handle when your app resumes
	End Sub

End Class
