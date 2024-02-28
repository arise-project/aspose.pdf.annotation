using aspose.pdf.annotation.Model;

namespace aspose.pdf.annotation;

internal class Program
{
    public static void Main(string[] args)
    {
        new Tests().Run();
        return;

        object model  = new ReadLineCli().CreateModel();
        switch (model)
        {
            case CaretModel caretModel:
                new CaretAnnotator(caretModel, "./examples", "text.pdf", "caret.pdf").Save();
                break;
            case CircleModel circleModel:
                new CircleAnnotator(circleModel, "./examples", "text.pdf", "circle.pdf").Save();
                break;
            case FreeTextModel freeTextModel:
                new FreeTextAnnotator(freeTextModel, "./examples", "text.pdf", "free-text.pdf").Save();
                break;
            case HighlightModel highlightModel:
                new HighlightAnnotator(highlightModel, "./examples", "text.pdf", "highlight.pdf").Save();
                break;
            case InkModel inkModel:
                new InkAnnotator(inkModel, "./examples", "text.pdf", "ink.pdf").Save();
                break;
            case LineModel lineModel:
                new LineAnnotator(lineModel, "./examples", "text.pdf", "line.pdf").Save();
                break;
            case LinkModel linkModel:
                new LinkAnnotator(linkModel, "./examples", "text.pdf", "link.pdf").Save();
                break;
            case MovieModel movieModel:
                new MovieAnnotator(movieModel, "./examples", "text.pdf", "movie.pdf").Save();
                break;
            case PolygonModel polygonModel:
                new PolygonAnnotator(polygonModel, "./examples", "text.pdf", "polygon.pdf").Save();
                break;
            case PolyLineModel polyLineModel:
                new PolyLineAnnotator(polyLineModel, "./examples", "text.pdf", "polyLine.pdf").Save();
                break;
            case RedactModel redactModel:
                new RedactAnnotator(redactModel, "./examples", "text.pdf", "redact.pdf").Save();
                break;
            case ScreenModel screenModel:
                new ScreenAnnotator(screenModel, "./examples", "text.pdf", "screen.pdf").Save();
                break;
            case SoundModel soundModel:
                new SoundAnnotator(soundModel, "./examples", "text.pdf", "sound.pdf").Save();
                break;
            case SquareModel squareModel:
                new SquareAnnotator(squareModel, "./examples", "text.pdf", "square.pdf").Save();
                break;
            case SquigglyModel squigglyModel:
                new SquigglyAnnotator(squigglyModel, "./examples", "text.pdf", "squiggly.pdf").Save();
                break;
            case StampModel stampModel:
                new StampAnnotator(stampModel, "./examples", "text.pdf", "stamp.pdf").Save();
                break;
            case StrikeOutModel strikeOutModel:
                new StrikeOutAnnotator(strikeOutModel, "./examples", "text.pdf", "strike-out.pdf").Save();
                break;
            case TextModel textModel:
                new TextAnnotator(textModel, "./examples", "text.pdf", "text.pdf").Save();
                break;
            case UnderlineModel underlineModel:
                new UnderlineAnnotator(underlineModel, "./examples", "text.pdf", "underline.pdf").Save();
                break;
            case WatermarkModel watermarkModel:
                new WatermarkAnnotator(watermarkModel, "./examples", "text.pdf", "watermark.pdf").Save();
                break;
            default:
                Console.WriteLine("unknown:"+ model.GetType());
                break;
        }
    }
}