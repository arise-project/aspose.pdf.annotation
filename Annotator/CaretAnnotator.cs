using Aspose.Pdf;
using aspose.pdf.annotation.Model;
using Aspose.Pdf.Annotations;

namespace aspose.pdf.annotation;

public class CaretAnnotator : IAnnotator
{
    private readonly CaretModel _model;
    private readonly string _workFolder;

    public CaretAnnotator(CaretModel model, string workFolder)
    {
        _model = model;
        _workFolder = workFolder;
    }
    
    public void Add()
    {
        // Load the PDF file
        Document document = new Document(System.IO.Path.Combine(_workFolder, "sample.pdf"));
        // This annotation is used to indicate the insertion of text
        var caretAnnotation1 = new CaretAnnotation(document.Pages[1], new Rectangle(299.988, 713.664, 308.708, 720.769))
        {
            Title = "Aspose User",
            Subject = "Inserted text 1",
            Flags = AnnotationFlags.Print,
            Color = Color.Blue
        };

        document.Pages[1].Annotations.Add(caretAnnotation1);

        document.Save(System.IO.Path.Combine(_workFolder, "sample_caret.pdf"));
    }
}