<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PostMessage.aspx.cs" Inherits="Dissertation__Weak_.Members.PostMessage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Post Message</title>
    <link rel="stylesheet" type="text/css" href="../StyleSheet.css"/>
</head>
<body>
    
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
			
			<form id="postMessage" runat="server"> <!--<<<< Form Begins -->
				<div class="formRow">
					<h3>Post a Message</h3>
				</div>
				<div class="formRow">
					<div class="rowLeft">
						<h2>Private Message?</h2>
					</div>
					<div class="rowRight">
						<asp:CheckBox runat="server" ID="chk_Private" AutoPostBack="true" OnCheckedChanged="chk_Private_CheckedChanged"/> <!--<<<< Private Message Checkbox  -->
					</div>
				</div>
                <asp:Panel ID="pnl_UserPanel" runat="server" >
                    <div class="formRow">
					    <div class="rowLeft">
						    <h2>Username</h2>
					    </div>
					    <div class="rowRight">
						    <input type="text"  runat="server" id="txt_Username"/> <!--<<<< Private Message Username  -->
					    </div>
				    </div>
                </asp:Panel>
				<div class="formRow">
					<div class="rowLeft">
						<h4>Message</h4>
					</div>
					<div class="rowRight">
						<textarea rows="2" cols="50" runat="server" id="txt_Message"></textarea><!--<<<< Message Input Textarea -->
					</div>
				</div>
				<div class="formRow">
					<div class="rowLeft">
						<asp:Button runat="server" Text="Sumbit" value="Submit" ID="btn_SubmitMessage" OnClick="btn_SubmitMessage_Click" /> <!--<<<< Submit Button -->
					</div>
					<div class="rowRight">
						<asp:Label runat="server" ID="lbl_Valid" /><!--<<<< Validation Output Area -->
					</div>
				</div>
			</form>  <!--<<<< Form Ends -->
			
		</div>
</body>
</html>
