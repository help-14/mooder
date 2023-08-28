using Mooder.DataSources;
using Mooder.Models;
using ReactiveUI;
using Simple.MPD.Responses;
using System.Collections.Generic;

namespace Mooder.ViewModels;

public class PlaylistViewModel : ViewModelBase
{
    private List<string> musicSource;
    public List<string> MusicSources { get => musicSource; set => this.RaiseAndSetIfChanged(ref musicSource, value); }

    private List<Album> albums;
    public List<Album> Albums { get => albums; set => this.RaiseAndSetIfChanged(ref albums, value); }

    private List<SongInfo> playlist;
    public List<SongInfo> Playlist { get => playlist; set => this.RaiseAndSetIfChanged(ref playlist, value); }

    public async void LoadData()
    {
        //MusicSources = new List<string>() { "Local files", "MPD servers", "SubSonic Servers", "Online radios" };
        var a = new List<Album>();
        for (var i = 0; i < 20; i++)
        {
            a.Add(new Album()
            {
                Artist = "Artist",
                Description = "Description",
                Title = "Title",
                Picture = "D:/Code/mooder/Mooder/Assets/ecae82853b784726c7e2c4e2ba55a4fd.webp"
            });
        }
        Albums = a;

        //var mpd = new MusicPlayerDaemon();
        //await mpd.Init();
        //Playlist = await mpd.GetQueue();
    }

}
