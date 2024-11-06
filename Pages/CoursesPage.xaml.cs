using System.Collections.ObjectModel;
using Tercia.Pages.Courses;
using Tercia.TerciaCore;

namespace Tercia.Pages;

public partial class CoursesPage
{
    public ObservableCollection<Course> Courses { get; }
    public CoursesPage()
    {
        InitializeComponent();
        Courses = new(Database.GetAllCourses());
        BindingContext = this;
    }

    private async void OnItemSelected(object? sender, SelectedItemChangedEventArgs e)
    {
        await Navigation.PushAsync(new CoursePage((Course)e.SelectedItem));
    }
}