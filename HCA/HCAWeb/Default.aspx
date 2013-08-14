<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HCAWeb._Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>HCA Web Application</title>

     <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="Content/durandal.css" rel="stylesheet" />
     <link href="Content/toastr.css" rel="stylesheet" />
     <link href="Content/app.css" rel="stylesheet" />

         <script type="text/javascript" src="scripts/jquery-1.9.1.js"></script>
    <script type="text/javascript" src="scripts/knockout-2.2.1.js"></script>
    <script type="text/javascript" src="scripts/sammy-0.7.4.js"></script>
    <script type="text/javascript" src="scripts/toastr.js"></script>
        <script type="text/javascript" src="scripts/q.js"></script>
        <script type="text/javascript" src="scripts/breeze.debug.js"></script>
        <script type="text/javascript" src="scripts/bootstrap.js"></script>
        <script type="text/javascript" src="scripts/moment.js"></script>

</head>
<body>

    <div id="applicationHost">
               <div class="page-splash"></div>
        <div class="page-splash-message">
           HCA Web Application Loading.....
        </div>
        <div class="progress progress-striped active page-progress-bar">
            <div class="bar" style="width: 100%;"></div>
        </div>
     </div>
     <script type="text/javascript" src="App/durandal/amd/require.js" data-main="App/main"></script>
   
</body>
</html>
