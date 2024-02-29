using Aspose.Pdf;
using aspose.pdf.annotation.Model.Descriptions;
using System.Text.Json.Serialization;

namespace aspose.pdf.annotation.Model;

[Serializable]
public class CircleModel
{
    public PagePositionModel Position { get; set; } = new PagePositionModel();
    
    public TitleModel Title { get; set; } = new TitleModel();

    [JsonIgnore]
    public Color InteriorColorValue { get; set; } = Color.Aqua;

    public string InteriorColor { get; set; } = "Aqua";

    public PagePositionModel Popup { get; set; } = new PagePositionModel();
}