<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/E5023/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/E5023/Controllers/HomeController.vb))
* [Category.cs](./CS/E5023/Models/Category.cs) (VB: [Category.vb](./VB/E5023/Models/Category.vb))
* **[_DocumentViewerPartial.cshtml](./CS/E5023/Views/Home/_DocumentViewerPartial.cshtml)**
* [Index.cshtml](./CS/E5023/Views/Home/Index.cshtml)
<!-- default file list end -->
# How to bind a report displayed in the DocumentViewer extension to the model's data
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e5023)**
<!-- run online end -->


<p>This example demonstrates how you can bind a Report in your ASP.NET MVC application to your model class.</p>
<p><strong> </strong></p>
<p>Starting with version <strong>14.2 (2014 vol 2)</strong>, use the ObjectDataSource component to bind your report to your Model class schema as demonstrated in the <a href="https://documentation.devexpress.com/#XtraReports/CustomDocument17784">How to: Bind a Report to an Object Data Source</a> help topic.<br /><br /></p>
<p>In <strong>earlier</strong> versions, to populate the XtraReport Field List window with your model properties, add the <a href="http://msdn.microsoft.com/en-us/library/system.windows.forms.bindingsource%28v=vs.100%29.aspx">BindingSource</a> component to your report, as shown in the <a href="http://documentation.devexpress.com/#XtraReports/CustomDocument5194">Providing Data to a Web Report</a> help topic.</p>

<br/>


