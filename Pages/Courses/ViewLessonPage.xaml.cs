using Tercia.TerciaCore;

namespace Tercia.Pages.Courses;

public partial class ViewLessonPage : ContentPage
{
    public ViewLessonPage(Lesson lesson)
    {
        InitializeComponent();
        LessonTitle.Text = lesson.Title;
        VideoPlayer.Source = lesson.Link;
        VideoPlayer.Reload();
    }
}