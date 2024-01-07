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

namespace SitefinityWebApp.ResourcePackages.Bootstrap4.MVC.Views.SearchBox
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
    
    #line 5 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 4 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 3 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
    using Telerik.Sitefinity.Services;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/SearchBox/SearchBox.cshtml")]
    public partial class SearchBox : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Search.Mvc.Models.ISearchBoxModel>
    {
        public SearchBox()
        {
        }
        public override void Execute()
        {
            
            #line 6 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
  
    var searchTextBoxId = Guid.NewGuid();
    var searchButtonId = Guid.NewGuid();

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 10 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
Write(!String.IsNullOrEmpty(Model.CssClass) ?
        Html.Raw(String.Format("<div class=\"{0} form-inline\">", HttpUtility.HtmlAttributeEncode(Model.CssClass))) :
        Html.Raw("<div class=\"form-inline\">"));

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"form-group sf-search-input-wrapper\"");

WriteLiteral(" role=\"search\"");

WriteLiteral(">\r\n    <input");

WriteLiteral(" type=\"search\"");

WriteAttribute("title", Tuple.Create(" title=\"", 592), Tuple.Create("\"", 629)
            
            #line 14 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 600), Tuple.Create<System.Object, System.Int32>(Html.Resource("SearchInput")
            
            #line default
            #line hidden
, 600), false)
);

WriteAttribute("placeholder", Tuple.Create(" placeholder=\"", 630), Tuple.Create("\"", 665)
            
            #line 14 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 644), Tuple.Create<System.Object, System.Int32>(Model.BackgroundHint
            
            #line default
            #line hidden
, 644), false)
);

WriteAttribute("id", Tuple.Create(" id=\"", 666), Tuple.Create("\"", 687)
            
            #line 14 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
                        , Tuple.Create(Tuple.Create("", 671), Tuple.Create<System.Object, System.Int32>(searchTextBoxId
            
            #line default
            #line hidden
, 671), false)
);

WriteLiteral(" class=\"form-control\"");

WriteAttribute("value", Tuple.Create(" value=\"", 709), Tuple.Create("\"", 739)
            
            #line 14 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
                                                                       , Tuple.Create(Tuple.Create("", 717), Tuple.Create<System.Object, System.Int32>(ViewBag.SearchQuery
            
            #line default
            #line hidden
, 717), false)
);

WriteLiteral(" aria-autocomplete=\"both\"");

WriteAttribute("aria-describedby", Tuple.Create(" aria-describedby=\'", 765), Tuple.Create("\'", 812)
            
            #line 14 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
                                                                                                                                         , Tuple.Create(Tuple.Create("", 784), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("SearchInfo")
            
            #line default
            #line hidden
, 784), false)
);

WriteLiteral(" />\r\n    <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-primary ml-2\"");

WriteAttribute("id", Tuple.Create(" id=\"", 872), Tuple.Create("\"", 894)
            
            #line 15 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 877), Tuple.Create<System.Object, System.Int32>(searchButtonId
            
            #line default
            #line hidden
, 877), false)
);

WriteLiteral(" ");

            
            #line 15 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
                                                                          Write(SystemManager.IsDesignMode ? "disabled" : "");

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 15 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
                                                                                                                         Write(Html.Resource("SearchLabel"));

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n    <span");

WriteAttribute("id", Tuple.Create(" id=\'", 993), Tuple.Create("\'", 1026)
            
            #line 16 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 998), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("SearchInfo")
            
            #line default
            #line hidden
, 998), false)
);

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(" hidden>When autocomplete results are available use up and down arrows to review " +
"and enter to select.</span>\r\n</div>\r\n\r\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"resultsUrl\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1212), Tuple.Create("\"", 1239)
            
            #line 19 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 1220), Tuple.Create<System.Object, System.Int32>(Model.ResultsUrl
            
            #line default
            #line hidden
, 1220), false)
);

WriteLiteral(" />\r\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"indexCatalogue\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1295), Tuple.Create("\"", 1326)
            
            #line 20 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 1303), Tuple.Create<System.Object, System.Int32>(Model.IndexCatalogue
            
            #line default
            #line hidden
, 1303), false)
);

WriteLiteral(" />\r\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"disableSuggestions\"");

WriteAttribute("value", Tuple.Create(" value=\'", 1386), Tuple.Create("\'", 1444)
            
            #line 21 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 1394), Tuple.Create<System.Object, System.Int32>(Model.DisableSuggestions ? ("true") : ("false")
            
            #line default
            #line hidden
, 1394), false)
);

WriteLiteral(" />\r\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"minSuggestionLength\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1505), Tuple.Create("\"", 1541)
            
            #line 22 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 1513), Tuple.Create<System.Object, System.Int32>(Model.MinSuggestionLength
            
            #line default
            #line hidden
, 1513), false)
);

WriteLiteral(" />\r\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"suggestionFields\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1599), Tuple.Create("\"", 1632)
            
            #line 23 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 1607), Tuple.Create<System.Object, System.Int32>(Model.SuggestionFields
            
            #line default
            #line hidden
, 1607), false)
);

WriteLiteral(" />\r\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"language\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1682), Tuple.Create("\"", 1707)
            
            #line 24 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 1690), Tuple.Create<System.Object, System.Int32>(Model.Language
            
            #line default
            #line hidden
, 1690), false)
);

WriteLiteral(" />\r\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"siteId\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1755), Tuple.Create("\"", 1809)
            
            #line 25 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 1763), Tuple.Create<System.Object, System.Int32>(SystemManager.CurrentContext.CurrentSite.Id
            
            #line default
            #line hidden
, 1763), false)
);

WriteLiteral(" />\r\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"suggestionsRoute\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1867), Tuple.Create("\"", 1900)
            
            #line 26 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 1875), Tuple.Create<System.Object, System.Int32>(Model.SuggestionsRoute
            
            #line default
            #line hidden
, 1875), false)
);

WriteLiteral(" />\r\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"searchTextBoxId\"");

WriteAttribute("value", Tuple.Create(" value=\'", 1957), Tuple.Create("\'", 2000)
            
            #line 27 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 1965), Tuple.Create<System.Object, System.Int32>("#" + searchTextBoxId.ToString()
            
            #line default
            #line hidden
, 1965), false)
);

WriteLiteral(" />\r\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"searchButtonId\"");

WriteAttribute("value", Tuple.Create(" value=\'", 2056), Tuple.Create("\'", 2098)
            
            #line 28 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 2064), Tuple.Create<System.Object, System.Int32>("#" + searchButtonId.ToString()
            
            #line default
            #line hidden
, 2064), false)
);

WriteLiteral(" />\r\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"scoringSettings\"");

WriteAttribute("value", Tuple.Create(" value=\'", 2155), Tuple.Create("\'", 2205)
            
            #line 29 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 2163), Tuple.Create<System.Object, System.Int32>(ViewBag.ScoringSettings ?? string.Empty
            
            #line default
            #line hidden
, 2163), false)
);

WriteLiteral(" />\r\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"searchInAllSitesInTheIndex\"");

WriteAttribute("value", Tuple.Create(" value=\'", 2273), Tuple.Create("\'", 2386)
            
            #line 30 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
, Tuple.Create(Tuple.Create("", 2281), Tuple.Create<System.Object, System.Int32>(Model.SearchInAllSitesInTheIndex.HasValue ? Model.SearchInAllSitesInTheIndex.ToString() : string.Empty
            
            #line default
            #line hidden
, 2281), false)
);

WriteLiteral(" />\r\n</div>\r\n\r\n");

WriteLiteral("\r\n");

            
            #line 34 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", true));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 35 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
Write(Html.Script(ScriptRef.JQueryUI, "top", true));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 36 "..\..MVC\Views\SearchBox\SearchBox.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/SearchBox/Search-box.js"), "bottom", true));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
