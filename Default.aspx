

<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ClasssProject._DefaultD" %>



<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <script type="text/javascript">
        function handleInput(sender) {
            var textBoxValue = sender.value;
            // Do something with the textBoxValue
            //alert('Input changed: ' + textBoxValue);

            __doPostBack("<%= myTextInput.UniqueID %>", textBoxValue);

        }
    </script>
    <!-- 
    <span><%= Session["Username"] %></span>
     -->
    <!-- 
    <span><%= Request.Cookies["Username"] == null? "": Request.Cookies["Username"].Value %></span> 
    -->
    <span>
        <%
        /* if (Session["Username"] == null)
        {
            Session["Username"] = "1";
        }
        else
        {
            String counter = (String)Session["Username"];
            int cInt = int.Parse(counter);
            cInt++;
            Session["Username"] = cInt + "-" + Request.QueryString["ourQueryParam"];
        } */
        if (ViewState["Username"] == null)
        {
            ViewState["Username"] = "1";
        }
        else
        {
            String counter = (String)ViewState["Username"];
            int cInt = int.Parse(counter);
            cInt++;
            ViewState["Username"] = cInt + "";
        }
      %></span>
    <span><%= ViewState["Username"] %></span>

    <asp:Label runat="server" ID="myFirstASPControl"></asp:Label>

    <asp:TextBox ID="myTextInput" runat="server" oninput="handleInput(this)" > </asp:TextBox>
    
    <main>
        <section class="row" aria-labelledby="aspnetTitle">
            <h1 id="aspnetTitle">ASP.NET</h1>
            <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
            <p><a href="http://www.asp.net" class="btn btn-primary btn-md">Learn more &raquo;</a></p>
        </section>

        <div class="row">
            <section class="col-md-4" aria-labelledby="gettingStartedTitle">
                <h2 id="gettingStartedTitle">Getting started</h2>
                <p>
                    ASP.NET Web Forms lets you build dynamic websites using a familiar drag-and-drop, event-driven model.
                A design surface and hundreds of controls and components let you rapidly build sophisticated, powerful UI-driven sites with data access.
                </p>
                <p>
                    <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301948">Learn more &raquo;</a>
                </p>
            </section>
            <section class="col-md-4" aria-labelledby="librariesTitle">
                <h2 id="librariesTitle">Get more libraries</h2>
                <p>
                    NuGet is a free Visual Studio extension that makes it easy to add, remove, and update libraries and tools in Visual Studio projects.
                </p>
                <p>
                    <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301949">Learn more &raquo;</a>
                </p>
            </section>
            <section class="col-md-4" aria-labelledby="hostingTitle">
                <h2 id="hostingTitle">Web Hosting</h2>
                <p>
                    You can easily find a web hosting company that offers the right mix of features and price for your applications.
                </p>
                <p>
                    <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301950">Learn more &raquo;</a>
                </p>
            </section>
        </div>
    </main>

</asp:Content>