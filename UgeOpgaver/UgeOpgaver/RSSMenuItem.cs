using System;
using System.ServiceModel.Syndication;

namespace UgeOpgaver
{
    class RSSMenuItem : MenuItemBase
    {
        private SyndicationItem _feedItem;
        public RSSMenuItem(SyndicationItem feedItem) : base(feedItem.Title.Text)
        {
            _feedItem = feedItem;
        }

        public override void Select()
        {
            Console.Clear();
            Console.WriteLine($"[[[ {_feedItem.Title.Text} ]]]");
            Console.WriteLine(_feedItem.PublishDate.ToString("yyyy-MM-dd - HH:mm:ss"));
            Console.WriteLine();
            Console.WriteLine(_feedItem.Summary.Text);
            Console.ReadKey();
        }
    }
}