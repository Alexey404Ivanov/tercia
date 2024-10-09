namespace Tercia;

public partial class ChangeTempo
{
    public event Action<int> ValueSelected;
    private int _value;
    public ChangeTempo(int bpm)
    {
        InitializeComponent();
        ValueLabel.Text = bpm.ToString();
        _value = bpm;
        Slider.Value = bpm;
    }
    
    private void OnSliderValueChanged(object sender, EventArgs e)
    {
        if (sender is not Slider slider) return;
        _value = (int)slider.Value;
        ValueLabel.Text = _value.ToString();
    }
    
    private async void OnApplyClicked(object sender, EventArgs e)
    {
        ValueSelected?.Invoke(_value);
        await Navigation.PopAsync();
    }
}