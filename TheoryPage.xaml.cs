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

    private async void OnNotesPage(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NotesPage());
    }

    private async void OnCoursesPage(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CoursesPage());
    }

    private async void OnTheoryPage(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new TheoryPage());
    }

    private async void OnMetronomePage(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MetronomePage());
    }
}