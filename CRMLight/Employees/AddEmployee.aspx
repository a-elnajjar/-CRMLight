<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddEmployee.aspx.cs" Inherits="CRMLight.Employees.AddEmployee" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <fieldset>
        <div class="control-group">
            <label class="control-label" for="inputType">Company</label>
            <div class="controls">

                <asp:TextBox ID="txtbCompany" runat="server"></asp:TextBox>
            </div>
            <label class="control-label" for="inputType">FirstName</label>
            <div class="controls">
                <asp:TextBox ID="txtbFirstName" runat="server"></asp:TextBox>
            </div>
            <label class="control-label" for="inputType">LastName</label>
            <div class="controls">
                <asp:TextBox ID="txtbLastName" runat="server"></asp:TextBox>
            </div>
            <label class="control-label" for="inputType">Email</label>
            <div class="controls">
                <asp:TextBox ID="txtbEmail" runat="server"></asp:TextBox>
            </div>
            <label class="control-label" for="inputType">JobTitle</label>
            <div class="controls">
                <asp:TextBox ID="txtbJobTitle" runat="server"></asp:TextBox>
            </div>
            <label class="control-label" for="inputType">Workphone</label>
            <div class="controls">
                <asp:TextBox ID="txtbWorkphone" runat="server"></asp:TextBox>
            </div>
            <label class="control-label" for="inputType">Homephone</label>
            <div class="controls">
                <asp:TextBox ID="txtbHomephone" runat="server"></asp:TextBox>
            </div>
                      <label class="control-label" for="inputType">Mobile Phone</label>
            <div class="controls">
                <asp:TextBox ID="txtbMobilePhone" runat="server"></asp:TextBox>
            </div>
                      <label class="control-label" for="inputType">Fax</label>
            <div class="controls">
                <asp:TextBox ID="txtbFax" runat="server"></asp:TextBox>
            </div>
                      <label class="control-label" for="inputType">Website</label>
            <div class="controls">
                <asp:TextBox ID="txtbWebsite" runat="server"></asp:TextBox>
            </div>
        </div>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    </fieldset>
</asp:Content>
