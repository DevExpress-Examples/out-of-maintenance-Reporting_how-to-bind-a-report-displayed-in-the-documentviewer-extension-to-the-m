Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Data

Namespace E5023.Models
	Public Class Category
		Private privateCategoryID As Integer
		Public Property CategoryID() As Integer
			Get
				Return privateCategoryID
			End Get
			Set(ByVal value As Integer)
				privateCategoryID = value
			End Set
		End Property

		Private privateCategoryName As String
		Public Property CategoryName() As String
			Get
				Return privateCategoryName
			End Get
			Set(ByVal value As String)
				privateCategoryName = value
			End Set
		End Property

		Private privateDescription As String
		Public Property Description() As String
			Get
				Return privateDescription
			End Get
			Set(ByVal value As String)
				privateDescription = value
			End Set
		End Property

		Private privatePicture As Byte()
		Public Property Picture() As Byte()
			Get
				Return privatePicture
			End Get
			Set(ByVal value As Byte())
				privatePicture = value
			End Set
		End Property

		Public Shared Function GetCategories() As List(Of Category)
			Dim catData As DataTable = DataHelper.ProcessSelectCommand("SELECT * FROM [Categories]")
			If catData IsNot Nothing Then
				Dim categories As New List(Of Category)()
				For Each row As DataRow In catData.Rows
					Dim category As New Category() With {.CategoryID = CInt(Fix(row("CategoryID"))), .CategoryName = CStr(row("CategoryName")), .Description = CStr(row("Description")), .Picture = CType(row("Picture"), Byte())}
					categories.Add(category)
				Next row
				Return categories
			End If
			Return Nothing
		End Function
	End Class
End Namespace