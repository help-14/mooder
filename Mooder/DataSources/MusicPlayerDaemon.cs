using Simple.MPD.Networking;
using Simple.MPD;
using System.Threading.Tasks;
using Simple.MPD.Responses;
using System.Reactive.Linq;
using System.Linq;
using System.Collections.Generic;

namespace Mooder.DataSources
{
    public class MusicPlayerDaemon
    {
        private MPD client;

        public async Task Init(string url = null)
        {
            if(client == null)
            {
                client = new MPD(new TcpConnection(url ?? "moode.local"));
                await client.DoPingAsync();
            }
        }

        public async Task<List<SongInfo>> GetQueue()
        {
            var result = await client.GetQueue();
            return result.ToList();
        }
    }
}
