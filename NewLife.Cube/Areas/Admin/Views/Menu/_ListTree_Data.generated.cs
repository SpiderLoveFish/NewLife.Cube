﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    
    #line 6 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
    using System.Web.Mvc;
    
    #line default
    #line hidden
    
    #line 7 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
    using System.Web.Mvc.Ajax;
    
    #line default
    #line hidden
    
    #line 8 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
    using System.Web.Mvc.Html;
    
    #line default
    #line hidden
    
    #line 9 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
    using System.Web.Routing;
    
    #line default
    #line hidden
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 2 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
    using NewLife;
    
    #line default
    #line hidden
    using NewLife.Cube;
    using NewLife.Reflection;
    
    #line 3 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
    using NewLife.Web;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
    using XCode;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
    using XCode.Configuration;
    
    #line default
    #line hidden
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Admin/Views/Menu/_ListTree_Data.cshtml")]
    public partial class _Areas_Admin_Views_Menu__ListTree_Data_cshtml : System.Web.Mvc.WebViewPage<IList<XCode.Membership.Menu>>
    {
        public _Areas_Admin_Views_Menu__ListTree_Data_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 10 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
  
    var fact = ViewBag.Factory as IEntityOperate;
    var page = ViewBag.Page as Pager;
    var fields = ViewBag.Fields as IList<FieldItem>;
    var set = ViewBag.PageSetting as PageSetting;

            
            #line default
            #line hidden
WriteLiteral("\r\n<table");

WriteLiteral(" class=\"table table-bordered table-hover table-striped table-condensed\"");

WriteLiteral(">\r\n    <thead>\r\n        <tr>\r\n");

            
            #line 19 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
            
            
            #line default
            #line hidden
            
            #line 19 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
             if (set.EnableSelect)
            {

            
            #line default
            #line hidden
WriteLiteral("                <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(" style=\"width:10px;\"");

WriteLiteral("><input");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" id=\"chkAll\"");

WriteLiteral(" title=\"全选\"");

WriteLiteral(" /></th>\r\n");

            
            #line 22 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 757), Tuple.Create("\"", 796)
            
            #line 23 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
, Tuple.Create(Tuple.Create("", 764), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("ID"))
            
            #line default
            #line hidden
, 764), false)
);

WriteLiteral(">编号</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 849), Tuple.Create("\"", 898)
            
            #line 24 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
, Tuple.Create(Tuple.Create("", 856), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("TreeNodeName"))
            
            #line default
            #line hidden
, 856), false)
);

WriteLiteral(">节点名</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 952), Tuple.Create("\"", 1000)
            
            #line 25 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
, Tuple.Create(Tuple.Create("", 959), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("DisplayName"))
            
            #line default
            #line hidden
, 959), false)
);

WriteLiteral(">显示名</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1054), Tuple.Create("\"", 1094)
            
            #line 26 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1061), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("Url"))
            
            #line default
            #line hidden
, 1061), false)
);

WriteLiteral(">链接</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1147), Tuple.Create("\"", 1188)
            
            #line 27 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1154), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("Sort"))
            
            #line default
            #line hidden
, 1154), false)
);

WriteLiteral(">排序</a></th>\r\n            ");

WriteLiteral("\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1339), Tuple.Create("\"", 1383)
            
            #line 29 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1346), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("Visible"))
            
            #line default
            #line hidden
, 1346), false)
);

WriteLiteral(">可见</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(" title=\"必要。必要的菜单，必须至少有角色拥有这些权限，如果没有则自动授权给系统角色\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1482), Tuple.Create("\"", 1528)
            
            #line 30 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
           , Tuple.Create(Tuple.Create("", 1489), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("Necessary"))
            
            #line default
            #line hidden
, 1489), false)
);

WriteLiteral(">必要</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(" title=\"权限子项。逗号分隔，每个权限子项名值竖线分隔\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1612), Tuple.Create("\"", 1659)
            
            #line 31 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1619), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("Permission"))
            
            #line default
            #line hidden
, 1619), false)
);

WriteLiteral(">权限子项</a></th>\r\n");

            
            #line 32 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
            
            
            #line default
            #line hidden
            
            #line 32 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
             if (this.Has(PermissionFlags.Detail, PermissionFlags.Update, PermissionFlags.Delete))
            {

            
            #line default
            #line hidden
WriteLiteral("                <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">升</th>\r\n");

WriteLiteral("                <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">降</th>\r\n");

WriteLiteral("                <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(" style=\"min-width:100px;\"");

WriteLiteral(">操作</th>\r\n");

            
            #line 37 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </tr>\r\n    </thead>\r\n    <tbody>\r\n");

            
            #line 41 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
        
            
            #line default
            #line hidden
            
            #line 41 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
         foreach (var entity in Model)
        {
            var p = entity.Parent as IEntityTree;
            if (p == null)
            {
                p = fact.EntityType.GetValue("Root") as IEntityTree;
            }
            var id = entity.ID;

            
            #line default
            #line hidden
WriteLiteral("            <tr>\r\n");

            
            #line 50 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
                
            
            #line default
            #line hidden
            
            #line 50 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
                 if (set.EnableSelect)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><input");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" name=\"keys\"");

WriteAttribute("value", Tuple.Create(" value=\"", 2436), Tuple.Create("\"", 2454)
            
            #line 52 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
      , Tuple.Create(Tuple.Create("", 2444), Tuple.Create<System.Object, System.Int32>(entity.ID
            
            #line default
            #line hidden
, 2444), false)
);

WriteLiteral(" /></td>\r\n");

            
            #line 53 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">");

            
            #line 54 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
                                   Write(entity.ID);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td>");

            
            #line 55 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
               Write(entity.TreeNodeName);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td>");

            
            #line 56 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
               Write(entity.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td>");

            
            #line 57 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
               Write(entity.Url);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td");

WriteLiteral(" class=\"text-right\"");

WriteLiteral(">");

            
            #line 58 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
                                  Write(entity.Sort.ToString("n0"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                ");

WriteLiteral("\r\n                <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">\r\n                    <i");

WriteAttribute("class", Tuple.Create(" class=\"", 2852), Tuple.Create("\"", 2915)
, Tuple.Create(Tuple.Create("", 2860), Tuple.Create("glyphicon", 2860), true)
, Tuple.Create(Tuple.Create(" ", 2869), Tuple.Create("glyphicon-", 2870), true)
            
            #line 61 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
, Tuple.Create(Tuple.Create("", 2880), Tuple.Create<System.Object, System.Int32>(entity.Visible ? "ok" : "remove"
            
            #line default
            #line hidden
, 2880), false)
);

WriteAttribute("style", Tuple.Create(" style=\"", 2916), Tuple.Create("\"", 2967)
, Tuple.Create(Tuple.Create("", 2924), Tuple.Create("color:", 2924), true)
            
            #line 61 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
                     , Tuple.Create(Tuple.Create(" ", 2930), Tuple.Create<System.Object, System.Int32>(entity.Visible ? "green" : "red"
            
            #line default
            #line hidden
, 2931), false)
, Tuple.Create(Tuple.Create("", 2966), Tuple.Create(";", 2966), true)
);

WriteLiteral("></i>\r\n                </td>\r\n                <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">\r\n                    <i");

WriteAttribute("class", Tuple.Create(" class=\"", 3062), Tuple.Create("\"", 3127)
, Tuple.Create(Tuple.Create("", 3070), Tuple.Create("glyphicon", 3070), true)
, Tuple.Create(Tuple.Create(" ", 3079), Tuple.Create("glyphicon-", 3080), true)
            
            #line 64 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
, Tuple.Create(Tuple.Create("", 3090), Tuple.Create<System.Object, System.Int32>(entity.Necessary ? "ok" : "remove"
            
            #line default
            #line hidden
, 3090), false)
);

WriteAttribute("style", Tuple.Create(" style=\"", 3128), Tuple.Create("\"", 3181)
, Tuple.Create(Tuple.Create("", 3136), Tuple.Create("color:", 3136), true)
            
            #line 64 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
                       , Tuple.Create(Tuple.Create(" ", 3142), Tuple.Create<System.Object, System.Int32>(entity.Necessary ? "green" : "red"
            
            #line default
            #line hidden
, 3143), false)
, Tuple.Create(Tuple.Create("", 3180), Tuple.Create(";", 3180), true)
);

WriteLiteral("></i>\r\n                </td>\r\n                <td>");

            
            #line 66 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
               Write(entity.Permission);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

            
            #line 67 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
                
            
            #line default
            #line hidden
            
            #line 67 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
                 if (this.Has(PermissionFlags.Detail, PermissionFlags.Update, PermissionFlags.Delete))
                {

            
            #line default
            #line hidden
WriteLiteral("                    <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">\r\n");

            
            #line 70 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 70 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
                         if (p != null && p.Childs != null && p.Childs.Count > 0 && entity != p.Childs[0])
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 3591), Tuple.Create("\"", 3627)
            
            #line 72 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
, Tuple.Create(Tuple.Create("", 3598), Tuple.Create<System.Object, System.Int32>(Url.Action("Up", new { id })
            
            #line default
            #line hidden
, 3598), false)
);

WriteLiteral("><span");

WriteLiteral(" class=\"glyphicon glyphicon-arrow-up\"");

WriteLiteral(" style=\"color: green;\"");

WriteLiteral("></span></a>\r\n");

            
            #line 73 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </td>\r\n");

WriteLiteral("                    <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">\r\n");

            
            #line 76 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 76 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
                         if (p != null && entity != p.Childs[p.Childs.Count - 1])
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 3947), Tuple.Create("\"", 3985)
            
            #line 78 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
, Tuple.Create(Tuple.Create("", 3954), Tuple.Create<System.Object, System.Int32>(Url.Action("Down", new { id })
            
            #line default
            #line hidden
, 3954), false)
);

WriteLiteral("><span");

WriteLiteral(" class=\"glyphicon glyphicon-arrow-down\"");

WriteLiteral(" style=\"color: red;\"");

WriteLiteral("></span></a>\r\n");

            
            #line 79 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </td>\r\n");

WriteLiteral("                    <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 82 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
                   Write(Html.Partial("_List_Data_Action", (Object)entity));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>\r\n");

            
            #line 84 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </tr>\r\n");

            
            #line 86 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </tbody>\r\n</table>");

        }
    }
}
#pragma warning restore 1591
