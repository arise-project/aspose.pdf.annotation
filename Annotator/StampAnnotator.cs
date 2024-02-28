using Aspose.Pdf;
using aspose.pdf.annotation.Model;

namespace aspose.pdf.annotation;

public class StampAnnotator : IAnnotator
{
    private readonly StampModel _model;
    private readonly string _workFolder;

    public StampAnnotator(StampModel model, string workFolder)
    {
        _model = model;
        _workFolder = workFolder;
    }

    public void Add()
    {
        // Open document
        Document pdfDocument = new Document(_workFolder + "AddImageStamp.pdf");

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
        pdfDocument.Pages[1].AddStamp(imageStamp);

        // Save output document
        pdfDocument.Save(_workFolder + "AddImageStamp_out.pdf");
    }
}