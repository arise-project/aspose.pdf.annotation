using Aspose.Pdf;
using aspose.pdf.annotation.Model;
using Aspose.Pdf.Annotations;

namespace aspose.pdf.annotation;

public class CircleAnnotator : IAnnotator
{
    private readonly CircleModel _model;
    private readonly string _workFolder;
    private readonly string _inputFile;
    private readonly string _outputFile;

    public CircleAnnotator(CircleModel model, string workFolder, string inputFile, string outputFile)
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

        // Create Cirlce Annotation
        var circleAnnotation = new CircleAnnotation(
            document.Pages[_model.Position.PageNumber], 
            new Rectangle(
                _model.Position.Llx, 
                _model.Position.Lly, 
                _model.Position.Urx,
                _model.Position.Ury))
        {
            Title = "John Smith",
            Subject = "Circle",
            Color = Color.Red,
            InteriorColor = Color.MistyRose,
            Opacity = 0.5,        
            Popup = new PopupAnnotation(document.Pages[1], new Rectangle(842, 316, 1021, 459))
        };

        // Add annotation to the page
        document.Pages[1].Annotations.Add(circleAnnotation);
        document.Save(Path.Combine(_workFolder, _outputFile));
    }
}