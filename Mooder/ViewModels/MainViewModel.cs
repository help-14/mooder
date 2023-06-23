using Mooder.DataSources;
using ReactiveUI;
using Simple.MPD.Responses;
using System;
using System.Collections.Generic;

namespace Mooder.ViewModels;

public class PlaylistViewModel : ViewModelBase
{
    private List<SongInfo> playlist; 
    public List<SongInfo> Playlist { get => playlist; set=> this.RaiseAndSetIfChanged(ref playlist, value); }

    public async void LoadData()
    {
        var mpd = new MusicPlayerDaemon();
        await mpd.Init();
        Playlist = await mpd.GetQueue();
    }

}
