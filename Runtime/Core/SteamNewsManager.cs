using Cysharp.Threading.Tasks;
using Newtonsoft.Json;
using Studio23.SteamNews.Data;
using UnityEngine;
using UnityEngine.Networking;

namespace Studio23.SteamNews.Core
{
    public class SteamNewsManager : MonoBehaviour
    {
        [SerializeField]
        private SteamNewsAPIConfig _config;


        /// <summary>
        /// Get the Serialized News Data
        /// </summary>
        /// <returns></returns>
        public async UniTask<SteamNewsData> GetNews()
        {
            string rawData = await GetRawNewsString();
            return JsonConvert.DeserializeObject<SteamNewsData>(rawData);
        }

        /// <summary>
        /// Use this in case you want to get the raw string for whatever reason
        /// </summary>
        /// <returns></returns>
        public async UniTask<string> GetRawNewsString()
        {
            return (await UnityWebRequest.Get(GenerateUrl()).SendWebRequest()).downloadHandler.text;
        }

        private string GenerateUrl()
        {
            string requestUrl = $"https://api.steampowered.com/ISteamNews/GetNewsForApp/v2/?appid={_config.AppId}&count={_config.Count}";
            return requestUrl;
        }



    }
}


