<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Dissertation__Weak_.Members.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home</title>
    <link rel="stylesheet" type="text/css" href="../StyleSheet.css"/>
</head>
<body>
    <form id="form1" runat="server">
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
                <div class="link">
                    <asp:DropDownList ID="dd_MessageType" runat="server" OnSelectedIndexChanged="dd_MessageType_SelectedIndexChanged" AutoPostBack="True">
                        <asp:ListItem Text="Public" Value="Public"/>
                        <asp:ListItem Text="Private" Value="Private"/>
                    </asp:DropDownList>
                </div>
			</div>
            <asp:GridView ID="gvMessage" runat="server" AutoGenerateColumns="false" Width="100%">
                <HeaderStyle CssClass="gvHeader" />
                <Columns>
                    <asp:BoundField HeaderText="User" DataField="username" ItemStyle-CssClass="gvUsername"/>
                    <asp:BoundField HeaderText="Message" DataField="MessageBody" ItemStyle-CssClass="gvMessageBody" />
                </Columns>
            </asp:GridView>
		</div>
        
    </form>

</body>
</html>
