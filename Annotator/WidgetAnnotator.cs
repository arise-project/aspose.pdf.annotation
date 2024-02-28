using Aspose.Pdf;
using aspose.pdf.annotation.Model;
using Aspose.Pdf.Annotations;
using Aspose.Pdf.Forms;

namespace aspose.pdf.annotation;

public class WidgetAnnotator : IAnnotator
{
    private readonly WidgetModel _model;
    private readonly string _workFolder;
    private readonly string _inputFile;
    private readonly string _outputFile;

    public WidgetAnnotator(WidgetModel model, string workFolder, string inputFile, string outputFile)
    {
        _model = model;
        _workFolder = workFolder;
        _inputFile = inputFile;
        _outputFile = outputFile;
    }
    
    public void Add()
    {
        var document = new Document(Path.Combine(_workFolder, _inputFile));
        
        var printButton = new ButtonField(
            document.Pages[_model.Position.PageNumber], 
            new Rectangle(
                _model.Position.Llx, 
                _model.Position.Lly, 
                _model.Position.Urx,
                _model.Position.Ury,
                _model.Position.NormalizeCoordinates))
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
        
        document.Save(Path.Combine(_workFolder, _outputFile));
    }
}