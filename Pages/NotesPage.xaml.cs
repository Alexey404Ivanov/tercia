namespace Tercia;

public partial class NotesPage 
{
    public NotesPage()
    {
        InitializeComponent();
    }

    private async void OnNote1Clicked(object? sender, EventArgs e)
    {
        await Navigation.PushAsync(new NotesSectionPage("notes1.png"));
    }
    
    private async void OnNote2Clicked(object? sender, EventArgs e)
    {
        await Navigation.PushAsync(new NotesSectionPage("notes2.jpg"));
    }
    
    private async void OnNote3Clicked(object? sender, EventArgs e)
    {
        await Navigation.PushAsync(new NotesSectionPage("notes3.jpg"));
    }
    
    private async void OnNote4Clicked(object? sender, EventArgs e)
    {
        await Navigation.PushAsync(new NotesSectionPage("notes4.jpg"));
    }
    
    private async void OnNote5Clicked(object? sender, EventArgs e)
    {
        await Navigation.PushAsync(new NotesSectionPage("notes5.jpg"));
    }
}