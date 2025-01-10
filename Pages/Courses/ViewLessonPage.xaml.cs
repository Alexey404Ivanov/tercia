using Tercia.TerciaCore;

namespace Tercia.Pages.Courses;

public partial class ViewLessonPage : ContentPage
{
    public double PlayerWidth => DeviceDisplay.MainDisplayInfo.Width;
    public double PlayerHeight => PlayerWidth / 16.0 * 9;
    public string VideoUrl { get; set; }
    public string Title { get; set; }

    public ViewLessonPage(Lesson lesson)
    {
        InitializeComponent();
        VideoUrl = lesson.VideoUrl;
        Title = lesson.Title;
        BindingContext = this;
    }
}