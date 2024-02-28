using Aspose.Pdf;
using aspose.pdf.annotation.Model;
using Aspose.Pdf.Annotations;

namespace aspose.pdf.annotation;

public class InkAnnotator : IAnnotator
{
    private readonly InkModel _model;
    private readonly string _workFolder;
    private readonly string _inputFile;
    private readonly string _outputFile;

    public InkAnnotator(InkModel model, string workFolder, string inputFile, string outputFile)
    {
        _model = model;
        _workFolder = workFolder;
        _inputFile = inputFile;
        _outputFile = outputFile;
    }

    public void Add()
    {
        // Load the PDF file
        Document document = new Document(Path.Combine(_workFolder, _inputFile));
        Page page = document.Pages[1];

        Rectangle arect = new Rectangle(156.574, 521.316, 541.168, 575.703);

        IList<Point[]> inkList = new List<Point[]>();
        Point[] arrpt = new[]
        {
            new Point(209.727,542.263),
            new Point(209.727,541.94),
            new Point(209.727,541.616)
        };
        inkList.Add(arrpt);

        InkAnnotation ia = new InkAnnotation(page, arect, inkList)
        {
            Title = "John Smith",
            Subject = "Pencil",
            Color = Color.LightBlue,
            CapStyle = CapStyle.Rounded,
            Opacity = 0.5
        };
        Border border = new Border(ia)
        {
            Width = 25
        };
        ia.Border = border;
        page.Annotations.Add(ia);

// Save output file
        document.Save(Path.Combine(_workFolder, _outputFile));
    }
}