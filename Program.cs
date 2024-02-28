using aspose.pdf.annotation.Model;

namespace aspose.pdf.annotation;

internal class Program
{
    public static void Main(string[] args)
    {
        object model  = new ReadLineCli().CreateModel();
        switch (model)
        {
            case CaretModel caretModel:
                new CaretAnnotator(caretModel, "./examples", "text.pdf", "caret.pdf").Add();
                break;
            case CircleModel circleModel:
                new CircleAnnotator(circleModel, "./examples", "text.pdf", "caret.pdf").Add();
                break;
            case FreeTextModel freeTextModel:
                new FreeTextAnnotator(freeTextModel, "./examples", "text.pdf", "caret.pdf").Add();
                break;
            case HighlightModel highlightModel:
                new HighlightAnnotator(highlightModel, "./examples", "text.pdf", "caret.pdf").Add();
                break;
            case InkModel inkModel:
                new InkAnnotator(inkModel, "./examples", "text.pdf", "caret.pdf").Add();
                break;
            case LineModel lineModel:
                new LineAnnotator(lineModel, "./examples", "text.pdf", "caret.pdf").Add();
                break;
            case LinkModel linkModel:
                new LinkAnnotator(linkModel, "./examples", "text.pdf", "caret.pdf").Add();
                break;
            case MovieModel movieModel:
                new MovieAnnotator(movieModel, "./examples", "text.pdf", "caret.pdf").Add();
                break;
            case PolygonModel polygonModel:
                new PolygonAnnotator(polygonModel, "./examples", "text.pdf", "caret.pdf").Add();
                break;
            case PolyLineModel polyLineModel:
                new PolyLineAnnotator(polyLineModel, "./examples", "text.pdf", "caret.pdf").Add();
                break;
            case RedactModel redactModel:
                new RedactAnnotator(redactModel, "./examples", "text.pdf", "caret.pdf").Add();
                break;
            case ScreenModel screenModel:
                new ScreenAnnotator(screenModel, "./examples", "text.pdf", "caret.pdf").Add();
                break;
            case SoundModel soundModel:
                new SoundAnnotator(soundModel, "./examples", "text.pdf", "caret.pdf").Add();
                break;
            case SquareModel squareModel:
                new SquareAnnotator(squareModel, "./examples", "text.pdf", "caret.pdf").Add();
                break;
            case SquigglyModel squigglyModel:
                new SquigglyAnnotator(squigglyModel, "./examples", "text.pdf", "caret.pdf").Add();
                break;
            case StampModel stampModel:
                new StampAnnotator(stampModel, "./examples", "text.pdf", "caret.pdf").Add();
                break;
            case StrikeOutModel strikeOutModel:
                new StrikeOutAnnotator(strikeOutModel, "./examples", "text.pdf", "caret.pdf").Add();
                break;
            case TextModel textModel:
                new TextAnnotator(textModel, "./examples", "text.pdf", "caret.pdf").Add();
                break;
            case UnderlineModel underlineModel:
                new UnderlineAnnotator(underlineModel, "./examples", "text.pdf", "caret.pdf").Add();
                break;
            case WatermarkModel watermarkModel:
                new WatermarkAnnotator(watermarkModel, "./examples", "text.pdf", "caret.pdf").Add();
                break;
            default:
                Console.WriteLine("unknown:"+ model.GetType());
                break;
        }
    }
}