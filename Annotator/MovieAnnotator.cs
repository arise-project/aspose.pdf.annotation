using Aspose.Pdf;
using aspose.pdf.annotation.Model;
using Aspose.Pdf.Annotations;

namespace aspose.pdf.annotation;

public class MovieAnnotator : IAnnotator
{
    private readonly MovieModel _model;

    public MovieAnnotator(MovieModel model)
    {
        _model = model;
    }

    public void Add()
    {
        // Load the PDF file
        Document document = new Document(System.IO.Path.Combine("./examples", "sample.pdf"));

        var mediaFile = System.IO.Path.Combine("./examples", "input.swf");
        // Create Screen Annotation
        var screenAnnotation = new ScreenAnnotation(
            document.Pages[1],
            new Rectangle(170, 190, 470, 380),
            mediaFile);
        document.Pages[1].Annotations.Add(screenAnnotation);

        document.Save(System.IO.Path.Combine("./examples", "sample_swf.pdf"));
    }
}