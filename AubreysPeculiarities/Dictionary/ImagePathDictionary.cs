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
                { "AT", @"\Images\artisanToolsIcon.png" },
                { "GS", @"\Images\rolling-dice-cup.png" },
                { "INS", @"\Images\instrumentIcon.png" },
                { "LIA", @"\Images\gloves.png" },
                { "MEA", @"\Images\leather-armor.png" },
                { "HEA", @"\Images\heavyArmorIcon.png" },
                { "SHE", @"\Images\shieldIcon.png" },
                { "ADG", @"\Images\backpackIcon.png" },
                { "AMM", @"\Images\bowArrowIcon.png" },
                { "ARF", @"\Images\spellbookIcon.png" },
                { "DRF", @"\Images\staffIcon.png" },
                { "HOF", @"\Images\prayerBeedsIcon.png" },
                { "PSN", @"\Images\deathIcon.png" },
                { "MEW", @"\Images\meleeIcon.png" },
                { "RAW", @"\Images\bowArrowIcon.png" },
                { "GEM", @"\Images\gemstoneIcon.png" },
                { "POT", @"\Images\potionIcon.png" },
                { "Gold", @"\Images\goldCoinIcon.png" },
                { "Silver", @"\Images\silverCoinIcon.png" },
                { "Copper", @"\Images\copperCoinIcon.png" },
                { "Scroll", @"\Images\scrollIcon.png" },
                { "Lbs", @"\Images\LbsIcon.png" },
                { "Book", @"\Images\bookIcon.png" },
                { "RuleBook", @"\Images\rule-book.png" },

                //ItemProperties
                { "CON", @"\Images\consumableIcon.png" },
                { "BAG", @"\Images\bagIcon.png" },
                { "2H", @"\Images\sharp-axe.png" },
                { "A", @"\Images\arrow-flights.png" },
                { "AF", @"\Images\bagIcon.png" },
                { "BF", @"\Images\bagIcon.png" },
                { "F", @"\Images\assassin-pocket.png" },
                { "H", @"\Images\weight-lifting-up.png" },
                { "L", @"\Images\plain-dagger.png" },
                { "LD", @"\Images\clockwise-rotation.png" },
                { "R", @"\Images\pierced-body.png" },
                { "RLD", @"\Images\clockwise-rotation.png" },
                { "S", @"\Images\magic-axe.png" },
                { "T", @"\Images\arrow-dunk.png" },
                { "V", @"\Images\catch.png" },
                { "RA", @"\Images\arrowed.png" },
                { "ME", @"\Images\crossed-swords.png" },
                { "MAR", @"\Images\flail.png" },
                { "SIM", @"\Images\pitchfork.png" },
                { "FOC", @"\Images\wizard-staff.png" },
                { "FUT", @"\Images\bagIcon.png" },
                { "UTI", @"\Images\rope-coil.png" },
                { "WAR", @"\Images\shield.png" },
                { "TG", @"\Images\cash.png" },

                //General Use
                { "Armor", @"\Images\layered-armor.png" },
                { "Transparent", @"\Images\transparent.png" },
                { "GoldCoin", @"\Images\goldCoinIcon.png" },
                { "SilverCoin", @"\Images\silverCoinIcon.png" },
                { "CopperCoin", @"\Images\copperCoinIcon.png" }

            };

            //Damage Type Images
            DamageTypeIcon = new Dictionary<string, string>
            {
                { "MEW", @"\Images\damageIcon.png" },
                { "RAW", @"\Images\archery-target.png" }
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
