﻿Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
' ...

Namespace Report_SortBySum
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			CType(New XtraReport1(), XtraReport1).ShowPreviewDialog()
		End Sub
	End Class
End Namespace
