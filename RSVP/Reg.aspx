<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reg.aspx.cs" Inherits="RSVP.Reg" MasterPageFile="~/Site.Master" UnobtrusiveValidationMode="None" %>

<asp:Content ID="MainContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="Styles.css" />
    <div>
        <h1>Приглашаем на семинар</h1>
        <p>&nbsp;</p>
    </div>
    <div>
        <label>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
        Ваше имя:</label><asp:TextBox ID="name" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="name" ErrorMessage="Заполните поле имени" ForeColor="Red">Не оставляйте поле пустым</asp:RequiredFieldValidator>
    </div>
    <div>
        <label>Ваш email:</label><asp:TextBox ID="email" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="email" ErrorMessage="Заполните поле адреса" ForeColor="Red">Не оставляйте поле пустым</asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="email" Display="Dynamic" ErrorMessage="E-mail is not in a valid format" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">Адрес введен неверно!!!</asp:RegularExpressionValidator>
    </div>
    <div>
        <label>Ваш телефон:</label><asp:TextBox ID="phone" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="phone" ErrorMessage="Заполните поле ввода телефона" ForeColor="Red">Не оставляйте поле пустым</asp:RequiredFieldValidator>
    </div>
    <div>
        <label>Вы будете делать доклад?</label> <asp:CheckBox ID="CheckBoxYN" runat="server" />
    </div>
    <div>
        <button type="submit">Отправить ответ на приглашение RSVP</button>
    </div>
</asp:Content>
    
