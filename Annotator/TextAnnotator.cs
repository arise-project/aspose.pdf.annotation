using Aspose.Pdf;
using aspose.pdf.annotation.Model;
using Aspose.Pdf.Annotations;

namespace aspose.pdf.annotation;

public class TextAnnotator : IAnnotator
{
    private readonly TextModel _model;

    public TextAnnotator(TextModel model)
    {
        _model = model;
    }
    
    public void Add()
    {
        // For complete examples and data files, please go to https://github.com/aspose-pdf/Aspose.PDF-for-.NET
        // The path to the documents directory.
        string dataDir = "./example";

        // Open document
        Document pdfDocument = new Document(dataDir + "AddAnnotation.pdf");

        // Create annotation
        TextAnnotation textAnnotation = new TextAnnotation(pdfDocument.Pages[1], new Aspose.Pdf.Rectangle(200, 400, 400, 600));
        textAnnotation.Title = "Sample Annotation Title";
        textAnnotation.Subject = "Sample Subject";
        // ? textAnnotation.State = AnnotationState.Accepted;
        textAnnotation.Contents = "Sample contents for the annotation";
        textAnnotation.Open = true;
        textAnnotation.Icon = TextIcon.Key;

        Border border = new Border(textAnnotation);
        border.Width = 5;
        border.Dash = new Dash(1, 1);
        textAnnotation.Border = border;
        textAnnotation.Rect = new Aspose.Pdf.Rectangle(200, 400, 400, 600);

        // Add annotation in the annotations collection of the page
        pdfDocument.Pages[1].Annotations.Add(textAnnotation);
        dataDir = dataDir + "AddAnnotation_out.pdf";
        // Save output file
        pdfDocument.Save(dataDir);
    }
}