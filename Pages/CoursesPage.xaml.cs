using System.Collections.ObjectModel;
using Tercia.Pages.Courses;
using Tercia.TerciaCore;

namespace Tercia.Pages;

public partial class CoursesPage
{
    public ObservableCollection<Course> Courses { get; set; }
    
    public CoursesPage()
    {
        InitializeComponent();
        Courses = new();
        BindingContext = this;
                
    }

    protected override async void OnAppearing()
    {
        if (Courses.Count > 0)
            return;
        var courses = await Database.GetAllCourses();
        if (courses is null)
            //TODO: сообщение об ошибке
            return;
        
        foreach (var course in courses)
            Courses.Add(course);
    }
    
    private async void OnItemSelected(object? sender, SelectedItemChangedEventArgs e)
    {
        await Navigation.PushAsync(new CoursePage((Course)e.SelectedItem));
    }
}