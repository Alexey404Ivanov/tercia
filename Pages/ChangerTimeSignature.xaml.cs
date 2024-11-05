namespace Tercia;

public partial class ChangerTimeSignature
{
    public event Action<Tuple<int, int>> ValueSelected;
    
    public ChangerTimeSignature()
    {
        InitializeComponent();
    }

    private async void OnValueSelected(object sender, EventArgs e)
    {
        if (sender is not Button button) return;
        var array = button.Text.Split('/');
        var timeSignature = Tuple.Create(int.Parse(array[0]), int.Parse(array[1]));
        ValueSelected?.Invoke(timeSignature);
        await Navigation.PopAsync();
    }
}