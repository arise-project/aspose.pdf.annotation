// See https://aka.ms/new-console-template for more information

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
                break;
            case CircleModel circleModel:
                break;
            case FreeTextModel freeTextModel:
                break;
            case HighlightModel highlightModel: 
                break;
            case InkModel inkModel: 
                break;
            case LineModel lineModel: 
                break;
            case LinkModel linkModel:
                break;
            case MovieModel movieModel: 
                break;
            case PolygonModel polygonModel: 
                break;
            case PolyLineModel polyLineModel: 
                break;
            case RedactModel redactModel: 
                break;
            case ScreenModel screenModel: 
                break;
            case SoundModel soundModel: 
                break;
            case SquareModel squareModel:
                break;
            case SquigglyModel squigglyModel: 
                break;
            case StampModel stampModel: 
                break;
            case StrikeOutModel strikeOutModel: 
                break;
            case TextModel textModel: 
                break;
            case UnderlineModel underlineModel:
                break;
            case WatermarkModel watermarkModel:
                break;
            default:
                Console.WriteLine("unknown:"+ model.GetType());
                break;
        }
    }
}