using Aspose.Pdf;
using aspose.pdf.annotation.Model;
using Aspose.Pdf.Annotations;
using Aspose.Pdf.Text;

namespace aspose.pdf.annotation;

public class WatermarkAnnotator : IAnnotator
{
    private readonly WatermarkModel _model;
    private readonly string _workFolder;
    private readonly string _inputFile;
    private readonly string _outputFile;

    public WatermarkAnnotator(WatermarkModel model, string workFolder, string inputFile, string outputFile)
    {
        _model = model;
        _workFolder = workFolder;
        _inputFile = inputFile;
        _outputFile = outputFile;
    }
    
    public void Add()
    {
        //Load a Document
        Document document = new Document(Path.Combine(_workFolder, _inputFile));

        //Create Annotation
        WatermarkAnnotation annotation = new WatermarkAnnotation(
            document.Pages[_model.Position.PageNumber], 
            new Rectangle(
                _model.Position.Llx, 
                _model.Position.Lly, 
                _model.Position.Urx,
                _model.Position.Ury,
                _model.Position.NormalizeCoordinates));

        //Create TextState for Font settings
        TextState ts = new TextState();

        ts.ForegroundColor = Color.Blue;
        ts.Font = FontRepository.FindFont("Times New Roman");

        ts.FontSize = 32;

        //Set opacity level of Annotaiton Text
        annotation.Opacity = 0.5;
        //Add Text in Annotation

        annotation.SetTextAndState(new string[] { "HELLO", "Line 1", "Line 2" }, ts);
        
        // Add annotation to the page
        document
            .Pages[_model.Position.PageNumber]
            .Annotations
            .Add(annotation);

        //Save the Document
        document.Save(Path.Combine(_workFolder, _outputFile));
    }
}