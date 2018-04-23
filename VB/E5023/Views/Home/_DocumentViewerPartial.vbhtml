@ModelType List(Of E5023.Models.Category)
@Html.DevExpress().DocumentViewer(Sub(settings)
                                      settings.Name = "DocumentViewer"
                                      settings.CallbackRouteValues = New With {
                                          .Controller = "Home",
                                                                             .Action = "DocumentViewerPartial"
                                      }
                                      settings.ExportRouteValues = New With {
                                          .Controller = "Home",
                                                                             .Action = "DocumentViewerPartialExport"
                                      }
                                      settings.Report = New E5023.Reports.CategoriesReport() With {
                                          .DataSource = Model
                                      }
                                  End Sub).GetHtml()
