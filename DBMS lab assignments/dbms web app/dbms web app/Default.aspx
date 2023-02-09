<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="dbms_web_app._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div style="font-size:x-large; height: 64px; margin-top: 31px;text-align:center;">Student info Manage form</div>
   <br />

    <table class="nav-justified">
        <tr>
            <td style="width: 164px; height: 22px"></td>
            <td style="width: 112px; height: 22px">Student ID</td>
            <td style="height: 22px">
                <asp:TextBox ID="TextBox1" runat="server" Width="183px"></asp:TextBox>
            &nbsp;<asp:Button ID="Button5" runat="server" BackColor="#33CC33" BorderColor="#003300" BorderStyle="Solid" Font-Bold="True" ForeColor="Black" OnClick="Button1_Click" Text="Get" Width="70px" />
            </td>
        </tr>
        <tr>
            <td style="width: 164px">&nbsp;</td>
            <td style="width: 112px">Student Name</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" Width="183px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 164px">&nbsp;</td>
            <td style="width: 112px">Adress </td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem>USA </asp:ListItem>
                    <asp:ListItem>CANADA</asp:ListItem>
                    <asp:ListItem>UK</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 164px; height: 22px"></td>
            <td style="width: 112px; height: 22px">age</td>
            <td style="height: 22px">
                <asp:TextBox ID="TextBox5" runat="server" Width="183px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 164px; height: 22px"></td>
            <td style="width: 112px; height: 22px">Contact</td>
            <td style="height: 22px">
                <asp:TextBox ID="TextBox4" runat="server" Width="183px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 164px; height: 20px;"></td>
            <td style="width: 112px; height: 20px;"></td>
            <td style="height: 20px"></td>
        </tr>
        <tr>
            <td style="width: 164px; height: 26px"></td>
            <td style="width: 112px; height: 26px"></td>
            <td style="height: 26px">
                <asp:Button ID="Button1" runat="server" BackColor="#66FF66" BorderColor="#003300" BorderStyle="Groove" Font-Bold="True" ForeColor="Black" OnClick="Button1_Click" Text="Insert" Width="70px" />
            &nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" BackColor="#33CC33" BorderColor="#003300" BorderStyle="Solid" Font-Bold="True" ForeColor="Black" OnClick="Button1_Click" Text="Update" Width="70px" />
            &nbsp;&nbsp;
                <asp:Button ID="Button3" runat="server" BackColor="#33CC33" BorderColor="#003300" BorderStyle="Solid" Font-Bold="True" ForeColor="Black" OnClick="Button1_Click" Text="Delete" Width="70px" />
            &nbsp;<asp:Button ID="Button4" runat="server" BackColor="#33CC33" BorderColor="#003300" BorderStyle="Solid" Font-Bold="True" ForeColor="Black" OnClick="Button1_Click" Text="Search" Width="70px" />
            </td>
        </tr>
        <tr>
            <td style="width: 164px">&nbsp;</td>
            <td style="width: 112px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 164px">&nbsp;</td>
            <td style="width: 112px">&nbsp;</td>
            <td>
                <asp:GridView ID="GridView1" runat="server" Width="524px">
                </asp:GridView>
            </td>
        </tr>
    </table>

</asp:Content>
