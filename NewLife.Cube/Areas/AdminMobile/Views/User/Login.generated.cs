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
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using NewLife;
    using NewLife.Cube;
    using NewLife.Reflection;
    using NewLife.Web;
    using XCode;
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/AdminMobile/Views/User/Login.cshtml")]
    public partial class _Areas_AdminMobile_Views_User_Login_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Areas_AdminMobile_Views_User_Login_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Areas\AdminMobile\Views\User\Login.cshtml"
  
    Layout = null;

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n<head>\r\n    <meta");

WriteLiteral(" charset=\"utf-8\"");

WriteLiteral(">\r\n    <meta");

WriteLiteral(" http-equiv=\"X-UA-Compatible\"");

WriteLiteral(" content=\"IE=edge\"");

WriteLiteral(">\r\n    <title></title>\r\n\r\n    <link");

WriteLiteral(" href=\"/Content/jweui/lib/weui.min.css\"");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" />\r\n    <link");

WriteLiteral(" href=\"/Content/jweui/css/jquery-weui.min.css\"");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" />\r\n    <link");

WriteLiteral(" href=\"/Content/jweui/css/demos.css\"");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" />\r\n</head>\r\n<body ontouchstart>\r\n    <header");

WriteLiteral(" class=\'demos-header\'");

WriteLiteral(">\r\n        <h1");

WriteLiteral(" class=\"demos-title\"");

WriteLiteral(">系统登录</h1>\r\n    </header>\r\n");

            
            #line 21 "..\..\Areas\AdminMobile\Views\User\Login.cshtml"
    
            
            #line default
            #line hidden
            
            #line 21 "..\..\Areas\AdminMobile\Views\User\Login.cshtml"
     using (Html.BeginForm("Login", "User", new { ReturnUrl = ViewBag.ReturnUrl }))
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"weui-cells__title\"");

WriteLiteral("></div>\r\n");

WriteLiteral("        <div");

WriteLiteral(" class=\"weui-cells weui-cells_form\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"weui-cell\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"weui-cell__hd\"");

WriteLiteral("><label");

WriteLiteral(" class=\"weui-label\"");

WriteLiteral(">账号</label></div>\r\n                <div");

WriteLiteral(" class=\"weui-cell__bd\"");

WriteLiteral(">\r\n                    <input");

WriteLiteral(" class=\"weui-input\"");

WriteLiteral(" name=\"username\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(" placeholder=\"请输入账号\"");

WriteLiteral(">\r\n                </div>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"weui-cell\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"weui-cell__hd\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" class=\"weui-label\"");

WriteLiteral(">密码</label>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"weui-cell__bd\"");

WriteLiteral(">\r\n                    <input");

WriteLiteral(" name=\"password\"");

WriteLiteral(" class=\"weui-input\"");

WriteLiteral(" type=\"password\"");

WriteLiteral(" placeholder=\"请输入密码\"");

WriteLiteral(">\r\n                </div>\r\n            </div>\r\n        </div>\r\n");

WriteLiteral("        <label");

WriteLiteral(" for=\"weuiAgree\"");

WriteLiteral(" class=\"weui-agree\"");

WriteLiteral(">\r\n            <input");

WriteLiteral(" id=\"weuiAgree\"");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" checked");

WriteLiteral(" class=\"weui-agree__checkbox\"");

WriteLiteral(">\r\n            <span");

WriteLiteral(" class=\"weui-agree__text\"");

WriteLiteral(">\r\n                阅读并同意<a");

WriteLiteral(" href=\"javascript:void(0);\"");

WriteLiteral(">《相关条款》</a>\r\n            </span>\r\n        </label>\r\n");

            
            #line 46 "..\..\Areas\AdminMobile\Views\User\Login.cshtml"


            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"weui-btn-area\"");

WriteLiteral(">\r\n            <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"weui-btn weui-btn_primary\"");

WriteLiteral(">\r\n                <i");

WriteLiteral(" class=\"ace-icon fa fa-key\"");

WriteLiteral("></i>\r\n                <span");

WriteLiteral(" class=\"bigger-110\"");

WriteLiteral(">登录</span>\r\n            </button>\r\n        </div>\r\n");

            
            #line 53 "..\..\Areas\AdminMobile\Views\User\Login.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    <script");

WriteLiteral(" src=\"/Content/jweui/lib/jquery-2.1.4.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"/Content/jweui/lib/fastclick.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"/Content/jweui/js/jquery-weui.js\"");

WriteLiteral("></script>\r\n    <script>\r\n        $(function () {\r\n            FastClick.attach(d" +
"ocument.body);\r\n        });\r\n");

WriteLiteral("        ");

            
            #line 61 "..\..\Areas\AdminMobile\Views\User\Login.cshtml"
   Write(Html.Raw(ViewBag.js));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </script>\r\n\r\n</body>\r\n</html>\r\n");

        }
    }
}
#pragma warning restore 1591
