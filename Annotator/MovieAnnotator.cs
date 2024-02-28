using Aspose.Pdf;
using aspose.pdf.annotation.Model;
using Aspose.Pdf.Annotations;

namespace aspose.pdf.annotation;

public class MovieAnnotator : IAnnotator
{
    private readonly MovieModel _model;
    private readonly string _workFolder;
    private readonly string _inputFile;
    private readonly string _outputFile;

    public MovieAnnotator(MovieModel model, string workFolder, string inputFile, string outputFile)
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

        var mediaFile = System.IO.Path.Combine("./examples", "input.swf");
        // Create Screen Annotation
        var screenAnnotation = new ScreenAnnotation(
            document.Pages[_model.Position.PageNumber], 
            new Rectangle(
                _model.Position.Llx, 
                _model.Position.Lly, 
                _model.Position.Urx,
                _model.Position.Ury),
            mediaFile);
        document.Pages[1].Annotations.Add(screenAnnotation);

        document.Save(Path.Combine(_workFolder, _outputFile));
    }
}