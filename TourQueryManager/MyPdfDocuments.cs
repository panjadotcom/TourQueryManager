using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;

namespace TourQueryManager
{
    /*this class will be used for pdf helping functions */
    class MyPdfDocuments
    {
        /* following are some contant strings to be used for printing in itenary as it is */
        private static readonly string itenaryAvailablityNote = "Subject to weather conditions and availability of Ferry Tickets and other Conditions, the itinerary may be shuffled." +
            " Please contact for Final Itinerary at the time of Check In.\n" +
            "Confirmation will be subject to availability at the time of Booking (No Rooms Blocked).\n" +
            "Rates subject to change if the Hotel or the Room category quoted is not available at the time of Booking";
        private static readonly string itenaryNotIncludedNote = "Cost for supplementary service, optional Tours, Up-gradation Charges, Guide, Additional Sightseeing entrance fees.\n" +
            "Cost for Airfare, Train fare, Insurance Premiums, Rafting Charges.\n" +
            "Cost for service provided on a personal request.\n" +
            "Cost for personal expenses such as laundry, bottled water, soft drinks, incidentals, porter charges, tips etc.\n" +
            "Activity charges, Scuba, Jet Ski, Snorkeling etc., until and unless mentioned in the inclusions.\n" +
            "Cost for any other service not mentioned under the “Cost Includes” head.\n" +
            "Difference in cost arising due to change in Taxes by the Government which will have to be collected directly ON ARRIVAL.\n" +
            "Difference in cost arising due to extra usage of vehicle, other than scheduled & mentioned in the itinerary.\n" +
            "Difference in cost arising due to mishaps, political unrest, natural calamities like - landslides, road blockage, etc." +
            " In such case extra will have to be paid on the spot by the guest directly.\n" +
            "Camera Fee ( Still or Movie)";
        private static readonly string itenaryImportantFacts = "Please carry original ID proof (Voter ID card/Pass-port/Driving License/etc.) for security purpose & hotel policy.\n" +
            "We need following for process your booking Guest Name & Contact Number. Naming List with gender & Age.\n" +
            "High season surcharge will be applicable for every booking on 16th Oct – 25th Oct during Durga Puja & Diwali, " +
            "20th Dec – 5th Jan during X-Mass & New Year & during Holi (as per date).\n" +
            "In high season, no refund will be applicable within 30 days of the tours start date. (Normal cancellation policy will" +
            " not applicable on those dates.)\n" +
            "For high season booking, 50% payment must be done in the time of confirmation & rest of the amount must be cleared" +
            " 30 days before of the tour start date.";
        private static readonly string itenaryPaymentPolicy = "Any confirmation is subject to an advance deposit of 50% of the package cost and has to be paid immediately," +
            " after that we can process the booking.\n" +
            "Balance Payment has to be made in advance and must be paid & as per time limit given at the time of confirmation.\n" +
            "Payments can be remitted through any of the following Banks and is subject to realization.";
        private static readonly string hotelVoucherRemark = "Please note that while your booking had been confirmed and is guaranteed," +
            " the rooming list with your name may not be adjusted in the hotel's reservation system until closer to arrival.";
        private static readonly string hotelVoucherTermAndCondition = "You must present a photo ID at the time of check in. " +
            "Hotel may ask for credit card or cash deposit for the extra services at the time of check in.\n" +
            "All extra charges should be collected directly from clients prior to departure such as parking, phone calls, room service, city tax, etc.\n" +
            "We don't accept any responsibility for additional expenses due to the changes or delays in air, road, rail, sea or indeed of any other causes, " +
            "all such expenses will have to be borne by passengers.\n" +
            "In case of wrong residency & nationality selected by user at the time of booking; " +
            "the supplement charges may be applicable and need to be paid to the hotel by guest on check in/ check out.\n" +
            "Any special request for bed type, early check in, late checkout, smoking rooms, etc. " +
            "are not guaranteed as subject to availability at the time of check in.\n" +
            "Early check out will attract full cancellation charges unless otherwise specified.";
        private static readonly string hotelVoucherPolicy = "Children share the bed with parents " +
            "1 Car park YES (without additional debit notes). " +
            "Key Collection 00:00 - 00:00. " +
            "Check-in hour 15:00 - 00:00. " +
            "Children get free accommodation, " +
            "meals payable on the spot 0 12. " +
            "Deposit on arrival. " +
            "Early departure. " +
            "Identification card at arrival. " +
            "No hen/stag or any other parties allowed. " +
            "Minimum check-in age 18.1 children between 6 to 11 are sharing beds with parents " +
            "in ALL room type Check in time is 14:00pm " +
            "Check out time is 12:00noon " +
            "No-Show or Early check out 100% of total stay will be charged. " +
            "1 children between 6 to 11 are sharing beds with parents in ALL room type.\n" +
            "City tax and Resort fee are to be paid directly at hotel if applicable.\n" +
            "Note: All Confirm bookings will be auto-cancel at 11:45 pm on last cancellation date.";
        private static readonly string contactDetailsExcursionHolidays = "Phone : 1204545485\n" +
            "Email : info @excursionholidays.com";
        private static readonly string agencyAddressExcursionHolidays = "EXCURSION HOLIDAYS PVT LTD(TPG)\n" +
            "#208, Express Green Plaza,\n" +
            "Sector - 1 Vaishali\n" +
            "City : Ghaziabad\n" +
            "Phone : 1204545485\n";
        private static readonly string agencyAddressExcursionForItinerary = "EXCURSION HOLIDAYS (P) LTD\n" +
            "#208 Express Green Plaza, Sec-01 Vaishali Ghaziabad, Delhi-NCR 201010\n" +
            "Office no: +91 (0120) 4545485 Email Id: info @excursionholidays.com";
        private static readonly string flightVoucherNote = 
            "Carriage and other services provided by the carrier are subject to conditions of carriage which hereby incorporated by reference.\n" +
            "These conditions may be obtained from the issuing carrier. If the passenger's journey involves an ultimate destination or stop in a\n" +
            "country other than country of departure the Warsaw convention may be applicable and the convention governs and in most cases\n" +
            "limits the liability of carriers for death or personal injury and in respect of loss of or damage to baggage.";
        private static readonly string flightVoucherInsuranceNote = "Don't Forget to purchase travel insurance for your Visit. " +
            "Please Contact your travel agent to purchase travel insurance";

        /// <summary>
        /// Defines the styles used in the document.
        /// </summary>
        public static void DefineStyles(Document document)
        {
            document.Info.Author = "PANJADOTCOM";

            // Set top space position to 0 as image should be visible in this
            document.DefaultPageSetup.TopMargin = Unit.FromCentimeter(0.1);
            document.DefaultPageSetup.BottomMargin = Unit.FromCentimeter(1);
            document.DefaultPageSetup.LeftMargin = Unit.FromCentimeter(1);
            document.DefaultPageSetup.RightMargin = Unit.FromCentimeter(1);

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
            style.Font.Color = Colors.DarkSlateBlue;
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

            style = document.Styles[StyleNames.Header];
            style.ParagraphFormat.AddTabStop("16cm", TabAlignment.Right);

            style = document.Styles[StyleNames.Footer];
            style.ParagraphFormat.AddTabStop("8cm", TabAlignment.Center);

            // Create a new style called TextBox based on style Normal
            style = document.Styles.AddStyle("TextBox", "Normal");
            style.Font.Size = 10;
            style.ParagraphFormat.Alignment = ParagraphAlignment.Left;
            style.ParagraphFormat.Borders.Width = 0.5;
            style.ParagraphFormat.Borders.Distance = "3pt";
            //TODO: Colors
            style.ParagraphFormat.Borders.Color = Colors.SkyBlue;

            // Create a new style called TOC based on style Normal
            style = document.Styles.AddStyle("TOC", "Normal");
            style.ParagraphFormat.AddTabStop("16cm", TabAlignment.Right, TabLeader.Dots);
            style.ParagraphFormat.Font.Color = Colors.Blue;

            // Create a new style called MyBulletList based on style Normal
            style = document.Styles.AddStyle("MyBulletList", "Normal");
            style.ParagraphFormat.LeftIndent = "1cm";
            style.ParagraphFormat.FirstLineIndent = "-0.5cm";
            style.Font.Size = 12;
        }

        /// <summary>
        /// this will write the note in the document
        /// </summary>
        public static void WriteNoteParagraph(Section section)
        {
            WriteHdrContentListingBullets(section, "Note:", itenaryAvailablityNote);
        }

        /// <summary>
        /// this will write the note in the document
        /// </summary>
        public static void WriteNotIncludedParagraph(Section section)
        {
            WriteHdrContentListingBullets(section, "The Tour Cost does not include:", itenaryNotIncludedNote);
        }

        /// <summary>
        /// this will write the note in the document
        /// </summary>
        public static void WriteImportantFactsParagraph(Section section)
        {
            WriteHdrContentListingBullets(section, "Important Facts for Traveler’s:", itenaryImportantFacts);
        }

        /// <summary>
        /// this will write the note in the document
        /// </summary>
        public static void WritePaymentPolicyParagraph(Section section)
        {
            WriteHdrContentListingNumbers(section, "Payment Policy:", itenaryPaymentPolicy);
        }

        /// <summary>
        /// this will write the header with heading3 style and content after that
        /// </summary>
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
        public static void WriteHdrContentListingBullets(Cell section, string hdr, string content)
        {
            Paragraph paragraph = section.AddParagraph();
            paragraph.AddFormattedText(hdr, "Heading2");
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

        /// <summary>
        /// This will write content in listing format in table cell
        /// </summary>
        /// <param name="section">this is cell field</param>
        /// <param name="hdr">header portion of the content</param>
        /// <param name="content">actual content</param>
        public static void WriteHdrContentListingNumbers(Cell section, string hdr, string content)
        {
            Paragraph paragraph = section.AddParagraph();
            paragraph.AddFormattedText(hdr, "Heading2");
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

        /// <summary>
        /// this will write the header with heading3 style and content after that
        /// </summary>
        public static void WriteHdrContentParagraph(Cell cell, string hdr, string content)
        {
            Paragraph paragraph = cell.AddParagraph();
            paragraph.AddFormattedText(hdr + "\n", "Heading2");
            paragraph.Format.Font.Size = 12;
            paragraph.AddText(content);
            
        }
        
        /// <summary>
        /// this will write agency address detail in table cell.
        /// </summary>
        /// <param name="cell">content will be written in this cell.</param>
        public static void WriteAgencyAddressDetails(Cell cell)
        {
            Paragraph paragraph;
            //paragraph.AddFormattedText(agencyAddressExcursionHolidays, "Heading3");
            string[] lines = agencyAddressExcursionHolidays.Split('\n');
            for (int index = 0; index < lines.Length; index++)
            {
                if (string.Equals(lines[index], ""))
                {
                    continue;
                }
                paragraph = cell.AddParagraph();
                if (index > 0)
                {
                    paragraph.AddFormattedText(lines[index]);
                    paragraph.Format.Font.Size = 10;
                }
                else
                {
                    paragraph.AddFormattedText(lines[index]);
                    paragraph.Format.Font.Bold = true;
                }                
            }
        }

        /// <summary>
        /// This will print Agency address in cell with specified font size
        /// </summary>
        /// <param name="cell">Cell Id</param>
        /// <param name="hdrFontSize">Font size of the header line</param>
        /// <param name="fontSize">Font size of the normal text</param>
        public static void WriteAgencyAddressDetails(Cell cell, int hdrFontSize, int fontSize)
        {
            Paragraph paragraph;
            //paragraph.AddFormattedText(agencyAddressExcursionHolidays, "Heading3");
            string[] lines = agencyAddressExcursionForItinerary.Split('\n');
            for (int index = 0; index < lines.Length; index++)
            {
                if (string.Equals(lines[index], ""))
                {
                    continue;
                }
                paragraph = cell.AddParagraph();
                if (index > 0)
                {
                    paragraph.AddFormattedText(lines[index]);
                    paragraph.Format.Font.Size = fontSize;
                }
                else
                {
                    paragraph.AddFormattedText(lines[index]);
                    paragraph.Format.Font.Bold = true;
                    paragraph.Format.Font.Color = Colors.DarkBlue;
                    paragraph.Format.Font.Size = hdrFontSize;
                }
            }
        }

        /// <summary>
        /// this will write hotel vouchers static details in provided section
        /// </summary>
        /// <param name="section">content will be writen in this section</param>
        public static void WriteHotelVoucherStaticDetails(Section section)
        {
            Table table = null;
            Column column = null;
            int columnCount = 0;
            double columnWidth = 0;
            Row row = null;
            int rowsCount = 0;
            Cell cell = null;

            table = section.AddTable();
            table.Format.SpaceBefore = 5;
            table.Borders.Visible = true;
            table.Borders.Width = 0.75;
            table.Borders.Color = Colors.SkyBlue;
            columnCount = 1;
            columnWidth = (21.0 - 2.0) / columnCount;
            column = table.AddColumn(Unit.FromCentimeter(columnWidth));
            column.Format.Alignment = ParagraphAlignment.Left;
            row = table.AddRow();
            rowsCount++;
            cell = row.Cells[0];
            WriteHdrContentParagraph(cell, "Remarks", hotelVoucherRemark);
            row = table.AddRow();
            rowsCount++;
            cell = row.Cells[0];
            WriteHdrContentListingBullets(cell, "Booking Terms & Condition", hotelVoucherTermAndCondition);
            row = table.AddRow();
            rowsCount++;
            cell = row.Cells[0];
            WriteHdrContentListingBullets(cell, "Hotel Policies", hotelVoucherPolicy);
            row = table.AddRow();
            rowsCount++;
            cell = row.Cells[0];
            WriteHdrContentParagraph(cell, "Contact Details:", contactDetailsExcursionHolidays);
            table.SetEdge(0, 0, columnCount, rowsCount, Edge.Box, MigraDoc.DocumentObjectModel.BorderStyle.Single, 1.5, Colors.SkyBlue);
        }

        /// <summary>
        /// Flight voucher will be written in the cell format
        /// </summary>
        /// <param name="cell">content will be writen in this cell</param>
        public static void WriteFlightVoucherNote(Cell cell)
        {
            Paragraph paragraph = cell.AddParagraph();
            paragraph.AddText(flightVoucherNote + "\n\n");
            paragraph.Format.Alignment = ParagraphAlignment.Left;
            paragraph = cell.AddParagraph();
            paragraph.Format.Font.Color = Colors.Red;
            paragraph.AddText(flightVoucherInsuranceNote);
        }

        /// <summary>
        /// This will write static details in the tabular form
        /// </summary>
        /// <param name="section">content will be written in this section</param>
        public static void WriteItineraryLastStaticDetails(Section section, string tourIncContent)
        {
            Table table = null;
            Column column = null;
            int columnCount = 0;
            double columnWidth = 0;
            Row row = null;
            int rowsCount = 0;
            Cell cell = null;

            table = section.AddTable();
            table.Format.SpaceBefore = 5;
            table.Borders.Visible = false;
            table.Borders.Width = 0.75;
            table.Borders.Color = Colors.Transparent;
            columnCount = 1;
            columnWidth = (21.0 - 2.0) / columnCount;
            column = table.AddColumn(Unit.FromCentimeter(columnWidth));
            column.Format.Alignment = ParagraphAlignment.Left;
            row = table.AddRow();
            rowsCount++;
            cell = row.Cells[0];
            WriteHdrContentListingBullets(cell, "Note:", itenaryAvailablityNote);
            row = table.AddRow();
            rowsCount++;
            cell = row.Cells[0];
            WriteHdrContentListingBullets(cell, "The tour cost includes:", tourIncContent);
            row = table.AddRow();
            rowsCount++;
            cell = row.Cells[0];
            WriteHdrContentListingBullets(cell, "The Tour Cost does not include:", itenaryNotIncludedNote);
            row = table.AddRow();
            rowsCount++;
            cell = row.Cells[0];
            WriteHdrContentListingBullets(cell, "Important Facts for Traveler’s:", itenaryImportantFacts);
            row = table.AddRow();
            rowsCount++;
            cell = row.Cells[0];
            WriteHdrContentListingNumbers(cell, "Payment Policy:", itenaryPaymentPolicy);
            table.SetEdge(0, 0, columnCount, rowsCount, Edge.Box, MigraDoc.DocumentObjectModel.BorderStyle.Single, 1.5, Colors.Transparent);
        }
    }
}
