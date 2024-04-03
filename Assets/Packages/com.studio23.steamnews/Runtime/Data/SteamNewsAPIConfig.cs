using System.Collections.Generic;
using System.Linq;
using UnityEngine;


namespace Studio23.SteamNews.Data
{
    [CreateAssetMenu(fileName = "SteamNewsConfig", menuName = "Studio-23/Steam News/Config", order = 1)]
    public class SteamNewsAPIConfig : ScriptableObject
    {

        public uint AppId;
        public uint Count=20;
        internal string _feeds=> string.Join(",", Feeds.Select(x => x.ToString()).ToArray());
        public List<string> Feeds;
        

    }
}