<%@ Page Title="" Language="C#"  AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebApplication6.WebForm9" %>
<!DOCTYPE html>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <link rel="stylesheet" href="css/main.css">
    <link rel="stylesheet" href="css/bootstrap.min.css">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
    <link rel="stylesheet" type="text/css" href="css/main.css">

    <!--
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
    -->

</head>
<body>
    
   <!-- Header -->
    <nav class="navbar navbar-expand-lg navbar-dark bg-primary">
        <a class="navbar-brand" href="Default.aspx">Fantasy Cricket</a>
        <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarColor02"
            aria-controls="navbarColor02" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
        </button>
        <div class="collapse navbar-collapse" id="navbarColor02">
            <ul class="navbar-nav mr-auto">
                <li class="nav-item">
                    <a class="nav-link" href="Dashboard.aspx">Dashboard </a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="Leagues.aspx">Leagues <span class="sr-only">(current)</span></a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="Leaderboard.aspx">Leaderboard</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="#">How To Play</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="About.aspx">About</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="About.aspx">Anouncements</a>
                </li>
            </ul>
   
      
        </div>
    </nav>
    <!-- Header -->
    <br />


    <div class="login-form">
        <form runat="server">
            <h2 class="text-center">Login</h2>


            <div class="form-group">
                <div class="input-group">
                    <span class="input-group-addon"><i class="fa fa-user"></i></span>
                    <input type="text" id="user" runat="server" class="form-control" name="username" placeholder="Username" required="required">
                </div>
            </div>
            <div class="form-group">
                <div class="input-group">
                    <span class="input-group-addon"><i class="fa fa-lock"></i></span>
                    <input id="pwd" runat="server" type="password" class="form-control" name="password" placeholder="Password"
                        required="required">
                </div>
            </div>
            <div class="form-group">
                <asp:Button ID="Button1" runat="server" Text="Log In" class="btn btn-success btn-block login-btn" OnClick="Button1_Click" />
            </div>
            <div class="clearfix">
                <label class="pull-left checkbox-inline"><input type="checkbox"> Remember me</label>
                <a href="#" class="pull-right text-success">Forgot Password?</a>
            </div>
        </form>
        <div class="hint-text small">Don't have an account? <a href="register.aspx" class="text-success">Register Now!</a></div>
    </div>

  <footer class="page-footer font-small white" style="position:fixed;left :12px; bottom: 30px; width: 100%;
			background-color: #007bff;color: #fff">
        <!-- Copyright -->
        <div class="footer-copyright text-center py-3">© 2019 Copyright:
            <a href="https://mdbootstrap.com/education/bootstrap/" style="color: #fff"> FantasyCricket.com</a>
        </div>
        <!-- Copyright -->
    </footer>
    <!-- Footer -->
    <!--
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>
    -->
    <script src="js/jquery-3.3.1.slim.min.js"></script>
    <script src="js/popper.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
    <script src="js/main.js"></script>
</body>
</html>




