using aspose.pdf.annotation.Model;

namespace aspose.pdf.annotation
{
    internal class Tests
    {
        public void Run()
        {
            //new CaretAnnotator(new CaretModel(), "./examples", "test.pdf", "caret.pdf").Save();
            //new CircleAnnotator(new CircleModel(), "./examples", "test.pdf", "circle.pdf").Save();
            //new FreeTextAnnotator(new FreeTextModel(), "./examples", "test.pdf", "free-text.pdf").Save();
            new HighlightAnnotator(new HighlightModel(), "./examples", "test.pdf", "highlight.pdf").Save();
            new InkAnnotator(new InkModel(), "./examples", "test.pdf", "ink.pdf").Save();
            new LineAnnotator(new LineModel(), "./examples", "test.pdf", "line.pdf").Save();
            new LinkAnnotator(new LinkModel(), "./examples", "test.pdf", "link.pdf").Save();
            new MovieAnnotator(new MovieModel(), "./examples", "test.pdf", "movie.pdf").Save();
            new PolygonAnnotator(new PolygonModel(), "./examples", "test.pdf", "polygon.pdf").Save();
            new PolyLineAnnotator(new PolyLineModel(), "./examples", "test.pdf", "polyLine.pdf").Save();
            new RedactAnnotator(new RedactModel(), "./examples", "test.pdf", "redact.pdf").Save();
            new ScreenAnnotator(new ScreenModel(), "./examples", "test.pdf", "screen.pdf").Save();
            new SoundAnnotator(new SoundModel(), "./examples", "test.pdf", "sound.pdf").Save();
            new SquareAnnotator(new SquareModel(), "./examples", "test.pdf", "square.pdf").Save();
            new SquigglyAnnotator(new SquigglyModel(), "./examples", "test.pdf", "squiggly.pdf").Save();
            new StampAnnotator(new StampModel(), "./examples", "test.pdf", "stamp.pdf").Save();
            new StrikeOutAnnotator(new StrikeOutModel(), "./examples", "test.pdf", "strike-out.pdf").Save();
            new TextAnnotator(new TextModel(), "./examples", "test.pdf", "text.pdf").Save();
            new UnderlineAnnotator(new UnderlineModel(), "./examples", "test.pdf", "underline.pdf").Save();
            new WatermarkAnnotator(new WatermarkModel(), "./examples", "test.pdf", "watermark.pdf").Save();
        }
    }
}
