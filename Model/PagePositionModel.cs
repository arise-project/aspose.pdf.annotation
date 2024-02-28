namespace aspose.pdf.annotation.Model;

public class PagePositionModel : PageModel
{
    ///X of lower left corner
    public double Llx { get; set; }
    
    ///Y of lower left corner
    public double Lly { get; set; } 
    
    ///X of upper right corner
    public double Urx { get; set; } 
    
    ///Y of upper right corner
    public double Ury { get; set; }

    ///Normalize coordinates of rectangle
    public bool NormalizeCoordinates { get; set; } = true;
}