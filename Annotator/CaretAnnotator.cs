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
        var caretAnnotation1 = new CaretAnnotation(document.Pages[1], new Rectangle(299.988, 713.664, 308.708, 720.769))
        {
            Title = "Aspose User",
            Subject = "Inserted text 1",
            Flags = AnnotationFlags.Print,
            Color = Color.Blue
        };

        document.Pages[1].Annotations.Add(caretAnnotation1);

        document.Save(Path.Combine(_workFolder, _outputFile));
    }
}