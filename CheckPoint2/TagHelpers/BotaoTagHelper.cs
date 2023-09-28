using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Checkpoint2.TagHelpers
{
    [HtmlTargetElement("input", Attributes = "is-submit-button")]
    public class SimpleSubmitButtonTagHelper : TagHelper
    {
        
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            // Adicione os atributos type, value, classes e estilo diretamente ao elemento input
            output.Attributes.SetAttribute("type", "submit");
            output.Attributes.SetAttribute("value", "Salvar");
            output.Attributes.Add("class", "btn btn-primary");
            output.Attributes.Add("style", "margin-top: 20px;");
        }
    }
}
