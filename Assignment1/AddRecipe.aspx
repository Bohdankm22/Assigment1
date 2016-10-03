<%@ Page Title="Add a recipe" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddRecipe.aspx.cs" Inherits="Assignment1.AddRecipe" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
    <div style="width: 800px">
        <p>
            <asp:Label ID="RecipeLabelName" runat="server" Text="Recipe Name"/>
            <input type="text" runat="server" ID="RecipeInputName" style="position: absolute; left: 250px; "/>&nbsp;</p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Recipe description"/>
            &nbsp;<input runat="server" ID="RecipeInputDescription" style="position: absolute; left: 250px; top: 186px; height: 51px; width: 194px;" /></p>
        <p>&nbsp;</p>
        <p>&nbsp;</p>
        <p>&nbsp;</p>
        <p>
            <asp:Button ID="RecipeSaveButton" Text="Save recipe" runat="server" OnClick="RecipeSave"/>
        </p>
        <br />
        <p>
            <asp:Label ID="SuccessfullySaved" runat="server" ForeColor="#00CC00" />
        </p>
    </div>
</asp:Content>
