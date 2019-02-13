using System;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CustomWebTagHelpers.TagHelpers
{
    public class AutoPriceTagHelper : TagHelper
    {

        [HtmlAttributeNotBound]
        public string Make { get; set; }

        public string Model { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            base.Process(context, output);
        }
    }
}
