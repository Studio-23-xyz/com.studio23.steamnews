
using System.Collections.Generic;

namespace Studio23.SteamNews.Utilities
{
    public static class BBCodeConverter
    {

        private static Dictionary<string, string> bbCodeDictionary = new Dictionary<string, string>()
        {
            { "[img]", "![image](" }, 
            { "[/img]", ")" },
            { "[b]", "**" },
            { "[/b]", "**" },
            { "[i]", "*" },
            { "[/i]", "*" },
            { "[u]", "__" },
            { "[/u]", "__" },
            { "[color=red]", "<font color=\"red\">" }, 
            { "[/color]", "</font>" },
            { "[list]", "" },
            { "[olist]", "" },
            { "[*]", "* " },
            { "[/list]", "" },
            { "[/olist]", "" },
            { "[quote]", "> " },
            { "[/quote]", "" },
            { "[s]", "~~" },
            { "[/s]", "~~" },
            { "[url=", "[" },
            { "[/url]", "]" },
            { "[h1]", "# " },
            { "[/h1]", "" },
            { "[h2]", "## " },
            { "[/h2]", "" },
            { "[h3]", "### " },
            { "[/h3]", "" }

            
        };

        public static string BBToRichText(this string input)
        {
            foreach (var pair in bbCodeDictionary)
            {
                input = input.Replace(pair.Key, pair.Value);
            }
            return input;
        }
    }
}