<!DOCTYPE html>
<html>
<head>
    <title>@ViewBag.Title</title>
    <link href="@Url.Content("~/Content/Site.css")" rel="stylesheet" type="text/css" />
    @Html.DevExpress().GetStyleSheets(
    New StyleSheet With {.ExtensionType = ExtensionType.DocumentViewer}
)
    @Html.DevExpress().GetScripts(
    New Script With {.ExtensionType = ExtensionType.DocumentViewer}
)
</head>
<body>
    @RenderBody()
</body>
</html>
