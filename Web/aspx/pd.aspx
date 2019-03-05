<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pd.aspx.cs" Inherits="Web.aspx.pd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="../Css/BootStrap/bootstrap.min.css" rel="stylesheet" />
    <script src="../Js/Bootstrap/jquery-3.0.0.min.js"></script>
    <script src="../Js/Bootstrap/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="col-xs-12">
            <asp:Repeater runat="server" ID="rep">
                <HeaderTemplate>
                    <table class="table table-striped table-hover" style="border: 2px solid #f1f1f1;">
                        <thead>
                            <tr>
                                <%--<th>ID</th>--%>
                                <th>ID</th>
                                <th>题目</th>
                                <%--<th>答案</th>--%>
                            </tr>
                        </thead>
                </HeaderTemplate>
                <ItemTemplate>
                    <tbody>
                        <tr runat="server">
                            <%--<th id="id" runat="server"><%#Eval("Id") %></th>--%>
                            <th id="ID" runat="server">
                                <%#Eval("ksid") %>
                            </th>
                            <th id="FingerID" runat="server">
                                <%#Eval("C_content") %>
                            </th>
                            <%-- <th id="dn" runat="server" style="visibility: hidden">
                            <%#Eval("DN") %>
                        </th>--%>
                        </tr>
                    </tbody>
                </ItemTemplate>
                <FooterTemplate>
                    </table>
                </FooterTemplate>
            </asp:Repeater>

        </div>
        <div class="col-xs-12">
            <p id="dn" style="visibility: hidden">
                <%= DN()  %>
            </p>
        </div>

        <input type="button" id="on" value="显示答案" onclick="cl()" />
        <script type="text/javascript">
            function cl() {
                document.getElementById("dn").style.visibility = "visible";
            }

        </script>
    </form>
</body>
</html>
