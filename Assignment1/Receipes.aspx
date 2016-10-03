﻿<%@ Page Title="List of recipes" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Receipes.aspx.cs" Inherits="Assignment1.Receipes" %>
<%@ Register TagPrefix="rc" TagName="RecipeItem" Src="RecipeItem.ascx" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
    
    
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
