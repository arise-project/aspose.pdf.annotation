using Aspose.Pdf;
using aspose.pdf.annotation.Model;
using Aspose.Pdf.Annotations;

namespace aspose.pdf.annotation;

public class CaretAnnotator : IAnnotator
{
    private readonly CaretModel _model;
    private readonly string _workFolder;
    private readonly string _inputFile;
    private readonly string _outputFile;

    public CaretAnnotator(CaretModel model, string workFolder, string inputFile, string outputFile)
    {
        _model = model;
        _workFolder = workFolder;
        _inputFile = inputFile;
        _outputFile = outputFile;
    }
    
    public void Add()
    {
        // Load the PDF file
        Document document = new Document(Path.Combine(_workFolder, _inputFile));
        
        // This annotation is used to indicate the insertion of text
        var caretAnnotation = new CaretAnnotation(
            document.Pages[_model.Position.PageNumber], 
            new Rectangle(
                _model.Position.Llx, 
                _model.Position.Lly, 
                _model.Position.Urx,
                _model.Position.Ury,
                _model.Position.NormalizeCoordinates))
        {
            Title = _model.Title,
            Subject = _model.Subject,
            Flags = _model.Flags,
            Color = _model.Color
        };

        document
            .Pages[_model.Position.PageNumber]
            .Annotations
            .Add(caretAnnotation);
        
        document.Save(Path.Combine(_workFolder, _outputFile));
    }
}