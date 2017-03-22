using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace UgeOpgaver
{
    class DRNyhederMenu : Menu
    {
        readonly string[] _feeds = {
            "http://www.dr.dk/nyheder/service/feeds/allenyheder",
            "http://www.dr.dk/nyheder/service/feeds/indland",
            "http://www.dr.dk/nyheder/service/feeds/udland",
            "http://www.dr.dk/nyheder/service/feeds/penge",
            "http://www.dr.dk/nyheder/service/feeds/politik",
            "http://www.dr.dk/nyheder/service/feeds/kultur",
            "http://www.dr.dk/nyheder/service/feeds/levnu",
            "http://www.dr.dk/nyheder/service/feeds/viden",
            "http://www.dr.dk/nyheder/service/feeds/sporten",
            "http://www.dr.dk/nyheder/service/feeds/vejret",
            "http://www.dr.dk/Nyheder/Service/feeds/regionale/kbh/",
            "http://www.dr.dk/Nyheder/Service/feeds/regionale/bornholm/",
            "http://www.dr.dk/Nyheder/Service/feeds/regionale/syd/",
            "http://www.dr.dk/Nyheder/Service/feeds/regionale/fyn/",
            "http://www.dr.dk/Nyheder/Service/feeds/regionale/vest/",
            "http://www.dr.dk/Nyheder/Service/feeds/regionale/nord/",
            "http://www.dr.dk/Nyheder/Service/feeds/regionale/trekanten/",
            "http://www.dr.dk/Nyheder/Service/feeds/regionale/sjaelland/",
            "http://www.dr.dk/Nyheder/Service/feeds/regionale/oestjylland/"
        };

        public DRNyhederMenu() : base("DR-Nyheder")
        {
            foreach (string feed in _feeds)
            {
                try
                {
                    AddMenuItem(new RSSMenu(feed));
                }
                catch (XmlException) // første sted vi egentlig kan tage stilling til fejl
                {
                    // Ignorerér fejl og fortsæt...
                }
            }
        }
    }
}
