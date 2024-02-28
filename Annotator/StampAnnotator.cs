using Aspose.Pdf;
using aspose.pdf.annotation.Model;

namespace aspose.pdf.annotation;

public class StampAnnotator : IAnnotator
{
    private readonly StampModel _model;
    private readonly string _workFolder;
    private readonly string _inputFile;
    private readonly string _outputFile;

    public StampAnnotator(StampModel model, string workFolder, string inputFile, string outputFile)
    {
        _model = model;
        _workFolder = workFolder;
        _inputFile = inputFile;
        _outputFile = outputFile;
    }

    public void Add()
    {
        // Open document
        Document pdfDocument = new Document(Path.Combine(_workFolder, _inputFile));

        // Create image stamp
        ImageStamp imageStamp = new ImageStamp(_workFolder + "aspose-logo.jpg");
        imageStamp.Background = true;
        imageStamp.XIndent = 100;
        imageStamp.YIndent = 100;
        imageStamp.Height = 300;
        imageStamp.Width = 300;
        imageStamp.Rotate = Rotation.on270;
        imageStamp.Opacity = 0.5;
        
        // Add stamp to particular page
        pdfDocument
            .Pages[_model.Page.PageNumber]
            .AddStamp(imageStamp);

        // Save output document
        pdfDocument.Save(Path.Combine(_workFolder, _outputFile));
    }
}