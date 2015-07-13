<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplicationTest._Default" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h3>Addition</h3>
    <asp:TextBox ID="Value1" runat="server"></asp:TextBox>
    <br />
    <asp:TextBox ID="Value2" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="buttonCalculate" Text="Calculate" runat="server" OnClick="buttonCalculate_Click" />
    <br />
    <asp:Label ID="LabelResult" runat="server" Font-Bold="True" Font-Size="12pt">No Result</asp:Label>

    <br />
    <br />
    <br />

    <h3>Personenverwaltung</h3>
    <asp:TextBox ID="NameTextBox" runat="server"></asp:TextBox>&nbsp;<asp:TextBox ID="FirstNameTextBox" runat="server"></asp:TextBox>
    <asp:Button ID="ButtonNameInsert" runat="server" Text="Add Name" OnClick="ButtonNameInsert_Click" />
    <asp:Button ID="ButtonNameRemove" runat="server" Text="Remove Name" OnClick="ButtonNameRemove_Click" />
    <br />
    <asp:ListBox ID="NameListBox" runat="server" Width="644px"></asp:ListBox>
</asp:Content>
