using System.Collections.Generic;
using System.Windows.Media;

namespace AubreysPeculiarities.Dictionary
{
    public class ImagePathDictionary
    {
        public Dictionary<string, string> IconPath { get; set; }
        public Dictionary<string, string> DamageTypeIcon { get; set; }
        public Dictionary<string, Color> ColorValue { get; set; }

        public ImagePathDictionary()
        {
            IconPath = new Dictionary<string, string>
            {
                { string.Empty, "" },

                //ItemTypes
                { "AT", @"C:\Users\denni\OneDrive\Datamatiker Studie\Code\MVVMToolkit\AubreysPeculiarities\Images\artisanToolsIcon.png" },
                { "GS", @"C:\Users\denni\OneDrive\Datamatiker Studie\Code\MVVMToolkit\AubreysPeculiarities\Images\rolling-dice-cup.png" },
                { "INS", @"C:\Users\denni\OneDrive\Datamatiker Studie\Code\MVVMToolkit\AubreysPeculiarities\Images\instrumentIcon.png" },
                { "LIA", @"C:\Users\denni\OneDrive\Datamatiker Studie\Code\MVVMToolkit\AubreysPeculiarities\Images\gloves.png" },
                { "MEA", @"C:\Users\denni\OneDrive\Datamatiker Studie\Code\MVVMToolkit\AubreysPeculiarities\Images\leather-armor.png" },
                { "HEA", @"C:\Users\denni\OneDrive\Datamatiker Studie\Code\MVVMToolkit\AubreysPeculiarities\Images\heavyArmorIcon.png" },
                { "SHE", @"C:\Users\denni\OneDrive\Datamatiker Studie\Code\MVVMToolkit\AubreysPeculiarities\Images\shieldIcon.png" },
                { "ADG", @"C:\Users\denni\OneDrive\Datamatiker Studie\Code\MVVMToolkit\AubreysPeculiarities\Images\backpackIcon.png" },
                { "AMM", @"C:\Users\denni\OneDrive\Datamatiker Studie\Code\MVVMToolkit\AubreysPeculiarities\Images\bowArrowIcon.png" },
                { "ARF", @"C:\Users\denni\OneDrive\Datamatiker Studie\Code\MVVMToolkit\AubreysPeculiarities\Images\spellbookIcon.png" },
                { "DRF", @"C:\Users\denni\OneDrive\Datamatiker Studie\Code\MVVMToolkit\AubreysPeculiarities\Images\staffIcon.png" },
                { "HOF", @"C:\Users\denni\OneDrive\Datamatiker Studie\Code\MVVMToolkit\AubreysPeculiarities\Images\prayerBeedsIcon.png" },
                { "PSN", @"C:\Users\denni\OneDrive\Datamatiker Studie\Code\MVVMToolkit\AubreysPeculiarities\Images\deathIcon.png" },
                { "MEW", @"C:\Users\denni\OneDrive\Datamatiker Studie\Code\MVVMToolkit\AubreysPeculiarities\Images\meleeIcon.png" },
                { "RAW", @"C:\Users\denni\OneDrive\Datamatiker Studie\Code\MVVMToolkit\AubreysPeculiarities\Images\bowArrowIcon.png" },
                { "GEM", @"C:\Users\denni\OneDrive\Datamatiker Studie\Code\MVVMToolkit\AubreysPeculiarities\Images\gemstoneIcon.png" },
                { "POT", @"C:\Users\denni\OneDrive\Datamatiker Studie\Code\MVVMToolkit\AubreysPeculiarities\Images\potionIcon.png" },
                { "Gold", @"C:\Users\denni\OneDrive\Datamatiker Studie\Code\MVVMToolkit\AubreysPeculiarities\Images\goldCoinIcon.png" },
                { "Silver", @"C:\Users\denni\OneDrive\Datamatiker Studie\Code\MVVMToolkit\AubreysPeculiarities\Images\silverCoinIcon.png" },
                { "Copper", @"C:\Users\denni\OneDrive\Datamatiker Studie\Code\MVVMToolkit\AubreysPeculiarities\Images\copperCoinIcon.png" },
                { "Scroll", @"C:\Users\denni\OneDrive\Datamatiker Studie\Code\MVVMToolkit\AubreysPeculiarities\Images\scrollIcon.png" },
                { "Lbs", @"C:\Users\denni\OneDrive\Datamatiker Studie\Code\MVVMToolkit\AubreysPeculiarities\Images\LbsIcon.png" },
                { "Book", @"C:\Users\denni\OneDrive\Datamatiker Studie\Code\MVVMToolkit\AubreysPeculiarities\Images\bookIcon.png" },
                { "RuleBook", @"C:\Users\denni\OneDrive\Datamatiker Studie\Code\MVVMToolkit\AubreysPeculiarities\Images\rule-book.png" },

                //ItemProperties
                { "CON", @"C:\Users\denni\OneDrive\Datamatiker Studie\Code\MVVMToolkit\AubreysPeculiarities\Images\consumableIcon.png" },
                { "BAG", @"C:\Users\denni\OneDrive\Datamatiker Studie\Code\MVVMToolkit\AubreysPeculiarities\Images\bagIcon.png" },
                { "2H", @"C:\Users\denni\OneDrive\Datamatiker Studie\Code\MVVMToolkit\AubreysPeculiarities\Images\sharp-axe.png" },
                { "A", @"C:\Users\denni\OneDrive\Datamatiker Studie\Code\MVVMToolkit\AubreysPeculiarities\Images\arrow-flights.png" },
                { "AF", @"C:\Users\denni\OneDrive\Datamatiker Studie\Code\MVVMToolkit\AubreysPeculiarities\Images\bagIcon.png" },
                { "BF", @"C:\Users\denni\OneDrive\Datamatiker Studie\Code\MVVMToolkit\AubreysPeculiarities\Images\bagIcon.png" },
                { "F", @"C:\Users\denni\OneDrive\Datamatiker Studie\Code\MVVMToolkit\AubreysPeculiarities\Images\assassin-pocket.png" },
                { "H", @"C:\Users\denni\OneDrive\Datamatiker Studie\Code\MVVMToolkit\AubreysPeculiarities\Images\weight-lifting-up.png" },
                { "L", @"C:\Users\denni\OneDrive\Datamatiker Studie\Code\MVVMToolkit\AubreysPeculiarities\Images\plain-dagger.png" },
                { "LD", @"C:\Users\denni\OneDrive\Datamatiker Studie\Code\MVVMToolkit\AubreysPeculiarities\Images\clockwise-rotation.png" },
                { "R", @"C:\Users\denni\OneDrive\Datamatiker Studie\Code\MVVMToolkit\AubreysPeculiarities\Images\pierced-body.png" },
                { "RLD", @"C:\Users\denni\OneDrive\Datamatiker Studie\Code\MVVMToolkit\AubreysPeculiarities\Images\clockwise-rotation.png" },
                { "S", @"C:\Users\denni\OneDrive\Datamatiker Studie\Code\MVVMToolkit\AubreysPeculiarities\Images\magic-axe.png" },
                { "T", @"C:\Users\denni\OneDrive\Datamatiker Studie\Code\MVVMToolkit\AubreysPeculiarities\Images\arrow-dunk.png" },
                { "V", @"C:\Users\denni\OneDrive\Datamatiker Studie\Code\MVVMToolkit\AubreysPeculiarities\Images\catch.png" },
                { "RA", @"C:\Users\denni\OneDrive\Datamatiker Studie\Code\MVVMToolkit\AubreysPeculiarities\Images\arrowed.png" },
                { "ME", @"C:\Users\denni\OneDrive\Datamatiker Studie\Code\MVVMToolkit\AubreysPeculiarities\Images\crossed-swords.png" },
                { "MAR", @"C:\Users\denni\OneDrive\Datamatiker Studie\Code\MVVMToolkit\AubreysPeculiarities\Images\flail.png" },
                { "SIM", @"C:\Users\denni\OneDrive\Datamatiker Studie\Code\MVVMToolkit\AubreysPeculiarities\Images\pitchfork.png" },
                { "FOC", @"C:\Users\denni\OneDrive\Datamatiker Studie\Code\MVVMToolkit\AubreysPeculiarities\Images\wizard-staff.png" },
                { "FUT", @"C:\Users\denni\OneDrive\Datamatiker Studie\Code\MVVMToolkit\AubreysPeculiarities\Images\bagIcon.png" },
                { "UTI", @"C:\Users\denni\OneDrive\Datamatiker Studie\Code\MVVMToolkit\AubreysPeculiarities\Images\rope-coil.png" },
                { "WAR", @"C:\Users\denni\OneDrive\Datamatiker Studie\Code\MVVMToolkit\AubreysPeculiarities\Images\shield.png" },
                { "TG", @"C:\Users\denni\OneDrive\Datamatiker Studie\Code\MVVMToolkit\AubreysPeculiarities\Images\cash.png" },

                //General Use
                { "Armor", @"C:\Users\denni\OneDrive\Datamatiker Studie\Code\MVVMToolkit\AubreysPeculiarities\Images\layered-armor.png" },
                { "Transparent", @"C:\Users\denni\OneDrive\Datamatiker Studie\Code\MVVMToolkit\AubreysPeculiarities\Images\transparent.png" }
            };

            //Damage Type Images
            DamageTypeIcon = new Dictionary<string, string>
            {
                { "MEW", @"C:\Users\denni\OneDrive\Datamatiker Studie\Code\MVVMToolkit\AubreysPeculiarities\Images\damageIcon.png" },
                { "RAW", @"C:\Users\denni\OneDrive\Datamatiker Studie\Code\MVVMToolkit\AubreysPeculiarities\Images\archery-target.png" }
            };

            //ColorValue = new Dictionary<string, Color>
            //{
            //    //Colors Ending in 991 havent been changed yet
            //    { "2H", (Color)ColorConverter.ConvertFromString("#FF653032") },
            //    { "A", (Color)ColorConverter.ConvertFromString("#FF283C20") },
            //    { "AF", (Color)ColorConverter.ConvertFromString("#FF283C20") },
            //    { "BF", (Color)ColorConverter.ConvertFromString("#FFDFD991") },
            //    { "F", (Color)ColorConverter.ConvertFromString("#FF262D38") },
            //    { "H", (Color)ColorConverter.ConvertFromString("#FF100524") },
            //    { "L", (Color)ColorConverter.ConvertFromString("#FF1B2405") },
            //    { "LD", (Color)ColorConverter.ConvertFromString("#FF382632") },
            //    { "R", (Color)ColorConverter.ConvertFromString("#FF060525") },
            //    { "RLD", (Color)ColorConverter.ConvertFromString("#FF4D908E") },
            //    { "S", (Color)ColorConverter.ConvertFromString("#FF382632") },
            //    { "T", (Color)ColorConverter.ConvertFromString("#FF052409") },
            //    { "V", (Color)ColorConverter.ConvertFromString("#FF514D18") },
            //    { "RA", (Color)ColorConverter.ConvertFromString("#FF051923") },
            //    { "ME", (Color)ColorConverter.ConvertFromString("#FF252422") },
            //    { "MAR", (Color)ColorConverter.ConvertFromString("#FFD25F3D") },
            //    { "SIM", (Color)ColorConverter.ConvertFromString("#FF5C462F") },
            //    { "FOC", (Color)ColorConverter.ConvertFromString("#FF442E5B") },
            //    { "FUT", (Color)ColorConverter.ConvertFromString("#FFDFD991") },
            //    { "CON", (Color)ColorConverter.ConvertFromString("#FF2E5B58") },
            //    { "WAR", (Color)ColorConverter.ConvertFromString("#FF2E3F5B") },
            //    { "TG", (Color)ColorConverter.ConvertFromString("#FF03071E") },
            //    { "BAG", (Color)ColorConverter.ConvertFromString("#FF051923") },
            //    { "UTI", (Color)ColorConverter.ConvertFromString("#FF0077B6") }
            //};
        }

    }
}
