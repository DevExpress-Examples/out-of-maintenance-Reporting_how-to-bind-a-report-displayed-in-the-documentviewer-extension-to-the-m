Imports Microsoft.VisualBasic
Imports System
Namespace E5023.Reports
	Partial Public Class CategoriesReport
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.pbImage = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
            Me.lbHeader = New DevExpress.XtraReports.UI.XRLabel()
            Me.ObjectDataSource1 = New DevExpress.DataAccess.ObjectBinding.ObjectDataSource()
            CType(Me.ObjectDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            '
            'Detail
            '
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.pbImage, Me.xrLabel2, Me.xrLabel1})
            Me.Detail.HeightF = 100.0!
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            '
            'pbImage
            '
            Me.pbImage.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Image", Nothing, "Picture")})
            Me.pbImage.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 10.00001!)
            Me.pbImage.Name = "pbImage"
            Me.pbImage.SizeF = New System.Drawing.SizeF(150.0001!, 79.99998!)
            Me.pbImage.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
            '
            'xrLabel2
            '
            Me.xrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Description")})
            Me.xrLabel2.Font = New System.Drawing.Font("Times New Roman", 14.0!)
            Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(150.0001!, 43.70832!)
            Me.xrLabel2.Name = "xrLabel2"
            Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.xrLabel2.SizeF = New System.Drawing.SizeF(499.9999!, 46.29168!)
            Me.xrLabel2.StylePriority.UseFont = False
            Me.xrLabel2.Text = "lbDescription"
            '
            'xrLabel1
            '
            Me.xrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CategoryName")})
            Me.xrLabel1.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Bold)
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(150.0001!, 10.00001!)
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(499.9999!, 33.70832!)
            Me.xrLabel1.StylePriority.UseFont = False
            Me.xrLabel1.Text = "lbCategoryName"
            '
            'TopMargin
            '
            Me.TopMargin.HeightF = 100.0!
            Me.TopMargin.Name = "TopMargin"
            Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            '
            'BottomMargin
            '
            Me.BottomMargin.HeightF = 100.0!
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            '
            'ReportHeader
            '
            Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lbHeader})
            Me.ReportHeader.HeightF = 100.0!
            Me.ReportHeader.Name = "ReportHeader"
            '
            'lbHeader
            '
            Me.lbHeader.Font = New System.Drawing.Font("Times New Roman", 36.0!)
            Me.lbHeader.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 10.00001!)
            Me.lbHeader.Name = "lbHeader"
            Me.lbHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.lbHeader.SizeF = New System.Drawing.SizeF(650.0!, 79.99998!)
            Me.lbHeader.StylePriority.UseFont = False
            Me.lbHeader.StylePriority.UseTextAlignment = False
            Me.lbHeader.Text = "Categories Report"
            Me.lbHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            '
            'ObjectDataSource1
            '
            Me.ObjectDataSource1.DataSource = GetType(E5023.Models.Category)
            Me.ObjectDataSource1.Name = "ObjectDataSource1"
            '
            'CategoriesReport
            '
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader})
            Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.ObjectDataSource1})
            Me.DataSource = Me.ObjectDataSource1
            Me.Version = "14.2"
            CType(Me.ObjectDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
		Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
        Private pbImage As DevExpress.XtraReports.UI.XRPictureBox
		Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
		Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
        Private lbHeader As DevExpress.XtraReports.UI.XRLabel
        Friend WithEvents ObjectDataSource1 As DevExpress.DataAccess.ObjectBinding.ObjectDataSource
	End Class
End Namespace
