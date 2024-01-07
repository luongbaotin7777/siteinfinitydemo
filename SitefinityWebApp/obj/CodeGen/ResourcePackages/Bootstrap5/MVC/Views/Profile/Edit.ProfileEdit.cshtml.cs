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

namespace SitefinityWebApp.ResourcePackages.Bootstrap5.MVC.Views.Profile
{
    using System;
    
    #line 3 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    using System.IO;
    using System.Linq;
    
    #line 4 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
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
    
    #line 6 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
    using Telerik.Sitefinity.Frontend.Identity.Mvc.Models.Profile;
    
    #line default
    #line hidden
    
    #line 5 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 7 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 10 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
    using Telerik.Sitefinity.Services;
    
    #line default
    #line hidden
    
    #line 8 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
    using Telerik.Sitefinity.UI.MVC;
    
    #line default
    #line hidden
    
    #line 9 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
    using Telerik.Sitefinity.Utilities;
    
    #line default
    #line hidden
    
    #line 11 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
    using Telerik.Sitefinity.Web.Utilities;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Bootstrap5/MVC/Views/Profile/Edit.ProfileEdit.cshtml")]
    public partial class Edit_ProfileEdit : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Identity.Mvc.Models.Profile.ProfileEditViewModel>
    {

#line 140 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
public System.Web.WebPages.HelperResult FormGroupPanel(string label, Expression<Func<ProfileEditViewModel, string>> expression, string descId, string inputType = "text", string classValue = null, IDictionary<string, object> additionalAttributes = null)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 141 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
 
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

WriteLiteralTo(__razor_helper_writer, ">\r\n");

WriteLiteralTo(__razor_helper_writer, "        ");


#line 163 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
WriteTo(__razor_helper_writer, Html.LabelFor(expression, Html.Resource(label), new { @class = "form-label" }));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n");


#line 164 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
        

#line default
#line hidden

#line 164 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
         switch (inputType)
        {
            case "text":
                

#line default
#line hidden

#line 167 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
WriteTo(__razor_helper_writer, Html.TextBoxFor(expression, attributes));


#line default
#line hidden

#line 167 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                                                        ;
                break;

            case "textarea":
                

#line default
#line hidden

#line 171 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
WriteTo(__razor_helper_writer, Html.TextAreaFor(expression, attributes));


#line default
#line hidden

#line 171 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                                                         ;
                break;

            case "password":
                

#line default
#line hidden

#line 175 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
WriteTo(__razor_helper_writer, Html.PasswordFor(expression, attributes));


#line default
#line hidden

#line 175 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                                                         ;
                break;

            default:
                break;
        }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        ");


#line 181 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
         if (hasValidationMessage)
        {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <div");

WriteAttributeTo(__razor_helper_writer, "id", Tuple.Create(" id=\'", 9089), Tuple.Create("\'", 9116)

#line 183 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
, Tuple.Create(Tuple.Create("", 9094), Tuple.Create<System.Object, System.Int32>(Html.UniqueId(descId)

#line default
#line hidden
, 9094), false)
);

WriteLiteralTo(__razor_helper_writer, " class=\"text-danger\"");

WriteLiteralTo(__razor_helper_writer, " role=\"alert\"");

WriteLiteralTo(__razor_helper_writer, " aria-live=\"assertive\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n");

WriteLiteralTo(__razor_helper_writer, "                ");


#line 184 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
WriteTo(__razor_helper_writer, Html.ValidationMessageFor(expression));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n            </div>\r\n");


#line 186 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
        }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    </div>\r\n");


#line 188 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"


#line default
#line hidden
});

#line 188 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
}
#line default
#line hidden

#line 189 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
public System.Web.WebPages.HelperResult ReadOnlyFormGroupPanel(string label, Expression<Func<ProfileEditViewModel, string>> expression, string message = null)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 190 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
 


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <div");

WriteLiteralTo(__razor_helper_writer, " class=\"my-3\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n        <label");

WriteLiteralTo(__razor_helper_writer, " class=\"form-label\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n");

WriteLiteralTo(__razor_helper_writer, "            ");


#line 193 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
WriteTo(__razor_helper_writer, Html.Resource(label));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n        </label>\r\n");


#line 195 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
        

#line default
#line hidden

#line 195 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
         if (message == null)
        {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <div>\r\n");

WriteLiteralTo(__razor_helper_writer, "                ");


#line 198 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
WriteTo(__razor_helper_writer, Html.HiddenFor(expression));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n");

WriteLiteralTo(__razor_helper_writer, "                ");


#line 199 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
WriteTo(__razor_helper_writer, Html.DisplayTextFor(expression));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n            </div>\r\n");


#line 201 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
        }
        else
        {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <div>");


#line 204 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
WriteTo(__razor_helper_writer, message);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</div>\r\n");


#line 205 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
        }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    </div>\r\n");


#line 207 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"


#line default
#line hidden
});

#line 207 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
}
#line default
#line hidden

        public Edit_ProfileEdit()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 13 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
Write(Html.Script(ScriptRef.JQuery, "jquery", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 14 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
Write(Html.Script("//cdnjs.cloudflare.com/ajax/libs/jquery-validate/1.19.5/jquery.validate.js", "jquery", false, new List<KeyValuePair<string, string>>() { HtmlConstants.CrossOriginHtmlAttribute }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 15 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
Write(Html.Script("//cdnjs.cloudflare.com/ajax/libs/jquery-validation-unobtrusive/4.0.0/jquery.validate.unobtrusive.min.js", "jquery", false, new List<KeyValuePair<string, string>>() { HtmlConstants.CrossOriginHtmlAttribute }));

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 935), Tuple.Create("\"", 958)
            
            #line 16 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
, Tuple.Create(Tuple.Create("", 943), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 943), false)
);

WriteLiteral(">\r\n    <h3>");

            
            #line 17 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
   Write(Html.Resource("EditProfileLink"));

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n");

            
            #line 18 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
    
            
            #line default
            #line hidden
            
            #line 18 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
     if (Model.ShowProfileChangedMsg)
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"alert alert-success\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-live=\"assertive\"");

WriteLiteral(">");

            
            #line 20 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                                                                       Write(Html.Resource("ChangesAreSaved"));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 21 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    ");

            
            #line 22 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
     if (!string.IsNullOrEmpty(ViewBag.ErrorMessage))
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"alert alert-danger\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-live=\"assertive\"");

WriteLiteral(">");

            
            #line 24 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                                                                      Write(ViewBag.ErrorMessage);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 25 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    ");

            
            #line 26 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
     using (Html.BeginFormSitefinity("Index", "EditProfileForm", FormMethod.Post, new Dictionary<string, object> { { "enctype", "multipart/form-data" }, { "role", "form" } }))
    {
        string[] readOnlyFields = ViewBag.ReadOnlyFields.ContainsKey("SitefinityProfile") ? (string[])ViewBag.ReadOnlyFields["SitefinityProfile"] : new string[0];
        if (readOnlyFields.Count() > 0 || ViewBag.IsEmailReadOnly)
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"alert alert-info\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(">");

            
            #line 31 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                                                  Write(string.Format(Html.Resource("YouAreRegisteredWith"), Model.ExternalProviderName));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 32 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"d-flex gap-3\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"flex-shrink-0 pt-3\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 35 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
           Write(Html.HiddenFor(u => u.DeletePicture, new Dictionary<string, object>() { { "data-sf-role", "edit-profile-delete-picture" } }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 36 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
           Write(Html.HiddenFor(u => u.DefaultAvatarUrl, new Dictionary<string, object>() { { "data-sf-role", "edit-profile-default-avatar-url" } }));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n                <div>\r\n                    <img");

WriteLiteral(" data-sf-role=\"edit-profile-user-image\"");

WriteAttribute("src", Tuple.Create(" src=\"", 2398), Tuple.Create("\"", 2425)
            
            #line 39 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
, Tuple.Create(Tuple.Create("", 2404), Tuple.Create<System.Object, System.Int32>(Model.AvatarImageUrl
            
            #line default
            #line hidden
, 2404), false)
);

WriteAttribute("alt", Tuple.Create(" alt=\"", 2426), Tuple.Create("\"", 2447)
            
            #line 39 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                 , Tuple.Create(Tuple.Create("", 2432), Tuple.Create<System.Object, System.Int32>(Model.UserName
            
            #line default
            #line hidden
, 2432), false)
);

WriteLiteral(" width=\"100\"");

WriteLiteral(" height=\"100\"");

WriteLiteral(" />\r\n                    ");

WriteLiteral("\r\n                </div>\r\n                <div>\r\n                    <input");

WriteLiteral(" type=\"file\"");

WriteLiteral(" data-sf-role=\"edit-profile-upload-picture-input\"");

WriteLiteral(" name=\"UploadedImage\"");

WriteLiteral(" style=\"display: none;\"");

WriteLiteral(" />\r\n                    <a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral(" data-sf-role=\"edit-profile-upload-picture-button\"");

WriteLiteral(" role=\"button\"");

WriteLiteral(" class=\"btn btn-link px-0\"");

WriteLiteral(">");

            
            #line 46 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                                                                                                                                      Write(Html.Resource("EditProfileUploadImage"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                </div>\r\n\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"flex-grow-1\"");

WriteLiteral(">\r\n");

            
            #line 51 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                
            
            #line default
            #line hidden
            
            #line 51 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                 if (readOnlyFields.Any(x => x.Equals("FirstName", StringComparison.OrdinalIgnoreCase)))
                {
                    
            
            #line default
            #line hidden
            
            #line 53 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
               Write(ReadOnlyFormGroupPanel("EditProfileFirstName", u => u.Profile["FirstName"]));

            
            #line default
            #line hidden
            
            #line 53 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                                                                                                
                }
                else
                {
                    
            
            #line default
            #line hidden
            
            #line 57 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
               Write(FormGroupPanel("EditProfileFirstName", u => u.Profile["FirstName"], "ProfileFirstName"));

            
            #line default
            #line hidden
            
            #line 57 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                                                                                                            
                }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 60 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                
            
            #line default
            #line hidden
            
            #line 60 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                 if (readOnlyFields.Any(x => x.Equals("LastName", StringComparison.OrdinalIgnoreCase)))
                {
                    
            
            #line default
            #line hidden
            
            #line 62 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
               Write(ReadOnlyFormGroupPanel("EditProfileLastName", u => u.Profile["LastName"]));

            
            #line default
            #line hidden
            
            #line 62 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                                                                                              
                }
                else
                {
                    
            
            #line default
            #line hidden
            
            #line 66 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
               Write(FormGroupPanel("EditProfileLastName", u => u.Profile["LastName"], "ProfileLastName"));

            
            #line default
            #line hidden
            
            #line 66 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                                                                                                         
                }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 69 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                
            
            #line default
            #line hidden
            
            #line 69 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                 if (readOnlyFields.Any(x => x.Equals("Nickname", StringComparison.OrdinalIgnoreCase)))
                {
                    
            
            #line default
            #line hidden
            
            #line 71 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
               Write(ReadOnlyFormGroupPanel("EditProfileNickname", u => u.Profile["Nickname"]));

            
            #line default
            #line hidden
            
            #line 71 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                                                                                              
                }
                else
                {
                    
            
            #line default
            #line hidden
            
            #line 75 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
               Write(FormGroupPanel("EditProfileNickname", u => u.Profile["Nickname"], "ProfileNickName"));

            
            #line default
            #line hidden
            
            #line 75 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                                                                                                         
                }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 78 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                
            
            #line default
            #line hidden
            
            #line 78 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                 if (readOnlyFields.Any(x => x.Equals("About", StringComparison.OrdinalIgnoreCase)))
                {
                    
            
            #line default
            #line hidden
            
            #line 80 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
               Write(ReadOnlyFormGroupPanel("EditProfileAbout", u => u.Profile["About"]));

            
            #line default
            #line hidden
            
            #line 80 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                                                                                        
                }
                else
                {
                    
            
            #line default
            #line hidden
            
            #line 84 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
               Write(FormGroupPanel("EditProfileAbout", u => u.Profile["About"], "ProfileAbout", "textarea"));

            
            #line default
            #line hidden
            
            #line 84 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                                                                                                            
                }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 87 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                
            
            #line default
            #line hidden
            
            #line 87 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                 if (ViewBag.IsEmailReadOnly)
                {
                    
            
            #line default
            #line hidden
            
            #line 89 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
               Write(ReadOnlyFormGroupPanel("EditProfileEmail", u => u.Email));

            
            #line default
            #line hidden
            
            #line 89 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                                                                             
                }
                else
                {
                    
            
            #line default
            #line hidden
            
            #line 93 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
               Write(FormGroupPanel("EditProfileEmail", u => u.Email, "ProfileEmail"));

            
            #line default
            #line hidden
            
            #line 93 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                                                                                     
                }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 96 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                
            
            #line default
            #line hidden
            
            #line 96 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                 if (string.IsNullOrEmpty(Model.ExternalProviderName))
                {

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"mb-4\"");

WriteLiteral(">\r\n                        <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" data-sf-role=\"edit-profile-change-password-button\"");

WriteLiteral(" role=\"button\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 100 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                       Write(Html.Resource("EditProfileChangePasswordButton"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            <span");

WriteLiteral(" class=\"visually-hidden\"");

WriteLiteral(">");

            
            #line 101 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                                                     Write(Html.Resource("WillExpandChangePasswordSection"));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                        </a>\r\n                    </div>\r\n");

WriteLiteral("                    <div");

WriteLiteral(" data-sf-role=\"edit-profile-change-password-holder\"");

WriteLiteral(" style=\"display:none\"");

WriteLiteral(">\r\n                        <h4>");

            
            #line 105 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                       Write(Html.Resource("EditProfileEditChangePasswordHeader"));

            
            #line default
            #line hidden
WriteLiteral("</h4>\r\n");

WriteLiteral("                        ");

            
            #line 106 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                   Write(FormGroupPanel("EditProfileOldPassword", u => u.OldPassword, "ProfileOldPassword", "password", null, new Dictionary<string, object>() { { "autocomplete", "off" } }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                        ");

            
            #line 107 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                   Write(FormGroupPanel("EditProfileNewPassword", u => u.NewPassword, "ProfileNewPassword", "password"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                        ");

            
            #line 108 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                   Write(FormGroupPanel("EditProfileRepeatPassword", u => u.RepeatPassword, "ProfileRepeatPassword", "password"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n");

            
            #line 110 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                }
                else
                {
                    
            
            #line default
            #line hidden
            
            #line 113 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
               Write(ReadOnlyFormGroupPanel("Password", null, string.Format(Html.Resource("ExternalProviderNoPassword"), Model.ExternalProviderName)));

            
            #line default
            #line hidden
            
            #line 113 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                                                                                                                                                     
                }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 116 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                
            
            #line default
            #line hidden
            
            #line 116 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                 if (SystemManager.IsDesignMode)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <button");

WriteLiteral(" data-sf-role=\"profile-submit\"");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-primary\"");

WriteLiteral(" disabled>");

            
            #line 118 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                                                                                                    Write(Html.Resource("EditProfileSave"));

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n");

            
            #line 119 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                }
                else
                {

            
            #line default
            #line hidden
WriteLiteral("                    <button");

WriteLiteral(" data-sf-role=\"profile-submit\"");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"btn btn-primary\"");

WriteLiteral(">");

            
            #line 122 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                                                                                           Write(Html.Resource("EditProfileSave"));

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n");

            
            #line 123 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                ");

            
            #line 124 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
           Write(Html.AddSitefinityAntiforgeryToken());

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 125 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                
            
            #line default
            #line hidden
            
            #line 125 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                 if (SystemManager.IsPreviewMode)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" class=\"text-danger my-3\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-live=\"assertive\"");

WriteLiteral(" data-sf-role=\"profile-submit-preview-message\"");

WriteLiteral(" style=\"display:none\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 128 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                   Write(Html.Resource("PreviewProfileSaveMessage"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n");

            
            #line 130 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </div>\r\n        </div>\r\n");

            
            #line 133 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 135 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
  
    bool hasPasswordErrors = ViewBag.HasPasswordErrors is bool && ViewBag.HasPasswordErrors == true;

            
            #line default
            #line hidden
WriteLiteral("\r\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"has-password-errors\"");

WriteAttribute("value", Tuple.Create(" value=\"", 7544), Tuple.Create("\"", 7600)
            
            #line 138 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
, Tuple.Create(Tuple.Create("", 7552), Tuple.Create<System.Object, System.Int32>(hasPasswordErrors.ToString().ToLowerInvariant()
            
            #line default
            #line hidden
, 7552), false)
);

WriteLiteral(" />\r\n");

            
            #line 139 "..\..\ResourcePackages\Bootstrap5\MVC\Views\Profile\Edit.ProfileEdit.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/Profile/profile-edit.js"), "bottom", true));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
