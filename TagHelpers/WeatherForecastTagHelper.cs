using System;
using System.Net.Http;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CustomWebTagHelpers.TagHelpers
{
    public class WeatherForecastTagHelper : TagHelper
    {

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            HttpClient _httpClient = new HttpClient();
            string requestUrl = "";
            var uri = new Uri(requestUrl);
            string result = _httpClient.GetStringAsync(uri).Result;
        }
    }
}
