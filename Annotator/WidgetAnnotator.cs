using Aspose.Pdf;
using aspose.pdf.annotation.Model;
using Aspose.Pdf.Annotations;
using Aspose.Pdf.Forms;

namespace aspose.pdf.annotation;

public class WidgetAnnotator : IAnnotator
{
    private readonly WidgetModel _model;
    private readonly string _workFolder;

    public WidgetAnnotator(WidgetModel model, string workFolder)
    {
        _model = model;
        _workFolder = workFolder;
    }
    
    public void Add()
    {
        var document = new Document(_workFolder + "text.pdf");
        var page = document.Pages.Add();
        var rect = new Rectangle(72, 748, 164, 768);
        var printButton = new ButtonField(page, rect)
        {
            AlternateName = "Print current document",
            Color = Color.Black,
            PartialName = "printBtn1",
            NormalCaption = "Print Document"
        };
        var border = new Border(printButton)
        {
            Style = BorderStyle.Solid,
            Width = 2
        };
        printButton.Border = border;
        printButton.Characteristics.Border =
            System.Drawing.Color.FromArgb(255, 0, 0, 255);
        printButton.Characteristics.Background =
            System.Drawing.Color.FromArgb(255, 0, 191, 255);
        document.Form.Add(printButton);
        
        document.Save(_workFolder + "Output.pdf");
    }
}