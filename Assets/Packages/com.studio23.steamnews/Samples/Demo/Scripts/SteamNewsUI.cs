using LogicUI.FancyTextRendering;
using Studio23.SteamNews.Core;
using Studio23.SteamNews.Data;
using Studio23.SteamNews.Utilities;
using TMPro;
using UnityEngine;

namespace Studio23.SteamNews.Demo
{
    public class SteamNewsUI : MonoBehaviour
    {
        [SerializeField]
        private SteamNewsManager _SteamNewsManager;

        public SteamNewsData SteamNews;


        public GameObject ContentPrefab;
        public GameObject ContentParent;

        public async void Start()
        {
            SteamNews = await _SteamNewsManager.GetNews();

            foreach (Newsitem newsitem in SteamNews.Appnews.Newsitems)
            {
                AddContentToParent(newsitem);
            }
        }

        private void AddContentToParent(Newsitem newsitem)
        {
           GameObject content=Instantiate(ContentPrefab, ContentParent.transform);

           MarkdownRenderer contentText=  content.GetComponent<MarkdownRenderer>();

           contentText.Source = $"# {newsitem.Title} \n{newsitem.Contents.BBToRichText()}";

        }
    }

}

