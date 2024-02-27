using Aspose.Pdf;
using Aspose.Pdf.Annotations;

namespace aspose.pdf.annotation;

public class RedactAnnotator : IAnnotator
{
    public void Add()
    {
        // For complete examples and data files, please go to https://github.com/aspose-pdf/Aspose.PDF-for-.NET
        // The path to the documents directory.
        string dataDir = "./examples";

        // Open document
        Document doc = new Document(dataDir + "input.pdf");

        // Create RedactionAnnotation instance for specific page region
        RedactionAnnotation annot = new RedactionAnnotation(doc.Pages[1], new Aspose.Pdf.Rectangle(200, 500, 300, 600));
        annot.FillColor = Aspose.Pdf.Color.Green;
        annot.BorderColor = Aspose.Pdf.Color.Yellow;
        annot.Color = Aspose.Pdf.Color.Blue;
        // Text to be printed on redact annotation
        annot.OverlayText = "REDACTED";
        annot.TextAlignment = Aspose.Pdf.HorizontalAlignment.Center;
        // Repat Overlay text over redact Annotation
        annot.Repeat = true;
        // Add annotation to annotations collection of first page
        doc.Pages[1].Annotations.Add(annot);
        // Flattens annotation and redacts page contents (i.e. removes text and image
        // Under redacted annotation)
        annot.Redact();
        dataDir = dataDir + "RedactPage_out.pdf";
        doc.Save(dataDir);
    }
}