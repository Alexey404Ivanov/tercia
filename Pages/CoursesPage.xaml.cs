using Tercia.TerciaCore;

namespace Tercia;

public partial class CoursesPage
{
    
    public CoursesPage()
    {
        InitializeComponent();
        BindingContext = new CourseViewModel();   
        var listView = new ListView();
        
        // var courses = new List<Course>();
        // listView.ItemsSource = courses;
        
        // Courses.Add( new Course { Id=1, Name="Акустическая гитара" });
        
    }
    /*
     *<Button BackgroundColor="Transparent" 
            Text="Акустическая Гитара"
            TextColor="#36363D"
            FontFamily="NunitoSemiBold" 
            FontSize="11"  WidthRequest="85"
            HeightRequest="75"
            ContentLayout="Top,1" Clicked="OnMetronomePageClicked"/>
     * *
     */
    //Source="https://vk.com/video_ext.php?oid=-227293370&id=456239060&hash=b490453dc0cc24bd"
}