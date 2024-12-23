using Tercia.TerciaCore;

namespace Tercia.Pages.Courses;

public partial class ViewLessonPage : ContentPage
{
    public ViewLessonPage(Lesson lesson)
    {
        InitializeComponent();
        BindingContext = lesson;
    }
}