namespace Tercia;

public class Metronome
{
    public int Bpm = 120;
    public Tuple<int, int> TimeSignature = new(4, 4);
    public bool IsActive;
}