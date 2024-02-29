using aspose.pdf.annotation.Model;

namespace aspose.pdf.annotation;

internal class Program
{
    public static void Main(string[] args)
    {
        //new Tests().Run();
        //return;

        object model  = new ReadLineCli().CreateModel();
        switch (model)
        {
            case CaretModel caretModel:
                new CaretAnnotator(caretModel, "./examples", "test.pdf", "caret.pdf").Save();
                break;
            case CircleModel circleModel:
                new CircleAnnotator(circleModel, "./examples", "test.pdf", "circle.pdf").Save();
                break;
            case FreeTextModel freeTextModel:
                new FreeTextAnnotator(freeTextModel, "./examples", "test.pdf", "free-text.pdf").Save();
                break;
            case HighlightModel highlightModel:
                new HighlightAnnotator(highlightModel, "./examples", "test.pdf", "highlight.pdf").Save();
                break;
            case InkModel inkModel:
                new InkAnnotator(inkModel, "./examples", "test.pdf", "ink.pdf").Save();
                break;
            case LineModel lineModel:
                new LineAnnotator(lineModel, "./examples", "test.pdf", "line.pdf").Save();
                break;
            case LinkModel linkModel:
                new LinkAnnotator(linkModel, "./examples", "test.pdf", "link.pdf").Save();
                break;
            case MovieModel movieModel:
                new MovieAnnotator(movieModel, "./examples", "test.pdf", "movie.pdf").Save();
                break;
            case PolygonModel polygonModel:
                new PolygonAnnotator(polygonModel, "./examples", "test.pdf", "polygon.pdf").Save();
                break;
            case PolyLineModel polyLineModel:
                new PolyLineAnnotator(polyLineModel, "./examples", "test.pdf", "polyLine.pdf").Save();
                break;
            case RedactModel redactModel:
                new RedactAnnotator(redactModel, "./examples", "test.pdf", "redact.pdf").Save();
                break;
            case ScreenModel screenModel:
                new ScreenAnnotator(screenModel, "./examples", "test.pdf", "screen.pdf").Save();
                break;
            case SoundModel soundModel:
                new SoundAnnotator(soundModel, "./examples", "test.pdf", "sound.pdf").Save();
                break;
            case SquareModel squareModel:
                new SquareAnnotator(squareModel, "./examples", "test.pdf", "square.pdf").Save();
                break;
            case SquigglyModel squigglyModel:
                new SquigglyAnnotator(squigglyModel, "./examples", "test.pdf", "squiggly.pdf").Save();
                break;
            case StampModel stampModel:
                new StampAnnotator(stampModel, "./examples", "test.pdf", "stamp.pdf").Save();
                break;
            case StrikeOutModel strikeOutModel:
                new StrikeOutAnnotator(strikeOutModel, "./examples", "test.pdf", "strike-out.pdf").Save();
                break;
            case TextModel textModel:
                new TextAnnotator(textModel, "./examples", "test.pdf", "text.pdf").Save();
                break;
            case UnderlineModel underlineModel:
                new UnderlineAnnotator(underlineModel, "./examples", "test.pdf", "underline.pdf").Save();
                break;
            case WatermarkModel watermarkModel:
                new WatermarkAnnotator(watermarkModel, "./examples", "test.pdf", "watermark.pdf").Save();
                break;
            default:
                Console.WriteLine("unknown:"+ model.GetType());
                break;
        }
    }
}