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

namespace SitefinityWebApp.ResourcePackages.Bootstrap4.MVC.Views.Navigation
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
    
    #line 3 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 4 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
    using Telerik.Sitefinity.Frontend.Navigation.Mvc.Models;
    
    #line default
    #line hidden
    
    #line 5 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Bootstrap4/MVC/Views/Navigation/NavigationView.Sitemap.cshtml")]
    public partial class NavigationView_Sitemap : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Navigation.Mvc.Models.INavigationModel>
    {

#line 22 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
public System.Web.WebPages.HelperResult RenderRootLevelNode(NodeViewModel node)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 23 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
 


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <li");

WriteLiteralTo(__razor_helper_writer, " class=\"nav-item\"");

WriteLiteralTo(__razor_helper_writer, ">\n        <a");

WriteLiteralTo(__razor_helper_writer, " class=\"nav-link\"");

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 726), Tuple.Create("\"", 742)

#line 25 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
, Tuple.Create(Tuple.Create("", 733), Tuple.Create<System.Object, System.Int32>(node.Url

#line default
#line hidden
, 733), false)
);

WriteAttributeTo(__razor_helper_writer, "target", Tuple.Create(" target=\"", 743), Tuple.Create("\"", 768)

#line 25 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
, Tuple.Create(Tuple.Create("", 752), Tuple.Create<System.Object, System.Int32>(node.LinkTarget

#line default
#line hidden
, 752), false)
);

WriteLiteralTo(__razor_helper_writer, "><strong>");


#line 25 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
                                                 WriteTo(__razor_helper_writer, node.Title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</strong></a>\n");


#line 26 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
        

#line default
#line hidden

#line 26 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
         if (node.ChildNodes.Count > 0)
        {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <ul");

WriteLiteralTo(__razor_helper_writer, " class=\"nav flex-column ml-2\"");

WriteLiteralTo(__razor_helper_writer, ">\n");


#line 29 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
                

#line default
#line hidden

#line 29 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
                 foreach (var childNode in node.ChildNodes)
                {
                    

#line default
#line hidden

#line 31 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
WriteTo(__razor_helper_writer, RenderSubLevelsRecursive(childNode));


#line default
#line hidden

#line 31 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
                                                        
                }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            </ul>\n");


#line 34 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
        }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    </li>\n");


#line 36 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"


#line default
#line hidden
});

#line 36 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
}
#line default
#line hidden

#line 39 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
public System.Web.WebPages.HelperResult RenderSubLevelsRecursive(NodeViewModel node)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 40 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
 


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <li");

WriteLiteralTo(__razor_helper_writer, " class=\"nav-item\"");

WriteLiteralTo(__razor_helper_writer, ">\n        <a");

WriteLiteralTo(__razor_helper_writer, " class=\"nav-link\"");

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 1256), Tuple.Create("\"", 1272)

#line 42 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
, Tuple.Create(Tuple.Create("", 1263), Tuple.Create<System.Object, System.Int32>(node.Url

#line default
#line hidden
, 1263), false)
);

WriteLiteralTo(__razor_helper_writer, " target =\"");


#line 42 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
                        WriteTo(__razor_helper_writer, node.LinkTarget);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\">");


#line 42 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
                                          WriteTo(__razor_helper_writer, node.Title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</a>\n");


#line 43 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
        

#line default
#line hidden

#line 43 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
         if (node.ChildNodes.Count > 0)
        {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <ul");

WriteLiteralTo(__razor_helper_writer, " class=\"nav flex-column ml-2\"");

WriteLiteralTo(__razor_helper_writer, ">\n");


#line 46 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
                

#line default
#line hidden

#line 46 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
                 foreach (var childNode in node.ChildNodes)
                {
                    

#line default
#line hidden

#line 48 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
WriteTo(__razor_helper_writer, RenderSubLevelsRecursive(childNode));


#line default
#line hidden

#line 48 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
                                                        
                }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            </ul>\n");


#line 51 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
        }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    </li>\n");


#line 53 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"


#line default
#line hidden
});

#line 53 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
}
#line default
#line hidden

        public NavigationView_Sitemap()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n");

WriteLiteral("\n\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 260), Tuple.Create("\"", 283)
            
            #line 9 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
, Tuple.Create(Tuple.Create("", 268), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 268), false)
);

WriteLiteral(">\n    <nav>\n        ");

WriteLiteral("\r\n\n        <ul");

WriteLiteral(" class=\"nav nav-sitemap\"");

WriteLiteral(">\n");

            
            #line 14 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
            
            
            #line default
            #line hidden
            
            #line 14 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
             foreach (var node in Model.Nodes)
            {
                
            
            #line default
            #line hidden
            
            #line 16 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
           Write(RenderRootLevelNode(node));

            
            #line default
            #line hidden
            
            #line 16 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Sitemap.cshtml"
                                          ;
            }

            
            #line default
            #line hidden
WriteLiteral("        </ul>\n    </nav>\n</div>\n");

WriteLiteral("\n");

WriteLiteral("\n");

WriteLiteral("\n");

        }
    }
}
#pragma warning restore 1591
