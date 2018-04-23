Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc
Imports DevExpress.Web.Mvc
Imports E5023.Models
Imports E5023.Reports

Namespace E5023.Controllers
	Public Class HomeController
		Inherits Controller
		Public Function Index() As ActionResult
			Return View()
		End Function

		Public Function DocumentViewerPartial() As ActionResult
			Dim model = Category.GetCategories()
			Return PartialView("_DocumentViewerPartial", model)
		End Function

		Public Function DocumentViewerPartialExport() As ActionResult
			Dim report As New CategoriesReport()
			report.DataSource = Category.GetCategories()
			Return ReportViewerExtension.ExportTo(report)
		End Function
	End Class
End Namespace