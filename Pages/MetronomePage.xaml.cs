namespace Tercia;

public partial class MetronomePage
{
    private readonly Metronome _metronome;
    
    public MetronomePage()
    {
        _metronome = new Metronome();
        InitializeComponent();
    }

    private async void OnChangeTempoButtonClicked(object sender, EventArgs e)
    {
        StopMetronome();
        var changeTempoPage = new ChangeTempo(_metronome.Bpm);
        changeTempoPage.ValueSelected += value =>
        {
            _metronome.Bpm = value;
            BpmLabel.Text = _metronome.Bpm.ToString();
        };
        await Navigation.PushAsync(changeTempoPage);
    }
    
    private async void OnChangeTimeSignatureButtonClicked(object sender, EventArgs e)
    {
        StopMetronome();
        var changerTimeSignature = new ChangerTimeSignature();
        changerTimeSignature.ValueSelected += tuple =>
        {
            _metronome.TimeSignature = tuple;
            TimeSignatureLabel.Text = $"{tuple.Item1.ToString()} / {tuple.Item2.ToString()}";
        };
        await Navigation.PushAsync(changerTimeSignature);
    }

    private void OnStartOrStopButtonClicked(object sender, EventArgs e)
    {
        if (!_metronome.IsActive)
            StartMetronome();
        else
            StopMetronome(); 
    }

    private void StartMetronome()
    {
        _metronome.IsActive = true;
        StartOrStop.Text = "Стоп";  
        StartСounting();
    }

    private void StopMetronome()
    {
        _metronome.IsActive = false;
        BeatNumber.Text = "0";
        StartOrStop.Text = "Старт";  
    }
    
    private void StartСounting()
    {
        BeatNumber.Text = "1";
        var currentNumber = 1;
        AudioWork.PlayAccentTick();
        Device.StartTimer(TimeSpan.FromSeconds(60.0 * 4 / (_metronome.Bpm * _metronome.TimeSignature.Item2)), () =>
        {
            if (!_metronome.IsActive)
                return false;
            if (currentNumber < _metronome.TimeSignature.Item1)
            {
                AudioWork.Stop();
                BeatNumber.Text = (++currentNumber).ToString();
                AudioWork.PlayTick();
            }
            else
            {
                currentNumber = 1;
                AudioWork.Stop();
                BeatNumber.Text = "1";
                AudioWork.PlayAccentTick();
            }

            return _metronome.IsActive;
        });
    }
}
