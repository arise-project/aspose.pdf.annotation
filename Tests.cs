using aspose.pdf.annotation.Model;

namespace aspose.pdf.annotation
{
    internal class Tests
    {
        public void Run()
        {
            new CaretAnnotator(new CaretModel(), "./examples", "text.pdf", "caret.pdf").Save();
            new CircleAnnotator(new CircleModel(), "./examples", "text.pdf", "circle.pdf").Save();
            new FreeTextAnnotator(new FreeTextModel(), "./examples", "text.pdf", "free-text.pdf").Save();
            new HighlightAnnotator(new HighlightModel(), "./examples", "text.pdf", "highlight.pdf").Save();
            new InkAnnotator(new InkModel(), "./examples", "text.pdf", "ink.pdf").Save();
            new LineAnnotator(new LineModel(), "./examples", "text.pdf", "line.pdf").Save();
            new LinkAnnotator(new LinkModel(), "./examples", "text.pdf", "link.pdf").Save();
            new MovieAnnotator(new MovieModel(), "./examples", "text.pdf", "movie.pdf").Save();
            new PolygonAnnotator(new PolygonModel(), "./examples", "text.pdf", "polygon.pdf").Save();
            new PolyLineAnnotator(new PolyLineModel(), "./examples", "text.pdf", "polyLine.pdf").Save();
            new RedactAnnotator(new RedactModel(), "./examples", "text.pdf", "redact.pdf").Save();
            new ScreenAnnotator(new ScreenModel(), "./examples", "text.pdf", "screen.pdf").Save();
            new SoundAnnotator(new SoundModel(), "./examples", "text.pdf", "sound.pdf").Save();
            new SquareAnnotator(new SquareModel(), "./examples", "text.pdf", "square.pdf").Save();
            new SquigglyAnnotator(new SquigglyModel(), "./examples", "text.pdf", "squiggly.pdf").Save();
            new StampAnnotator(new StampModel(), "./examples", "text.pdf", "stamp.pdf").Save();
            new StrikeOutAnnotator(new StrikeOutModel(), "./examples", "text.pdf", "strike-out.pdf").Save();
            new TextAnnotator(new TextModel(), "./examples", "text.pdf", "text.pdf").Save();
            new UnderlineAnnotator(new UnderlineModel(), "./examples", "text.pdf", "underline.pdf").Save();
            new WatermarkAnnotator(new WatermarkModel(), "./examples", "text.pdf", "watermark.pdf").Save();
        }
    }
}
