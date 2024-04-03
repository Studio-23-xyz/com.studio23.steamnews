using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Studio23.SteamNews.Data
{
    [Serializable]
    public class Appnews
    {
        [JsonProperty("appid")]
        public int Appid;

        [JsonProperty("newsitems")]
        public List<Newsitem> Newsitems;

        [JsonProperty("count")]
        public int Count;
    }

    [Serializable]
    public class Newsitem
    {
        [JsonProperty("gid")]
        public string Gid;

        [JsonProperty("title")]
        public string Title;

        [JsonProperty("url")]
        public string Url;

        [JsonProperty("is_external_url")]
        public bool IsExternalUrl;

        [JsonProperty("author")]
        public string Author;

        [JsonProperty("contents")]
        public string Contents;

        [JsonProperty("feedlabel")]
        public string Feedlabel;

        [JsonProperty("date")]
        public int Date;

        [JsonProperty("feedname")]
        public string Feedname;

        [JsonProperty("feed_type")]
        public int FeedType;

        [JsonProperty("appid")]
        public int Appid;
    }

    [Serializable]
    public class SteamNewsData
    {
        [JsonProperty("appnews")]
        public Appnews Appnews;
    }
}

