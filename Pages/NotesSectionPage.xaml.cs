namespace Tercia;

public partial class NotesSectionPage
{
    public string Note { get; set; }

    public NotesSectionPage(string note)
    {
        InitializeComponent();
        Note = note;
        BindingContext = this;
    }
}