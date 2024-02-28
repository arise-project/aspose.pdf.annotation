using Aspose.Pdf;
using aspose.pdf.annotation.Model;
using Aspose.Pdf.Annotations;
using Aspose.Pdf.Text;

namespace aspose.pdf.annotation;

public class WatermarkAnnotator : IAnnotator
{
    private readonly WatermarkModel _model;
    private readonly string _workFolder;
    private readonly string _inputFile;
    private readonly string _outputFile;

    public WatermarkAnnotator(WatermarkModel model, string workFolder, string inputFile, string outputFile)
    {
        _model = model;
        _workFolder = workFolder;
        _inputFile = inputFile;
        _outputFile = outputFile;
    }
    
    public void Add()
    {
        //Load a Document
        Document doc = new Document(Path.Combine(_workFolder, _inputFile));

        //Load Page object to add Annotation
        Page page = doc.Pages[1];

        //Create Annotation
        WatermarkAnnotation wa = new WatermarkAnnotation(page, new Rectangle(100, 500, 400, 600));

        //Add annotaiton into Annotation collection of Page
        page.Annotations.Add(wa);

        //Create TextState for Font settings
        TextState ts = new TextState();

        ts.ForegroundColor = Color.Blue;
        ts.Font = FontRepository.FindFont("Times New Roman");

        ts.FontSize = 32;

        //Set opacity level of Annotaiton Text
        wa.Opacity = 0.5;
        //Add Text in Annotation

        wa.SetTextAndState(new string[] { "HELLO", "Line 1", "Line 2" }, ts);

        //Save the Document
        doc.Save(Path.Combine(_workFolder, _outputFile));
    }
}