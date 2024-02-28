using aspose.pdf.annotation.Model.Descriptions;

namespace aspose.pdf.annotation.Model;

public class LinkModel
{
    public PageModel Page { get; set; } = new PageModel();

    public string Text { get; set; } = "test";

    public string Url { get; set; } = "http://google.com";
}