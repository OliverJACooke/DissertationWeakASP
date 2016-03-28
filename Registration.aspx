<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="Dissertation__Weak_.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration</title>
    <link rel="stylesheet" type="text/css" href="StyleSheet.css"/>
</head>
<body>
    <form id="registrationForm" runat="server">
        <!-- Form Container -->
    	    <div class="loginForm">
				<div class="formRow">
					<h1>Registration</h1>
				</div>
				<div class="formRow">
					<div class="rowLeft">
						<h2>First Name</h2>
					</div>
					<div class="rowRight">
						<input type="text" runat="server" id="txt_FirstName"/> <!--<<<< Password Input Area -->
					</div>
				</div>
                <div class="formRow">
					<div class="rowLeft">
						<h2>Last Name</h2>
					</div>
					<div class="rowRight">
						<input type="text" runat="server" id="txt_LastName"/> <!--<<<< Password Input Area -->
					</div>
				</div>
                <div class="formRow">
					<div class="rowLeft">
						<h2>Date of Birth</h2>
					</div>
					<div class="rowRight">
						<input type="text" runat="server" id="txt_DOB"/> <!--<<<< Password Input Area -->
					</div>
				</div>
                <div class="formRow">
					<div class="rowLeft">
						<h2>E-Mail</h2>
					</div>
					<div class="rowRight">
						<input type="text" runat="server" id="txt_EMail"/> <!--<<<< Password Input Area -->
					</div>
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
						<input type="password" runat="server" id="pwd_Password"/> <!--<<<< Username Input Area -->
					</div>
				</div>
                <div class="formRow">
					<div class="rowLeft">
						<h2>Password Repeat</h2>
					</div>
					<div class="rowRight">
						<input type="password" runat="server" id="pwd_PasswordRepeat"/> <!--<<<< Username Input Area -->
					</div>
				</div>
				<div class="formRow">
					<div class="rowLeft">
                        <asp:Button ID="btn_Submit" runat="server" Text="Submit" OnClick="btn_Submit_Click" />
					</div>
					<div class="rowRight">
					    <asp:Label ID="lbl_Valid" runat="server" />						<!--<<<< Validation Output Area -->
					</div>
				</div>
			</div>
    </form>
</body>
</html>
