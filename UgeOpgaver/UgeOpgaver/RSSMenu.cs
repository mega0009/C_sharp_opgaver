using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace UgeOpgaver
{
    class RSSMenu : Menu
    {
        public static SyndicationFeed LoadFeed(string url)
        {
            Console.Write($"DEBUG: Loading feed {url}...");
            XmlReader reader = XmlReader.Create(url);
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            reader.Close();
            Console.WriteLine("DEBUG: ok.");
            return feed;
        }

//        public RSSMenu(string url) : base(LoadFeed(url).Title.Text)  // <- også en mulighed, men så loader vi to gange!
        public RSSMenu(string url) : base(url)
        {
            var feed = LoadFeed(url);
            Title = feed.Title.Text;

            foreach (SyndicationItem syndicationItem in feed.Items)
            {
                AddMenuItem(new RSSMenuItem(syndicationItem));
            }
        }

        // Vi kunne også vælge at loade ved hvert select... så får vi opdateringer med!
        /*
        public override void Select()
        {
            ClearMenuItems();
            SyndicationFeed feed = LoadFeed(_url); // vi har så gemt url'en i constructoren, i stedet for feeden
            foreach (SyndicationItem syndicationItem in feed.Items)
            {
                AddMenuItem(new RSSMenuItem(syndicationItem));
            }
            SelelectedIndex = Math.Min(SelelectedIndex, Count - 1); // hvis der er færre end før, sæt da SelectedIndex fornuftigt
            base.Select();
        }
        */
    }
}
