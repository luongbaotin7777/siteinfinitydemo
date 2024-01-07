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

namespace SitefinityWebApp.ResourcePackages.Bootstrap5.MVC.Views.Form
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
    
    #line 8 "..\..MVC\Views\Form\Index.cshtml"
    using Telerik.Sitefinity.Abstractions;
    
    #line default
    #line hidden
    
    #line 4 "..\..MVC\Views\Form\Index.cshtml"
    using Telerik.Sitefinity.Frontend.Forms.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 5 "..\..MVC\Views\Form\Index.cshtml"
    using Telerik.Sitefinity.Frontend.Forms.Mvc.Models;
    
    #line default
    #line hidden
    
    #line 6 "..\..MVC\Views\Form\Index.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 7 "..\..MVC\Views\Form\Index.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 9 "..\..MVC\Views\Form\Index.cshtml"
    using Telerik.Sitefinity.Security.CSRF;
    
    #line default
    #line hidden
    
    #line 3 "..\..MVC\Views\Form\Index.cshtml"
    using Telerik.Sitefinity.UI.MVC;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/Form/Index.cshtml")]
    public partial class Index : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Forms.Mvc.Models.FormViewModel>
    {
        public Index()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<div");

WriteLiteral(" data-sf-role=\"form-container\"");

WriteAttribute("class", Tuple.Create(" class=\"", 423), Tuple.Create("\"", 446)
            
            #line 11 "..\..MVC\Views\Form\Index.cshtml"
, Tuple.Create(Tuple.Create("", 431), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 431), false)
);

WriteLiteral(">\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"form-id\"");

WriteAttribute("value", Tuple.Create(" value=\"", 497), Tuple.Create("\"", 518)
            
            #line 12 "..\..MVC\Views\Form\Index.cshtml"
, Tuple.Create(Tuple.Create("", 505), Tuple.Create<System.Object, System.Int32>(Model.FormId
            
            #line default
            #line hidden
, 505), false)
);

WriteLiteral(" name=\"FormId\"");

WriteLiteral(" />\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"marketo-settings\"");

WriteAttribute("value", Tuple.Create(" value=\"", 594), Tuple.Create("\"", 624)
            
            #line 13 "..\..MVC\Views\Form\Index.cshtml"
, Tuple.Create(Tuple.Create("", 602), Tuple.Create<System.Object, System.Int32>(Model.MarketoSettings
            
            #line default
            #line hidden
, 602), false)
);

WriteLiteral(" name=\"MarketoSettings\"");

WriteLiteral(" />\r\n\r\n");

            
            #line 15 "..\..MVC\Views\Form\Index.cshtml"
    
            
            #line default
            #line hidden
            
            #line 15 "..\..MVC\Views\Form\Index.cshtml"
      
        if (!string.IsNullOrEmpty(@ViewBag.ErrorMessage))
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"alert alert-danger\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-live=\"assertive\"");

WriteLiteral(">");

            
            #line 18 "..\..MVC\Views\Form\Index.cshtml"
                                                                          Write(ViewBag.ErrorMessage);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 19 "..\..MVC\Views\Form\Index.cshtml"
        }

        if (Model.UseAjaxSubmit)
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" data-sf-role=\"success-message\"");

WriteLiteral(" class=\"alert alert-success my-3\"");

WriteLiteral(" style=\"display: none;\"");

WriteLiteral(">");

            
            #line 23 "..\..MVC\Views\Form\Index.cshtml"
                                                                                                   Write(Model.SuccessMessage);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

WriteLiteral("            <div");

WriteLiteral(" data-sf-role=\"error-message\"");

WriteLiteral(" class=\"alert alert-danger my-3\"");

WriteLiteral(" style=\"display: none;\"");

WriteLiteral("></div>\r\n");

WriteLiteral("            <div");

WriteLiteral(" data-sf-role=\"loading-img\"");

WriteLiteral(" style=\"display:none;\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"spinner-border text-primary my-3\"");

WriteLiteral(" role=\"status\"");

WriteLiteral(">\r\n                    <span");

WriteLiteral(" class=\"visually-hidden\"");

WriteLiteral(">Loading...</span>\r\n                </div>\r\n            </div>\r\n");

            
            #line 30 "..\..MVC\Views\Form\Index.cshtml"


            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" data-sf-role=\"fields-container\"");

WriteLiteral(">\r\n                ");

WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 33 "..\..MVC\Views\Form\Index.cshtml"
           Write(Html.AddSitefinityAntiforgeryToken());

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n");

            
            #line 35 "..\..MVC\Views\Form\Index.cshtml"
        }
        else
        {
            using (Html.BeginFormSitefinity("", null, (System.Web.Routing.RouteValueDictionary)null, FormMethod.Post, Model.HtmlAttributes, true))
            {
                
            
            #line default
            #line hidden
            
            #line 40 "..\..MVC\Views\Form\Index.cshtml"
                                   
                
            
            #line default
            #line hidden
            
            #line 41 "..\..MVC\Views\Form\Index.cshtml"
           Write(Html.AddSitefinityAntiforgeryToken());

            
            #line default
            #line hidden
            
            #line 41 "..\..MVC\Views\Form\Index.cshtml"
                                                     
            }
        }

        if (Model.UseAjaxSubmit)
        {

            
            #line default
            #line hidden
WriteLiteral("            <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"ajax-submit-url\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1992), Tuple.Create("\"", 2020)
            
            #line 47 "..\..MVC\Views\Form\Index.cshtml"
, Tuple.Create(Tuple.Create("", 2000), Tuple.Create<System.Object, System.Int32>(Model.AjaxSubmitUrl
            
            #line default
            #line hidden
, 2000), false)
);

WriteLiteral(" />\r\n");

WriteLiteral("            <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"redirect-url\"");

WriteAttribute("value", Tuple.Create(" value=\"", 2086), Tuple.Create("\"", 2112)
            
            #line 48 "..\..MVC\Views\Form\Index.cshtml"
, Tuple.Create(Tuple.Create("", 2094), Tuple.Create<System.Object, System.Int32>(Model.RedirectUrl
            
            #line default
            #line hidden
, 2094), false)
);

WriteLiteral(" />\r\n");

WriteLiteral("            <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"widget-id\"");

WriteAttribute("value", Tuple.Create(" value=\"", 2175), Tuple.Create("\"", 2200)
            
            #line 49 "..\..MVC\Views\Form\Index.cshtml"
, Tuple.Create(Tuple.Create("", 2183), Tuple.Create<System.Object, System.Int32>(ViewBag.WidgetId
            
            #line default
            #line hidden
, 2183), false)
);

WriteLiteral(" name=\"WidgetId\"");

WriteLiteral(" />\r\n");

            
            #line 50 "..\..MVC\Views\Form\Index.cshtml"
            
            
            #line default
            #line hidden
            
            #line 50 "..\..MVC\Views\Form\Index.cshtml"
       Write(Html.Script(ScriptRef.JQuery, "jquery", false));

            
            #line default
            #line hidden
            
            #line 50 "..\..MVC\Views\Form\Index.cshtml"
                                                           
            
            
            #line default
            #line hidden
            
            #line 51 "..\..MVC\Views\Form\Index.cshtml"
       Write(Html.Script(Url.WidgetContent("Mvc/Scripts/Form/form.all.js"), "bottom", false));

            
            #line default
            #line hidden
            
            #line 51 "..\..MVC\Views\Form\Index.cshtml"
                                                                                            
        }
    
            
            #line default
            #line hidden
WriteLiteral("\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
