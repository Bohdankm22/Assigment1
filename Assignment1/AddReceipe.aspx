<%@ Page Title="Add a recipe" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddReceipe.aspx.cs" Inherits="Assignment1.AddReceipe" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
    <p>
        <asp:Label ID="RecipeLabelName" runat="server" Text="Recipe Name"/>
        &nbsp;<input type="text" runat="server" ID="RecipeInputName"/></p>
    <p>
        <asp:Label ID="Label2" runat="server" Text="Recipe description"/>
        <input type="text" runat="server" ID="RecipeInputDescription"/>
    </p>
    <asp:Button ID="RecipeSaveButton" Text="Save recipe" runat="server" OnClick="RecipeSave"/>
    <br />
    <p>
        <asp:Label ID="SuccessfullySaved" runat="server" ForeColor="#00CC00" />
    </p>
</asp:Content>
