using Aspose.Pdf;
using aspose.pdf.annotation.Model;
using Aspose.Pdf.Annotations;

namespace aspose.pdf.annotation;

public class TextAnnotator : IAnnotator
{
    private readonly TextModel _model;
    private readonly string _workFolder;
    private readonly string _inputFile;
    private readonly string _outputFile;

    public TextAnnotator(TextModel model, string workFolder, string inputFile, string outputFile)
    {
        _model = model;
        _workFolder = workFolder;
        _inputFile = inputFile;
        _outputFile = outputFile;
    }
    
    public void Add()
    {
        // Open document
        Document document = new Document(Path.Combine(_workFolder, _inputFile));

        // Create annotation
        TextAnnotation textAnnotation = new TextAnnotation(
            document.Pages[_model.Position.PageNumber], 
            new Rectangle(
                _model.Position.Llx, 
                _model.Position.Lly, 
                _model.Position.Urx,
                _model.Position.Ury));
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
        document.Pages[1].Annotations.Add(textAnnotation);
        // Save output file
        document.Save(Path.Combine(_workFolder, _outputFile));
    }
}