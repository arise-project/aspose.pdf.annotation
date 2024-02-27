using Aspose.Pdf;
using aspose.pdf.annotation.Model;

namespace aspose.pdf.annotation;

public class StampAnnotator : IAnnotator
{
    private readonly StampModel _model;

    public StampAnnotator(StampModel model)
    {
        _model = model;
    }

    public void Add()
    {
        // For complete examples and data files, please go to https://github.com/aspose-pdf/Aspose.PDF-for-.NET
        // The path to the documents directory.
        string dataDir = "./examples";

        // Open document
        Document pdfDocument = new Document(dataDir + "AddImageStamp.pdf");

        // Create image stamp
        ImageStamp imageStamp = new ImageStamp(dataDir + "aspose-logo.jpg");
        imageStamp.Background = true;
        imageStamp.XIndent = 100;
        imageStamp.YIndent = 100;
        imageStamp.Height = 300;
        imageStamp.Width = 300;
        imageStamp.Rotate = Rotation.on270;
        imageStamp.Opacity = 0.5;
        // Add stamp to particular page
        pdfDocument.Pages[1].AddStamp(imageStamp);

        dataDir = dataDir + "AddImageStamp_out.pdf";
        // Save output document
        pdfDocument.Save(dataDir);
    }
}