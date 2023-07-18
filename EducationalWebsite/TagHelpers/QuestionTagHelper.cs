using Microsoft.AspNetCore.Razor.TagHelpers;

namespace EducationalWebsite.TagHelpers
{
    public class QuestionTagHelper: TagHelper
    {
        public string Title { get; set; }
        public string RadioGroup { get; set; }
        public string FirstAnswerOption { get; set; }
        public string SecondAnswerOption { get; set; }
        public string ThirdAnswerOption { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.TagMode = TagMode.StartTagAndEndTag;
            output.Content.SetHtmlContent($"<label class=\"question\">{Title}</label>\r\n" +
                $"<input class=\"answer-option\" id=\"{RadioGroup}-a\" name=\"{RadioGroup}\" type=\"radio\" value=\"a\" />\r\n" +
                $"<label for=\"{RadioGroup}-a\">{FirstAnswerOption}</label><br/>" +
                $"<input class=\"answer-option\" id=\"{RadioGroup}-b\" name=\"{RadioGroup}\" type=\"radio\" value=\"b\" required />\r\n" +
                $"<label for=\"{RadioGroup}-b\">{SecondAnswerOption}</label><br/>" +
                $"<input class=\"answer-option\" id=\"{RadioGroup}-c\" name=\"{RadioGroup}\" type=\"radio\" value=\"c\" />\r\n" +
                $"<label for=\"{RadioGroup}-c\">{ThirdAnswerOption}</label><br/>");
        }
    }
}
