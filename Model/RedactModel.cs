using Aspose.Pdf;
using aspose.pdf.annotation.Model.Descriptions;
using System.Text.Json.Serialization;

namespace aspose.pdf.annotation.Model;

[Serializable]
public class RedactModel
{
    public PagePositionModel Position { get; set; } = new PagePositionModel();

    [JsonIgnore]
    public Color FillColorValue { get; set; } = Color.Aqua;
    
    [JsonIgnore] 
    public Color BorderColorValue { get;set; } = Color.Black;

    [JsonIgnore] 
    public Color ColorValue { get; set; } = Color.Beige;

    public string OverlayText { get; set; } = "CENSORED";
    
    [JsonIgnore] 
    public HorizontalAlignment TextAlignmentValue { get;set; } = HorizontalAlignment.Center;

    public bool Repeat { get; set; } = true;
}