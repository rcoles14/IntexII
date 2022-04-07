﻿using Intex.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intex.Infrastructure
{
    [HtmlTargetElement("div", Attributes = "page-blah")]
    public class PageTagHelper : TagHelper
    {
        private IUrlHelperFactory uhf;

    public PageTagHelper(IUrlHelperFactory temp)
    {
        uhf = temp;
    }
    [ViewContext]
    [HtmlAttributeNotBound]
    public ViewContext vc { get; set; }

    public PageInfo PageBlah { get; set; }
    public bool PageClassesEnabled { get; set; } = false;
    public string PageClass { get; set; }
    public string PageClassNormal { get; set; }
    public string PageClassSelected { get; set; }
    public string PageAction { get; set; }

    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        IUrlHelper uh = uhf.GetUrlHelper(vc);

        TagBuilder final = new TagBuilder("div");
        
        for (int i = PageBlah.CurrentPage; i <= PageBlah.CurrentPage + 9; i++)
        {

                    TagBuilder tb = new TagBuilder("a");
                    tb.Attributes["href"] = uh.Action(PageAction, new { pageNum = i });
                    if (PageClassesEnabled)
                    {
                        tb.AddCssClass(PageClass);
                        tb.AddCssClass(i == PageBlah.CurrentPage
                            ? PageClassSelected : PageClassNormal);
                    }
                    tb.InnerHtml.Append(i.ToString());
                    

                final.InnerHtml.AppendHtml(tb);
                
                if (i == PageBlah.TotalPages)
                {
                    break;
                }
            };

        output.Content.AppendHtml(final.InnerHtml);

    }
}
}

