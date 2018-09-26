using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MigraDoc.DocumentObjectModel;
using MigraDoc.Rendering;

namespace TourQueryManager
{
    /*this class will be used for pdf helping functions */
    class MyPdfDocuments
    {
        /* following are some contant strings to be used for printing in itenary as it is */
        private static readonly string itenaryAvailablityNote = " Subject to weather conditions and availability of Ferry Tickets and other Conditions, the itinerary may be shuffled." +
            " Please contact for Final Itinerary at the time of Check In." +
            "\n Confirmation will be subject to availability at the time of Booking (No Rooms Blocked)" +
            "\n Rates subject to change if the Hotel or the Room category quoted is not available at the time of Booking";
        private static readonly string itenaryNotIncludedNote = " Cost for supplementary service, optional Tours, Up-gradation Charges, Guide, Additional Sightseeing entrance fees." +
            "\n Cost for Airfare, Train fare, Insurance Premiums, Rafting Charges." +
            "\n Cost for service provided on a personal request." +
            "\n Cost for personal expenses such as laundry, bottled water, soft drinks, incidentals, porter charges, tips etc." +
            "\n Activity charges, Scuba, Jet Ski, Snorkeling etc., until and unless mentioned in the inclusions" +
            "\n Cost for any other service not mentioned under the “Cost Includes” head." +
            "\n Difference in cost arising due to change in Taxes by the Government which will have to be collected directly ON ARRIVAL." +
            "\n Difference in cost arising due to extra usage of vehicle, other than scheduled & mentioned in the itinerary." +
            "\n Difference in cost arising due to mishaps, political unrest, natural calamities like - landslides, road blockage, etc." +
            " In such case extra will have to be paid on the spot by the guest directly." +
            "\n Camera Fee ( Still or Movie)";
        private static readonly string itenaryImportantFacts = " Please carry original ID proof (Voter ID card/Pass-port/Driving License/etc.) for security purpose & hotel policy." +
            "\n We need following for process your booking Guest Name & Contact Number. Naming List with gender & Age." +
            "\n High season surcharge will be applicable for every booking on 16th Oct – 25th Oct during Durga Puja & Diwali, " +
            "20th Dec – 5th Jan during X-Mass & New Year & during Holi (as per date)." +
            "\n In high season, no refund will be applicable within 30 days of the tours start date. (Normal cancellation policy will" +
            " not applicable on those dates.)" +
            "\n For high season booking, 50% payment must be done in the time of confirmation & rest of the amount must be cleared" +
            " 30 days before of the tour start date.";
        private static readonly string itenaryPaymentPolicy = " Any confirmation is subject to an advance deposit of 50% of the package cost and has to be paid immediately," +
            " after that we can process the booking." +
            "\n Balance Payment has to be made in advance and must be paid & as per time limit given at the time of confirmation." +
            "\n Payments can be remitted through any of the following Banks and is subject to realization.";

        /// <summary>
        /// Defines the styles used in the document.
        /// </summary>
        public static void DefineStyles(Document document)
        {
            // Set top space position to 0 as image should be visible in this
            document.DefaultPageSetup.TopMargin = Unit.FromCentimeter(0.1);
            document.DefaultPageSetup.BottomMargin = Unit.FromCentimeter(1);

            // Get the predefined style Normal.
            Style style = document.Styles["Normal"];
            // Because all styles are derived from Normal, the next line changes the 
            // font of the whole document. Or, more exactly, it changes the font of
            // all styles and paragraphs that do not redefine the font.
            style.Font.Name = "Times New Roman";
            style.ParagraphFormat.SpaceAfter = 2;

            // Heading1 to Heading9 are predefined styles with an outline level. An outline level
            // other than OutlineLevel.BodyText automatically creates the outline (or bookmarks) 
            // in PDF.

            style = document.Styles["Heading1"];
            style.Font.Name = "Tahoma";
            style.Font.Size = 14;
            style.Font.Bold = true;
            style.Font.Color = Colors.DarkBlue;
            style.ParagraphFormat.PageBreakBefore = false;
            style.ParagraphFormat.SpaceAfter = 6;
            style.ParagraphFormat.Alignment = ParagraphAlignment.Center;

            style = document.Styles["Heading2"];
            style.Font.Size = 12;
            style.Font.Bold = true;
            style.Font.Color = Colors.Black;
            style.ParagraphFormat.PageBreakBefore = false;
            style.ParagraphFormat.SpaceBefore = 6;
            style.ParagraphFormat.SpaceAfter = 6;
            style.ParagraphFormat.Alignment = ParagraphAlignment.Left;

            style = document.Styles["Heading3"];
            style.Font.Size = 10;
            style.Font.Bold = true;
            style.Font.Italic = true;
            style.Font.Color = Colors.Black;
            style.ParagraphFormat.SpaceBefore = 6;
            style.ParagraphFormat.SpaceAfter = 3;
            style.ParagraphFormat.Alignment = ParagraphAlignment.Left;
            style.ParagraphFormat.Shading.Color = Colors.LightBlue;

            style = document.Styles[StyleNames.Header];
            style.ParagraphFormat.AddTabStop("16cm", TabAlignment.Right);

            style = document.Styles[StyleNames.Footer];
            style.ParagraphFormat.AddTabStop("8cm", TabAlignment.Center);

            // Create a new style called TextBox based on style Normal
            style = document.Styles.AddStyle("TextBox", "Normal");
            style.ParagraphFormat.Alignment = ParagraphAlignment.Justify;
            style.ParagraphFormat.Borders.Width = 2.5;
            style.ParagraphFormat.Borders.Distance = "3pt";
            //TODO: Colors
            style.ParagraphFormat.Shading.Color = Colors.SkyBlue;

            // Create a new style called TOC based on style Normal
            style = document.Styles.AddStyle("TOC", "Normal");
            style.ParagraphFormat.AddTabStop("16cm", TabAlignment.Right, TabLeader.Dots);
            style.ParagraphFormat.Font.Color = Colors.Blue;

            // Create a new style called MyBulletList based on style Normal
            style = document.Styles.AddStyle("MyBulletList", "Normal");
            style.ParagraphFormat.LeftIndent = "0.5cm";
        }

        /// <WriteNote>
        /// this will write the note in the document
        /// </WriteNote>
        public static void WriteNoteParagraph(Section section)
        {
            WriteHdrContentListingBullets(section, "Note:", itenaryAvailablityNote);
        }

        /// <WriteNotncluded>
        /// this will write the note in the document
        /// </WriteNotncluded>
        public static void WriteNotIncludedParagraph(Section section)
        {
            WriteHdrContentListingBullets(section, "The Tour Cost does not include:", itenaryNotIncludedNote);
        }

        /// <WriteImportantFacts>
        /// this will write the note in the document
        /// </WriteImportantFacts>
        public static void WriteImportantFactsParagraph(Section section)
        {
            WriteHdrContentListingBullets(section, "Important Facts for Traveler’s:", itenaryImportantFacts);
        }

        /// <WritePaymentPolicy>
        /// this will write the note in the document
        /// </WritePaymentPolicy>
        public static void WritePaymentPolicyParagraph(Section section)
        {
            WriteHdrContentListingNumbers(section, "Payment Policy:", itenaryPaymentPolicy);
        }

        /// <WriteHdrContentParagraph>
        /// this will write the header with heading3 style and content after that
        /// </WriteHdrContentParagraph>
        public static void WriteHdrContentParagraph(Section section, string hdr, string content)
        {
            Paragraph paragraph = section.AddParagraph(hdr, "Heading3");
            //paragraph.Format.Shading.Color = Colors.LightBlue;
            paragraph = section.AddParagraph(content);
        }

        /// <summary>
        /// This will print content in the listing form.
        /// </summary>
        /// 
        public static void WriteHdrContentListingBullets(Section section, string hdr, string content)
        {
            Paragraph paragraph = section.AddParagraph(hdr, "Heading3");
            string[] lines = content.Split('\n');
            for (int index = 0; index < lines.Length; index++)
            {
                if (string.Equals(lines[index], ""))
                {
                    continue;
                }
                ListInfo listInfo = new ListInfo();
                listInfo.ContinuePreviousList = index > 0;
                listInfo.ListType = ListType.BulletList1;
                paragraph = section.AddParagraph(lines[index]);
                paragraph.Style = "MyBulletList";
                paragraph.Format.ListInfo = listInfo;
            }
        }

        /// <summary>
        /// This will print content in the listing form.
        /// </summary>
        /// 
        public static void WriteHdrContentListingNumbers(Section section, string hdr, string content)
        {
            Paragraph paragraph = section.AddParagraph(hdr, "Heading3");
            string[] lines = content.Split('\n');
            for (int index = 0; index < lines.Length; index++)
            {
                if (string.Equals(lines[index], ""))
                {
                    continue;
                }
                ListInfo listInfo = new ListInfo();
                listInfo.ContinuePreviousList = index > 0;
                listInfo.ListType = ListType.NumberList1;
                paragraph = section.AddParagraph(lines[index]);
                paragraph.Style = "MyBulletList";
                paragraph.Format.ListInfo = listInfo;
            }
        }
    }
}
