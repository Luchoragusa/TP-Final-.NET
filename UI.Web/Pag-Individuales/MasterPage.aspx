﻿<%@ Master Language="C#" AutoEventWireup="true" 
CodeFile="LabLoginMasterPage.master.cs" 
Inherits="LabLoginMasterPage" %> 
 
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN" 
"http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd"> 
<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server"> 
    <title>Untitled Page</title> 
</head> 
<body> 
    <form id="form1" runat="server"> 
    <table border="1" cellpadding="0" cellspacing="0" width="100%" height="100%"> 
        <!-- site header --> 
        <tr> 
            <td valign="top" align="left">              
                <asp:contentplaceholder id="Contentplaceholder2" runat="server" /> 
            </td>
        </tr> 
         <!-- site mid --> 
        <tr>      
            <td valign="top" align="left">              
                <!-- this is the placeholder for the page content --> 
                <asp:contentplaceholder id="PageContent" runat="server" /> 
            </td>
        </tr> 
         
        <!-- site footer --> 
        <tr> 
            <td valign="top" align="left">              
                <asp:contentplaceholder id="Contentplaceholder1" runat="server" /> 
            </td>
        </tr> 

    </table> 
    </form> 
</body> 
</html>