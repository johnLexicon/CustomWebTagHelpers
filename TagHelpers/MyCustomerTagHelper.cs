using System;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CustomWebTagHelpers.TagHelpers
{

    [HtmlTargetElement("my-customer", Attributes = "info")]
    public class MyCustomerTagHelper : TagHelper
    {

        public string Info { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            //base.Process(context, output);
            var info = context.AllAttributes[0].Value;
            output.Content.SetContent($"The info is {info}");
            output.TagName = "strong";
        }
    }

}
