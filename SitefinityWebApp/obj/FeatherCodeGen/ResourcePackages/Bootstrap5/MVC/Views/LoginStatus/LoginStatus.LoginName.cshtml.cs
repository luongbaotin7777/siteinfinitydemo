#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SitefinityWebApp.ResourcePackages.Bootstrap5.MVC.Views.LoginStatus
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 3 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 4 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 5 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
    using Telerik.Sitefinity.Mvc.Proxy;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/LoginStatus/LoginStatus.LoginName.cshtml")]
    public partial class LoginStatus_LoginName : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Identity.Mvc.Models.LoginStatus.LoginStatusViewModel>
    {
        public LoginStatus_LoginName()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 7 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
  
var SignOutUrl = string.Concat(Url.Action("SignOut"),string.Format("?{0}={1}", MvcControllerProxy.ControllerKey, ViewData[MvcControllerProxy.ControllerKey]));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 395), Tuple.Create("\"", 418)
            
            #line 11 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
, Tuple.Create(Tuple.Create("", 403), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 403), false)
);

WriteLiteral(">\r\n    <div");

WriteLiteral(" data-sf-role=\"sf-logged-in-view\"");

WriteLiteral(" style=\"display: none\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"d-flex gap-2\"");

WriteLiteral(">\r\n            <span>");

            
            #line 14 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
             Write(Html.Resource("LoggedAs"));

            
            #line default
            #line hidden
WriteLiteral(" </span>\r\n            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 592), Tuple.Create("\"", 629)
            
            #line 15 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
, Tuple.Create(Tuple.Create("", 599), Tuple.Create<System.Object, System.Int32>(Model.ProfilePageUrl ?? "#"
            
            #line default
            #line hidden
, 599), false)
);

WriteLiteral(" data-sf-role=\"sf-logged-in-name\"");

WriteLiteral(" class=\"link-dark\"");

WriteLiteral("></a>\r\n            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 702), Tuple.Create("\"", 720)
            
            #line 16 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
, Tuple.Create(Tuple.Create("", 709), Tuple.Create<System.Object, System.Int32>(SignOutUrl
            
            #line default
            #line hidden
, 709), false)
);

WriteLiteral(">");

            
            #line 16 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
                             Write(Html.Resource("Logout"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n        </div>\r\n    </div>\r\n\r\n    <div");

WriteLiteral(" data-sf-role=\"sf-logged-out-view\"");

WriteLiteral(" style=\"display: none\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"d-flex gap-2\"");

WriteLiteral(">\r\n            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 899), Tuple.Create("\"", 934)
            
            #line 22 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
, Tuple.Create(Tuple.Create("", 906), Tuple.Create<System.Object, System.Int32>(Model.LoginPageUrl ?? "#"
            
            #line default
            #line hidden
, 906), false)
);

WriteLiteral(">");

            
            #line 22 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
                                              Write(Html.Resource("Login"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 979), Tuple.Create("\"", 1021)
            
            #line 23 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
, Tuple.Create(Tuple.Create("", 986), Tuple.Create<System.Object, System.Int32>(Model.RegistrationPageUrl ?? "#"
            
            #line default
            #line hidden
, 986), false)
);

WriteLiteral(">");

            
            #line 23 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
                                                     Write(Html.Resource("RegisterNow"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"sf-status-json-endpoint-url\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1159), Tuple.Create("\"", 1190)
            
            #line 28 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
, Tuple.Create(Tuple.Create("", 1167), Tuple.Create<System.Object, System.Int32>(Model.StatusServiceUrl
            
            #line default
            #line hidden
, 1167), false)
);

WriteLiteral("/>\r\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"sf-logout-redirect-url\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1253), Tuple.Create("\"", 1281)
            
            #line 29 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
, Tuple.Create(Tuple.Create("", 1261), Tuple.Create<System.Object, System.Int32>(Model.LogoutPageUrl
            
            #line default
            #line hidden
, 1261), false)
);

WriteLiteral("/>\r\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"sf-is-design-mode-value\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1345), Tuple.Create("\"", 1385)
            
            #line 30 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
, Tuple.Create(Tuple.Create("", 1353), Tuple.Create<System.Object, System.Int32>(ViewBag.IsDesignMode.ToString()
            
            #line default
            #line hidden
, 1353), false)
);

WriteLiteral(" />\r\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"sf-allow-windows-sts-login\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1453), Tuple.Create("\"", 1499)
            
            #line 31 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
, Tuple.Create(Tuple.Create("", 1461), Tuple.Create<System.Object, System.Int32>(Model.AllowWindowsStsLogin.ToString()
            
            #line default
            #line hidden
, 1461), false)
);

WriteLiteral(" />\r\n\r\n");

            
            #line 33 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/LoginStatus/login-status.js"), "bottom", false));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
