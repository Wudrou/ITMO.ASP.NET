<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SummaryBD.aspx.cs" Inherits="RSVP.SummaryBD" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Список участников</h2>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="LinqDataSource1">
        <Columns>
            <asp:BoundField DataField="Name" HeaderText="Имя" ReadOnly="True" SortExpression="Name" />
            <asp:BoundField DataField="Email" HeaderText="Email" ReadOnly="True" SortExpression="Email" />
            <asp:BoundField DataField="Phone" HeaderText="Телефон" ReadOnly="True" SortExpression="Phone" />
            <asp:CheckBoxField DataField="WillAttend" HeaderText="Делает доклад" ReadOnly="True" SortExpression="WillAttend" />
            <asp:BoundField DataField="Rdata" HeaderText="Дата регистрации" ReadOnly="True" SortExpression="Rdata" />
        </Columns>
        </asp:GridView>
        <asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="RSVP.SampleContext" EntityTypeName="" Select="new (Name, Email, Phone, WillAttend, Rdata, Reports)" TableName="GuestResponses">
        </asp:LinqDataSource>
</asp:Content>
