using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Tercia.TerciaCore;

public class CourseViewModel : INotifyPropertyChanged
{
    public ObservableCollection<Course> Courses { get; private set; }
    public event PropertyChangedEventHandler? PropertyChanged;
    readonly IList<Course> source;
    public CourseViewModel()
    {
        source = new List<Course>();
        source.Add(new Course { Id=1, Name="Акустическая гитара" });
        Courses = new ObservableCollection<Course>(source);
        // SelectedMonkey = Monkeys.Skip(3).FirstOrDefault();
        // OnPropertyChanged("SelectedMonkey");
    }
    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    protected bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value)) return false;
        field = value;
        OnPropertyChanged(propertyName);
        return true;
    }
}