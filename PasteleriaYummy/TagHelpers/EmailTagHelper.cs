using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PasteleriaYummy.TagHelpers
{
    public class EmailTagHelper : TagHelper
    {
        public string Direccion { get; set; }

        public string Contenido { get; set; }


        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            output.Attributes.SetAttribute("href", "mailto: " + Direccion);
            output.Content.SetContent(Contenido);
        }
    }


    
}
