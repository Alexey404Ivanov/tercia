namespace Tercia;

public partial class TheorySectionPage
{
    public string DisplayText { get; set; }
    
    public TheorySectionPage(string text)
    {
        InitializeComponent();
        DisplayText = text;
        BindingContext = this;
    }
}