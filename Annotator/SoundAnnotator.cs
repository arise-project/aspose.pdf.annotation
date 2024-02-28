using Aspose.Pdf;
using aspose.pdf.annotation.Model;
using Aspose.Pdf.Annotations;

namespace aspose.pdf.annotation;

public class SoundAnnotator : IAnnotator
{
    private readonly SoundModel _model;
    private readonly string _workFolder;

    public SoundAnnotator(SoundModel model, string workFolder)
    {
        _model = model;
        _workFolder = workFolder;
    }

    public void Add()
    {
        // Load the PDF file
        Document document = new Document(System.IO.Path.Combine(_workFolder, "sample.pdf"));

        var mediaFile = System.IO.Path.Combine("./examples", "input.swf");
        // Create Screen Annotation
        var screenAnnotation = new ScreenAnnotation(
            document.Pages[1],
            new Rectangle(170, 190, 470, 380),
            mediaFile);
        document.Pages[1].Annotations.Add(screenAnnotation);

        document.Save(System.IO.Path.Combine(_workFolder, "sample_swf.pdf"));
    }
}