using Aspose.Pdf;
using aspose.pdf.annotation.Model;
using Aspose.Pdf.Annotations;

namespace aspose.pdf.annotation;

public class SquareAnnotator : IAnnotator
{
    private readonly SquareModel _model;
    private readonly string _workFolder;
    private readonly string _inputFile;
    private readonly string _outputFile;

    public SquareAnnotator(SquareModel model, string workFolder, string inputFile, string outputFile)
    {
        _model = model;
        _workFolder = workFolder;
        _inputFile = inputFile;
        _outputFile = outputFile;
    }

    public void Add()
    {
        var dataDir = "<path-to-file>";
        // Load the PDF file
        Document document = new Document(Path.Combine(dataDir, _inputFile));

        // Create Square Annotation
        var squareAnnotation = new SquareAnnotation(document.Pages[1], new Rectangle(67, 317, 261, 459))
        {
            Title = "John Smith",
            Subject = "Rectangle",
            Color = Color.Blue,
            InteriorColor = Color.BlueViolet,
            Opacity = 0.25,
            Popup = new PopupAnnotation(document.Pages[1], new Rectangle(842, 196, 1021, 338))
        };

        // Add annotation to the page
        document.Pages[1].Annotations.Add(squareAnnotation);
        document.Save(Path.Combine(dataDir, _outputFile));
    }
}