namespace Tercia;

public class Metronome
{
    public int Bpm;
    public Tuple<int, int> TimeSignature;
    public bool IsActive;

    public Metronome()
    {
        Bpm = 120;
        TimeSignature = new Tuple<int, int>(4, 4);
    }
}