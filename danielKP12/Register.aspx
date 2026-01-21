<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <h1> Register to Daniel kerenpaz's website</h1>

    <form name="example" method="post" runat="server">
        <table width="50%" border="0">
            <tr>
                <td>שם פרטי:</td>
                <td>
                    <input type="text" name="FirstName" id="FirstName">
                </td>
            </tr>
            <tr>
                <td> שם משפחה:</td>
                <td>
                    <input type="text" name="LastName" id="LastName">
                </td>
            </tr>
                  <tr>
          <td>אימייל </td>
          <td>
              <input type="text" name="Email id="Email">
          </td>
      </tr>
                  <tr>
          <td>סיסמה</td>
          <td>
              <input type="text" name="Password" id="Password">
          </td>
      </tr>
           
            <tr>
    <td>
        <button type ="submit">הגש</button>
    </td>
</tr>

        </table>

    </form>
</asp:Content>

