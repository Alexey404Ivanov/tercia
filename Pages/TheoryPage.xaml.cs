namespace Tercia;

public partial class TheoryPage
{
    public TheoryPage()
    {
        InitializeComponent();
    }

    private void OnSis(object sender, EventArgs e)
    {
        
    }
    
    private async void OnAskingAiClicked(object sender, EventArgs e)
    {
        
    }

    private async void OnNotesPageClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NotesPage());
    }

    private async void OnCoursesPageClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CoursesPage());
    }

    private async void OnTheoryPageClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new TheoryPage());
    }

    private async void OnMetronomePageClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MetronomePage());
    }
}