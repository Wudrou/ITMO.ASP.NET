<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Start.aspx.cs" Inherits="RSVP.Start" MasterPageFile="~/Site.Master" %>

<asp:Content ID="MainContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="Styles.css" />
    <div class="rek">
        <h1>Приглашение на семинар<asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
        </h1>
        <p>Вы приглашены на наш семинар</p>
        <p>Подтвердите свое согласие, пройдя регистрацию</p>
    </div>
    <div class="info">
        Семинар состоится 1 июня 2021 года в 10.00
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Timer runat="server" Interval="1000"></asp:Timer>
                <%DateTime dataseminar = new DateTime(2021,6,1,10,00,0);
                    DateTime dnow = DateTime.Now;
                    int rd = (dataseminar - dnow).Days;
                    int rm = (dataseminar - dnow).Minutes;
                    int rsec = (dataseminar - dnow).Seconds;%>
                <h3>До семинара осталось <%=rd.ToString()%> дн., <%=rm.ToString()%> мин. и <%=rsec.ToString()%> с.</h3>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
</asp:Content>

        
