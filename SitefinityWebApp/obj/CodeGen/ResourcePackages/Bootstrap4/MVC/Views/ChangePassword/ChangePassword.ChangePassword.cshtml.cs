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

namespace SitefinityWebApp.ResourcePackages.Bootstrap4.MVC.Views.ChangePassword
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    
    #line 3 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
    using System.Linq.Expressions;
    
    #line default
    #line hidden
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
    
    #line 6 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
    using Telerik.Sitefinity.Frontend.Identity.Mvc.Models.ChangePassword;
    
    #line default
    #line hidden
    
    #line 5 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 7 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
    using Telerik.Sitefinity.Services;
    
    #line default
    #line hidden
    
    #line 4 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
    using Telerik.Sitefinity.UI.MVC;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Bootstrap4/MVC/Views/ChangePassword/ChangePassword.ChangePassw" +
        "ord.cshtml")]
    public partial class ChangePassword_ChangePassword : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Identity.Mvc.Models.ChangePassword.ChangePasswordViewModel>
    {

#line 47 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
public System.Web.WebPages.HelperResult FormGroupPanel(string label, Expression<Func<ChangePasswordViewModel, string>> expression, string descId, string inputType = "text", string classValue = null, IDictionary<string, object> additionalAttributes = null)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 48 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
 
    var hasValidationMessage = Html.ValidationMessageFor(expression) != null;
    var attributes = new Dictionary<string, object>();
    var cls = "form-control";

    if (classValue != null)
    {
        cls += " " + classValue;
    }

    attributes.Add("class", cls);

    if (hasValidationMessage)
    {
        attributes.Add("aria-describedby", Html.UniqueId(descId));
    }
    if (additionalAttributes != null)
    {
        attributes = attributes.Concat(additionalAttributes).ToDictionary(x => x.Key, x => x.Value);
    }



#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <div");

WriteLiteralTo(__razor_helper_writer, " class=\"form-group\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n\r\n");

WriteLiteralTo(__razor_helper_writer, "        ");


#line 71 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
WriteTo(__razor_helper_writer, Html.LabelFor(expression, Html.Resource(label)));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n\r\n");


#line 73 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
        

#line default
#line hidden

#line 73 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
         switch (inputType)
        {
            case "text":
                

#line default
#line hidden

#line 76 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
WriteTo(__razor_helper_writer, Html.TextBoxFor(expression, attributes));


#line default
#line hidden

#line 76 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
                                                        ;
                break;

            case "textarea":
                

#line default
#line hidden

#line 80 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
WriteTo(__razor_helper_writer, Html.TextAreaFor(expression, attributes));


#line default
#line hidden

#line 80 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
                                                         ;
                break;

            case "password":
                

#line default
#line hidden

#line 84 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
WriteTo(__razor_helper_writer, Html.PasswordFor(expression, attributes));


#line default
#line hidden

#line 84 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
                                                         ;
                break;

            default:
                break;
        }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n");


#line 91 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
        

#line default
#line hidden

#line 91 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
         if (hasValidationMessage)
        {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <div");

WriteAttributeTo(__razor_helper_writer, "id", Tuple.Create(" id=\'", 3132), Tuple.Create("\'", 3159)

#line 93 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
, Tuple.Create(Tuple.Create("", 3137), Tuple.Create<System.Object, System.Int32>(Html.UniqueId(descId)

#line default
#line hidden
, 3137), false)
);

WriteLiteralTo(__razor_helper_writer, " class=\"text-danger\"");

WriteLiteralTo(__razor_helper_writer, " role=\"alert\"");

WriteLiteralTo(__razor_helper_writer, " aria-live=\"assertive\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n                <span");

WriteLiteralTo(__razor_helper_writer, " class=\"form-text\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 94 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
          WriteTo(__razor_helper_writer, Html.ValidationMessageFor(expression));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</span>\r\n            </div>\r\n");


#line 96 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
        }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    </div>\r\n");


#line 98 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"


#line default
#line hidden
});

#line 98 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
}
#line default
#line hidden

        public ChangePassword_ChangePassword()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 329), Tuple.Create("\"", 352)
            
            #line 9 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
, Tuple.Create(Tuple.Create("", 337), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 337), false)
);

WriteLiteral(">\r\n");

            
            #line 10 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
    
            
            #line default
            #line hidden
            
            #line 10 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
     if (Model.PasswordChanged)
    {

            
            #line default
            #line hidden
WriteLiteral("        <h3");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-live=\"assertive\"");

WriteLiteral(">");

            
            #line 12 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
                                          Write(Html.Resource("ChangePasswordSuccess"));

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n");

            
            #line 13 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
    }
    else
    {

            
            #line default
            #line hidden
WriteLiteral("        <h3>");

            
            #line 16 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
       Write(Html.Resource("ChangePasswordHeader"));

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n");

            
            #line 17 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
        
        if (!string.IsNullOrEmpty(Model.ExternalProviderName))
        {

            
            #line default
            #line hidden
WriteLiteral("            <div>\r\n");

WriteLiteral("                ");

            
            #line 21 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
           Write(string.Format(Html.Resource("ExternalProviderMessage"), Model.ExternalProviderName));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n");

            
            #line 23 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
        }
        else
        {
            using (Html.BeginFormSitefinity("SetChangePassword", "ChangePassword"))
            {
                if (!string.IsNullOrEmpty(Model.Error))
                {

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"alert alert-danger\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-live=\"assertive\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 31 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
                   Write(Model.Error);

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n");

            
            #line 33 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
                }

                
            
            #line default
            #line hidden
            
            #line 35 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
           Write(FormGroupPanel("ChangePasswordOldPassword", u => u.OldPassword, "ChangePasswordOld", "password"));

            
            #line default
            #line hidden
            
            #line 35 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
                                                                                                                 

                
            
            #line default
            #line hidden
            
            #line 37 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
           Write(FormGroupPanel("ChangePasswordNewPassword", u => u.NewPassword, "ChangePasswordNew", "password"));

            
            #line default
            #line hidden
            
            #line 37 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
                                                                                                                 

                
            
            #line default
            #line hidden
            
            #line 39 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
           Write(FormGroupPanel("ChangePasswordRepeatPassword", u => u.RepeatPassword, "ChangePasswordRepeat", "password"));

            
            #line default
            #line hidden
            
            #line 39 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
                                                                                                                           


            
            #line default
            #line hidden
WriteLiteral("                <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"btn btn-primary\"");

WriteLiteral(" ");

            
            #line 41 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
                                                          Write(SystemManager.IsDesignMode ? "disabled" : "");

            
            #line default
            #line hidden
WriteLiteral(" >");

            
            #line 41 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
                                                                                                          Write(Html.Resource("ChangePasswordSaveButton"));

            
            #line default
            #line hidden
WriteLiteral("</button> \r\n");

            
            #line 42 "..\..\ResourcePackages\Bootstrap4\MVC\Views\ChangePassword\ChangePassword.ChangePassword.cshtml"
            }
        }
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n\r\n");

        }
    }
}
#pragma warning restore 1591
