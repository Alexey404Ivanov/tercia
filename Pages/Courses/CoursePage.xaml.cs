using Tercia.TerciaCore;

namespace Tercia.Pages.Courses;

public partial class CoursePage : ContentPage
{
    public CoursePage(Course course)
    {
        InitializeComponent();
        CourseName.Text = course.Name;
        LessonsList.ItemsSource = course.Lessons;
    }

    private void OnItemSelected(object? sender, SelectedItemChangedEventArgs e)
    {
        Navigation.PushAsync(new ViewLessonPage((Lesson)e.SelectedItem));
    }
}