﻿<%@ Page Title="Item Details" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ItemDetail.aspx.cs" Inherits="Comp229_TeamAssign.ItemDetail" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="main" align="center">
        <h2><%: Title %></h2>
        <div class="col-md-2">
        </div>
        <div class="col-md-8">
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <div class="characterBlock">
                        <asp:Image ID="itemImg" runat="server" Width="200px" ImageUrl='<%# Eval("ImgUrl") %>' />
                    </div>
                    <div class="characterBlock">
                        <p>Name: <%# Eval("Name") %></p>
                        <p>Price: <%# Eval("Price") %></p>
                        <p>Quantity: <%# Eval("Quantity") %></p>
                        <p>Score: <%# Eval("Score") %></p>
                        <p>Description: <%# Eval("Description") %></p>
                    </div>
                    
                </ItemTemplate>
               

            </asp:Repeater>
            <div class="characterBlock">
                <asp:Button ID="Button2" runat="server" Text="Go to Cart" OnClick="Button2_Click" Width="100%" Height="180px" BorderStyle="None" BackColor="#999999" />

            </div>
        </div>
        <div class="col-md-2">
            
        </div>
    </div>
</asp:Content>