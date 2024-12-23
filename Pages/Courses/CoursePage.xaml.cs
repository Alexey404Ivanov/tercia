using System.Collections.ObjectModel;
using Tercia.TerciaCore;

namespace Tercia.Pages.Courses;

public partial class CoursePage : ContentPage
{
    public ObservableCollection<Lesson> Lessons { get; set; }
    private readonly Course _course;
    public CoursePage(Course course)
    {
        InitializeComponent();
        CourseName.Text = course.Name;
        _course = course;
        Lessons = new ObservableCollection<Lesson>();
        BindingContext = this;
    }
    
    protected override async void OnAppearing()
    {
        if (Lessons.Count > 0)
            return;
        try
        {
            var lessons = await Database.GetCourseLessons(_course.Id);
            foreach (var lesson in lessons)
                Lessons.Add(lesson);
        }
        catch (Exception)
        {
            await DisplayAlert("Ошибка сети", "Не удалось загрузить уроки", "Ок");
        }
    }

    private void OnItemSelected(object? sender, SelectedItemChangedEventArgs e)
    {
        Navigation.PushAsync(new ViewLessonPage((Lesson)e.SelectedItem));
    }
}