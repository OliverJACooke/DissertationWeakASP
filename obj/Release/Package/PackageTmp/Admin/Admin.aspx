<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="Dissertation__Weak_.Admin.UserManagement" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>User Management</title>
     <link rel="stylesheet" type="text/css" href="../StyleSheet.css"/>
</head>
<body>
    <form id="adminForm" runat="server">
      <div class="container">
			<h1>
                <asp:Label ID="lbl_Welcome" runat="server" />
			</h1>
			<div class="linksRow">
				<div class="link">
					<a href="../Members/Home.aspx">Home</a>
				</div>
				<div class="link">
					<a href="../Members/PostMessage.aspx">Post Message</a>
				</div>
				<div class="link">
					<a href="../Admin/Admin.aspx">Admin</a>
				</div>
                 <div class="link">
                    <a href="../Logout.aspx">Logout</a>
                </div>
                
			</div>
            <div class="formRow">
					<h1>User Admin</h1>
				</div>
				<div class="formRow">
					<div class="rowLeft">
						<h2>User Search</h2>
					</div>
					<div class="rowRight">
						<input type="text" name="searchUsername" id="searchUsername" runat="server"/> <!--<<<< First Name Input Area -->
					</div>
				</div>
				<div class="formRow">
					<div class="rowLeft">
						<asp:button type="Submit" Text="Search" ID="Search" runat="server" OnClick="Search_Click"/> <!--<<<< Submit Button Area -->
					</div>
				</div>
				
				<div class="formRow">
					<div class="rowLeft">
						<h2>UserID</h2>
					</div>
					<div class="rowRight">
						<asp:Label id="userID" runat="server" /> <!--<<<< First Name Input Area -->
					</div>
				</div>
				<div class="formRow">
					<div class="rowLeft">
						<h2>Username</h2>
					</div>
					<div class="rowRight">
						<asp:Label ID="username" runat="Server" /><!--<<<< Username Input Area -->
					</div>
				</div>
				<div class="formRow">
					<div class="rowLeft">
						<h2>First Name</h2>
					</div>
					<div class="rowRight">
						<input type="text" id="txt_firstName" runat="server"/> <!--<<<< First Name Input Area -->
					</div>
				</div>
				<div class="formRow">
					<div class="rowLeft">
						<h2>Second Name</h2>
					</div>
					<div class="rowRight">
						<input type="text" id="txt_lastName" runat="server"/> <!--<<<< Second Name Input Area -->
					</div>
				</div>
				<div class="formRow">
					<div class="rowLeft">
						<h2>Date of Birth</h2>
					</div>
					<div class="rowRight">
						<input type="text" id="txt_dob" runat="server"/> <!--<<<< Date of Birth Input Area -->
					</div>
				</div>
				<div class="formRow">
					<div class="rowLeft">
						<h2>E-Mail Address</h2>
					</div>
					<div class="rowRight">
						<input type="text" id="txt_eMail" runat="server"/> <!--<<<< E-Mail Input Area -->
					</div>
				</div>
				<div class="formRow">
					<div class="rowLeft">
						<h2>Admin</h2>
					</div>
					<div class="rowRight">
						<asp:CheckBox ID="chk_Admin" runat="server"/> <!--<<<< Password Repeat Input Area -->
                        
					</div>
				</div>
				<div class="formRow">
					<div class="rowLeft">
						<asp:Button ID="Submit" Text="Submit" runat="server" OnClick="Submit_Click"/> <!--<<<< Submit Button Area -->
						<asp:Button ID="Delete" Text="Delete" runat="server" OnClick="Delete_Click"/>
					</div>
					<div class="rowRight">
						<asp:Label ID="lbl_Valid" runat="server"> </asp:Label><!--<<<< Validation Output Area -->
					</div>
				</div>
    </form>
</body>
</html>
