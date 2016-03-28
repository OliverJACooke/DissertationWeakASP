<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Dissertation__Weak_.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link rel="stylesheet" type="text/css" href="StyleSheet.css"/>
</head>
<body>
    <form id="loginForm" runat="server">
        <!-- Form Container -->
    	    <div class="loginForm">
				<div class="formRow">
					<h1>Login</h1>
				</div>
				<div class="formRow">
					<div class="rowLeft">
						<h2>Username</h2>
					</div>
					<div class="rowRight">
						<input type="text" runat="server" id="txt_username"/> <!--<<<< Username Input Area -->
					</div>
				</div>
				<div class="formRow">
					<div class="rowLeft">
						<h2>Password</h2>
					</div>
					<div class="rowRight">
						<input type="password" runat="server" id="pwd_password"/> <!--<<<< Password Input Area -->
					</div>
				</div>
				<div class="formRow">
					<div class="rowLeft">
                        <asp:Button ID="btn_Submit" runat="server" Text="Submit" OnClick="btn_Submit_Click" />
					</div>
					<div class="rowRight">
					    <asp:Label ID="lbl_Valid" style="color:red;" runat="server" />						<!--<<<< Validation Output Area -->
					</div>
				</div>
			</div>
    </form>
    <div class="formRow">
        <a href="Registration.aspx">Click Here to Register</a>
    </div>
</body>
</html>
