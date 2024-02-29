using Aspose.Pdf;
using aspose.pdf.annotation.Model.Descriptions;
using System.Text.Json.Serialization;

namespace aspose.pdf.annotation.Model;

[Serializable]
public class RedactModel
{
    public PagePositionModel Position { get; set; } = new PagePositionModel();

    [JsonIgnore]
    public Color FillColorValue { get; set; } = Aspose.Pdf.Color.Aqua;

    public string FillColor { get; set; } = "Aqua";

    [JsonIgnore] 
    public Color BorderColorValue { get;set; } = Aspose.Pdf.Color.Black;

    public string BorderColor { get; set; } = "Black";

    [JsonIgnore] 
    public Color ColorValue { get; set; } = Aspose.Pdf.Color.Beige;

    public string Color { get; set; } = "Beige";

    public string OverlayText { get; set; } = "CENSORED";
    
    [JsonIgnore] 
    public HorizontalAlignment TextAlignmentValue { get;set; } = HorizontalAlignment.Center;

    public string TextAlignment { get; set; } = "Center";

    public bool Repeat { get; set; } = true;
}