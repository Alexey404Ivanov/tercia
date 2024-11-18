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
        try
        {
            var courses = await Database.GetAllCourses();

            foreach (var course in courses)
                Courses.Add(course);
        }
        catch (Exception)
        {
            await DisplayAlert("Ошибка сети", "Не удалось загрузить курсы", "Ок");
        }
    }
    
    private async void OnItemSelected(object? sender, SelectedItemChangedEventArgs e)
    {
        await Navigation.PushAsync(new CoursePage((Course)e.SelectedItem));
    }
}