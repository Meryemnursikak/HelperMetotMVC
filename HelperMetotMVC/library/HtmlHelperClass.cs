using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelperMetotMVC.library
{
    public static class HtmlHelperClass
    {
        public static MvcHtmlString Alert(this HtmlHelper helper,string renk,string metin, string id = "alert1")
        {
            TagBuilder tag = new TagBuilder("div");
            tag.AddCssClass("alert alert-" + renk);
            tag.GenerateId(id);
            tag.Attributes.Add("role", "alert");
            tag.SetInnerText(metin);
            return MvcHtmlString.Create(tag.ToString());
        }
    }
}