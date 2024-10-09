using Plugin.Maui.Audio;

namespace Tercia;

public static class AudioWork
{
    private static readonly IAudioManager AudioManager;
    private static IAudioPlayer _tickPlayer;
    private static IAudioPlayer _accentTickPlayer;

    static AudioWork()
    {
        AudioManager = Plugin.Maui.Audio.AudioManager.Current;
        InitializeAudioPlayers();
    }
    
    private static async void InitializeAudioPlayers()
    {
        _accentTickPlayer = AudioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("AccentTick.mp3"));
        _tickPlayer = AudioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("Tick.mp3"));
    }

    public static void PlayTick()
    {
        _tickPlayer.Play();
    }

    public static void PlayAccentTick()
    {
        _accentTickPlayer.Play();
    }
    
    public static void Stop()
    {
        _accentTickPlayer.Stop();
        _tickPlayer.Stop();
    }
}