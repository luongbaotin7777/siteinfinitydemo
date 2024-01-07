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

namespace SitefinityWebApp.ResourcePackages.Bootstrap5.MVC.Views.Registration
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    
    #line 3 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
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
    
    #line 9 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
    using Telerik.Sitefinity.Frontend.Identity.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 10 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
    using Telerik.Sitefinity.Frontend.Identity.Mvc.Models.Registration;
    
    #line default
    #line hidden
    
    #line 4 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 5 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 8 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
    using Telerik.Sitefinity.Services;
    
    #line default
    #line hidden
    
    #line 6 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
    using Telerik.Sitefinity.UI.MVC;
    
    #line default
    #line hidden
    
    #line 7 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
    using Telerik.Sitefinity.Utilities;
    
    #line default
    #line hidden
    
    #line 11 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
    using Telerik.Sitefinity.Web;
    
    #line default
    #line hidden
    
    #line 12 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
    using Telerik.Sitefinity.Web.Utilities;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Bootstrap5/MVC/Views/Registration/Registration.RegistrationFor" +
        "m.cshtml")]
    public partial class Registration_RegistrationForm : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Identity.Mvc.Models.Registration.RegistrationViewModel>
    {

#line 137 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
public System.Web.WebPages.HelperResult FormGroupPanel(string label, Expression<Func<RegistrationViewModel, string>> expression, string descId, string inputType = "text", string classValue = null, IDictionary<string, object> additionalAttributes = null)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 138 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
 
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

WriteLiteralTo(__razor_helper_writer, " class=\"my-3\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n\r\n");

WriteLiteralTo(__razor_helper_writer, "        ");


#line 161 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
WriteTo(__razor_helper_writer, Html.LabelFor(expression, Html.Resource(label), new { @class = "form-label" }));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n\r\n");


#line 163 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
        

#line default
#line hidden

#line 163 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
         switch (inputType)
        {
            case "text":
                

#line default
#line hidden

#line 166 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
WriteTo(__razor_helper_writer, Html.TextBoxFor(expression, attributes));


#line default
#line hidden

#line 166 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                                                        ;
                break;

            case "textarea":
                

#line default
#line hidden

#line 170 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
WriteTo(__razor_helper_writer, Html.TextAreaFor(expression, attributes));


#line default
#line hidden

#line 170 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                                                         ;
                break;

            case "password":
                

#line default
#line hidden

#line 174 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
WriteTo(__razor_helper_writer, Html.PasswordFor(expression, attributes));


#line default
#line hidden

#line 174 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                                                         ;
                break;

            default:
                break;
        }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n");


#line 181 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
        

#line default
#line hidden

#line 181 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
         if (hasValidationMessage)
        {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <div");

WriteAttributeTo(__razor_helper_writer, "id", Tuple.Create(" id=\'", 7892), Tuple.Create("\'", 7919)

#line 183 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
, Tuple.Create(Tuple.Create("", 7897), Tuple.Create<System.Object, System.Int32>(Html.UniqueId(descId)

#line default
#line hidden
, 7897), false)
);

WriteLiteralTo(__razor_helper_writer, " class=\"text-danger\"");

WriteLiteralTo(__razor_helper_writer, " role=\"alert\"");

WriteLiteralTo(__razor_helper_writer, " aria-live=\"assertive\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n");

WriteLiteralTo(__razor_helper_writer, "                ");


#line 184 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
WriteTo(__razor_helper_writer, Html.ValidationMessageFor(expression));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n            </div>\r\n");


#line 186 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
        }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    </div>\r\n");


#line 188 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"


#line default
#line hidden
});

#line 188 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
}
#line default
#line hidden

#line 190 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
public System.Web.WebPages.HelperResult GetProviderCssClass(String name)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 191 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
 
    if (name.Contains("facebook"))
    {
        

#line default
#line hidden

#line 194 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
WriteTo(__razor_helper_writer, Html.HtmlSanitize("btn-outline-primary"));


#line default
#line hidden

#line 194 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                                                 ;
    }
    else if (name.Contains("google"))
    {
        

#line default
#line hidden

#line 198 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
WriteTo(__razor_helper_writer, Html.HtmlSanitize("btn-outline-danger"));


#line default
#line hidden

#line 198 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                                                ;
    }
    else if (name.Contains("microsoft"))
    {
        

#line default
#line hidden

#line 202 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
WriteTo(__razor_helper_writer, Html.HtmlSanitize("btn-outline-info"));


#line default
#line hidden

#line 202 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                                              ;
    }
    else if (name.Contains("twitter"))
    {
        

#line default
#line hidden

#line 206 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
WriteTo(__razor_helper_writer, Html.HtmlSanitize("btn-outline-info"));


#line default
#line hidden

#line 206 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                                              ;
    }
    else
    {
        

#line default
#line hidden

#line 210 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
WriteTo(__razor_helper_writer, Html.HtmlSanitize("btn-outline-dark"));


#line default
#line hidden

#line 210 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                                              ;
    }


#line default
#line hidden
});

#line 212 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
}
#line default
#line hidden

        public Registration_RegistrationForm()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

WriteLiteral("\r\n");

            
            #line 15 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
Write(Html.Script(ScriptRef.JQuery, "jquery", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 16 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
Write(Html.Script("//cdnjs.cloudflare.com/ajax/libs/jquery-validate/1.19.5/jquery.validate.js", "jquery", false, new List<KeyValuePair<string, string>>() { HtmlConstants.CrossOriginHtmlAttribute }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 17 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
Write(Html.Script("//cdnjs.cloudflare.com/ajax/libs/jquery-validation-unobtrusive/4.0.0/jquery.validate.unobtrusive.min.js", "jquery", false, new List<KeyValuePair<string, string>>() { HtmlConstants.CrossOriginHtmlAttribute }));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 19 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
  
    var hasExternalProviders = Model.ExternalProviders != null && Model.ExternalProviders.Count() > 0;
    var rowClass = hasExternalProviders ? "row" : "";
    var colClass = hasExternalProviders ? "col-lg-6" : "";

    if (!Model.Profile.ContainsKey("FirstName"))
    {
        Model.Profile["FirstName"] = "";
    }

    if (!Model.Profile.ContainsKey("LastName"))
    {
        Model.Profile["LastName"] = "";
    }

    HtmlHelper.ClientValidationEnabled = true;
    HtmlHelper.UnobtrusiveJavaScriptEnabled = true;

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 1581), Tuple.Create("\"", 1604)
            
            #line 38 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
, Tuple.Create(Tuple.Create("", 1589), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 1589), false)
);

WriteLiteral(">\r\n");

            
            #line 39 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
    
            
            #line default
            #line hidden
            
            #line 39 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
     if ((Request.QueryStringGet("ShowActivationMsg") == "true") ||
     (ViewBag.ShowActivationMsg is bool && ViewBag.ShowActivationMsg))
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"alert alert-warning\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-live=\"assertive\"");

WriteLiteral(">\r\n            <h3>");

            
            #line 43 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
           Write(Html.Resource("VisitYourEmail"));

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n            <p>");

            
            #line 44 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
          Write(string.Format(Html.Resource("ActivationLinkHasBeenSent"), Model.Email));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n        </div>\r\n");

            
            #line 46 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"


            
            #line default
            #line hidden
WriteLiteral("        <a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral(" data-sf-role=\"sendAgainLink\"");

WriteLiteral(" class=\"btn btn-primary\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 48 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
       Write(Html.Resource("SendAgain"));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <span");

WriteLiteral(" class=\"visually-hidden\"");

WriteLiteral(">");

            
            #line 49 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                                     Write(Html.Resource("SendActivationLinkAgain"));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n        </a>\r\n");

            
            #line 51 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"


            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" data-sf-role=\"confirmationResendInfo\"");

WriteLiteral(" style=\"display:none;\"");

WriteLiteral(">\r\n            <p");

WriteLiteral(" class=\"alert alert-warning\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-live=\"assertive\"");

WriteLiteral(">");

            
            #line 53 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                                                                         Write(string.Format(Html.Resource("ActivationLinkHasBeenSentAgain"), Model.Email));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n        </div>\r\n");

            
            #line 55 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"


            
            #line default
            #line hidden
WriteLiteral("        <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"sf-resend-confirmation-endpoint-url\"");

WriteAttribute("value", Tuple.Create(" value=\"", 2572), Tuple.Create("\"", 2646)
            
            #line 56 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
       , Tuple.Create(Tuple.Create("", 2580), Tuple.Create<System.Object, System.Int32>(Url.Action("ResendConfirmationEmail", new { email = Model.Email})
            
            #line default
            #line hidden
, 2580), false)
);

WriteLiteral(" />\r\n");

            
            #line 57 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"

        
            
            #line default
            #line hidden
            
            #line 58 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
   Write(Html.Script(Url.WidgetContent("Mvc/Scripts/Registration/registration-form.js"), "bottom", false));

            
            #line default
            #line hidden
            
            #line 58 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                                                                                                         
    }
    else if ((Request.QueryStringGet("ShowSuccessfulRegistrationMsg") == "true") ||
             (ViewBag.ShowSuccessfulRegistrationMsg is bool && ViewBag.ShowSuccessfulRegistrationMsg))
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"alert alert-success\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-live=\"assertive\"");

WriteLiteral(">\r\n            <h3>");

            
            #line 64 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
           Write(Html.Resource("ThankYou"));

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n            <p>");

            
            #line 65 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
          Write(Html.Resource("DefaultSuccessfulRegistrationMessage"));

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n        </div>\r\n");

            
            #line 67 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
    }
    else
    {
        using (Html.BeginFormSitefinity(true))
        {
            
            
            #line default
            #line hidden
            
            #line 72 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
       Write(Html.ValidationSummary(true));

            
            #line default
            #line hidden
            
            #line 72 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                                         ;


            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteAttribute("class", Tuple.Create(" class=\"", 3327), Tuple.Create("\"", 3348)
            
            #line 74 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
, Tuple.Create(Tuple.Create("", 3335), Tuple.Create<System.Object, System.Int32>(rowClass
            
            #line default
            #line hidden
, 3335), false)
, Tuple.Create(Tuple.Create(" ", 3344), Tuple.Create("m-0", 3345), true)
);

WriteLiteral(">\r\n                <div");

WriteAttribute("class", Tuple.Create(" class=\"", 3372), Tuple.Create("\"", 3389)
            
            #line 75 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
, Tuple.Create(Tuple.Create("", 3380), Tuple.Create<System.Object, System.Int32>(colClass
            
            #line default
            #line hidden
, 3380), false)
);

WriteLiteral(">\r\n                    <h3");

WriteLiteral(" class=\"mb-4\"");

WriteLiteral(">");

            
            #line 76 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                                Write(Html.Resource("Registration"));

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n\r\n");

            
            #line 78 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 78 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                     if (!string.IsNullOrEmpty(ViewBag.Error))
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <div");

WriteLiteral(" class=\"alert alert-danger\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-live=\"assertive\"");

WriteLiteral(">");

            
            #line 80 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                                                                                      Write(ViewBag.Error);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 81 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                    ");

            
            #line 83 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
               Write(Html.HiddenFor(m => m.RequiresQuestionAndAnswer));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

WriteLiteral("                    ");

            
            #line 85 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
               Write(FormGroupPanel("FirstName", m => m.Profile["FirstName"], "RegistrationFirstName", "text", null, HtmlHelper.ClientValidationEnabled ? RegistrationHelper.GetProfileValidationAttributes("FirstName") : null));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

WriteLiteral("                    ");

            
            #line 87 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
               Write(FormGroupPanel("LastName", m => m.Profile["LastName"], "RegistrationLastName", "text", null, HtmlHelper.ClientValidationEnabled ? RegistrationHelper.GetProfileValidationAttributes("LastName") : null));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

WriteLiteral("                    ");

            
            #line 89 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
               Write(FormGroupPanel("Email", m => m.Email, "RegistrationEmail", "text", null, new Dictionary<string, object>() { { "type", "email" } }));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

WriteLiteral("                    ");

            
            #line 91 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
               Write(FormGroupPanel("Password", m => m.Password, "RegistrationPassword", "password"));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

WriteLiteral("                    ");

            
            #line 93 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
               Write(FormGroupPanel("ReTypePassword", m => m.ReTypePassword, "RegistrationReTypePassword", "password"));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 95 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 95 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                     if (Model.RequiresQuestionAndAnswer)
                    {
                        
            
            #line default
            #line hidden
            
            #line 97 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                   Write(FormGroupPanel("Question", m => m.Question, "RegistrationQuestion"));

            
            #line default
            #line hidden
            
            #line 97 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                                                                                            

                        
            
            #line default
            #line hidden
            
            #line 99 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                   Write(FormGroupPanel("Answer", m => m.Answer, "RegistrationAnswer"));

            
            #line default
            #line hidden
            
            #line 99 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                                                                                      
                    }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 102 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 102 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                     if (SystemManager.IsDesignMode && !SystemManager.IsPreviewMode)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-primary\"");

WriteLiteral(" disabled>");

            
            #line 104 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                                                                          Write(Html.Resource("Register"));

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n");

            
            #line 105 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                    }
                    else
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"btn btn-primary\"");

WriteLiteral(" ");

            
            #line 108 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                                                                  Write(SystemManager.IsDesignMode ? "disabled" : "");

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 108 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                                                                                                                 Write(Html.Resource("Register"));

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n");

            
            #line 109 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                    ");

            
            #line 110 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
               Write(Html.AddSitefinityAntiforgeryToken());

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"mt-3\"");

WriteLiteral(">\r\n                        <div>Already registered?</div>\r\n                      " +
"  <a");

WriteAttribute("href", Tuple.Create(" href=\"", 5547), Tuple.Create("\"", 5573)
            
            #line 113 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
, Tuple.Create(Tuple.Create("", 5554), Tuple.Create<System.Object, System.Int32>(Model.LoginPageUrl
            
            #line default
            #line hidden
, 5554), false)
);

WriteLiteral(">");

            
            #line 113 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                                                 Write(Html.Resource("BackToLogin"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                    </div>\r\n                </div>\r\n\r\n");

            
            #line 117 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                
            
            #line default
            #line hidden
            
            #line 117 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                 if (Model.ExternalProviders != null && Model.ExternalProviders.Count() > 0)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"col-lg-6\"");

WriteLiteral(">\r\n                        <h3");

WriteLiteral(" class=\"mb-3\"");

WriteLiteral(">");

            
            #line 120 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                                    Write(Html.Resource("ConnectWith"));

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n                        <div");

WriteLiteral(" class=\"d-grid gap-3 my-3\"");

WriteLiteral(">\r\n");

            
            #line 122 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 122 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                             foreach (var provider in Model.ExternalProviders)
                            {
                                var classToBeAdd = "btn btn-lg border " + GetProviderCssClass(provider.Value);

                                
            
            #line default
            #line hidden
            
            #line 126 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                           Write(Html.ActionLink(provider.Key, "LoginExternalProvider", new { model = provider.Key }, new { @class = classToBeAdd }));

            
            #line default
            #line hidden
            
            #line 126 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                                                                                                                                                    

                            }

            
            #line default
            #line hidden
WriteLiteral("                        </div>\r\n                    </div>\r\n");

            
            #line 131 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </div>\r\n");

            
            #line 133 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Registration\Registration.RegistrationForm.cshtml"
        }
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n\r\n");

WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
