﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="Assignment1.Search" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label runat="server" Text="Search"/>
    <input id="searchLine" runat="server" />
    <asp:Button runat="server" id="searchRec" onClick="searchRecipes" Text="Search recipes"/>
    <br>

    <asp:ListView runat="server" ID="ListView1">
      <LayoutTemplate>
        <table runat="server" id="table1" >
            <tr>
                <td>
                    <span><b>Name</b></span>
                </td>
                <td>
                    <span><b>Description</b></span>
                </td>
            </tr>
          <tr runat="server" id="itemPlaceholder" ></tr>
        </table>
      </LayoutTemplate>
      <ItemTemplate>
        <tr runat="server">
          <td runat="server">
            <%-- Data-bound content. --%>
            <asp:Label ID="NameLabel" runat="server" Text='<%#Eval("Name") %>' />
          </td>
          <td runat="server">
            <asp:Label ID="Label2" runat="server" Text='<%#Eval("Description") %>' />
          </td>
        </tr>
      </ItemTemplate>
    </asp:ListView>
</asp:Content>