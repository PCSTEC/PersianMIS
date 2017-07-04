using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Globalization;

namespace PersianMIS.Public_Class
{
    class PersianCulture : CultureInfo
    {
        private readonly Calendar cal;
        private readonly Calendar[] optionals;
        public PersianCulture()
            : this("fa-IR", true)
        {
        }
        public PersianCulture(string cultureName, bool useUserOverride)
            : base(cultureName, useUserOverride)
        {
            System.Globalization.CultureInfo newCulture = System.Globalization.CultureInfo.CreateSpecificCulture("fa-IR");
            //Temporary Value for cal.
            cal = base.OptionalCalendars[0];
            //populating new list of optional calendars.
            var optionalCalendars = new List<Calendar>();
            optionalCalendars.AddRange(base.OptionalCalendars);
            optionalCalendars.Insert(0, new PersianCalendar());
            Type formatType = typeof(DateTimeFormatInfo);
            Type calendarType = typeof(Calendar);
            PropertyInfo idProperty = calendarType.GetProperty("ID", BindingFlags.Instance | BindingFlags.NonPublic);
            FieldInfo optionalCalendarfield = formatType.GetField("optionalCalendars",
            BindingFlags.Instance | BindingFlags.NonPublic);
            //populating new list of optional calendar ids
            var newOptionalCalendarIDs = new Int32[optionalCalendars.Count];
            for (int i = 0; i < newOptionalCalendarIDs.Length; i++)
                newOptionalCalendarIDs[i] = (Int32)idProperty.GetValue(optionalCalendars[i], null);
            optionalCalendarfield.SetValue(DateTimeFormat, newOptionalCalendarIDs);
            optionals = optionalCalendars.ToArray();
            cal = optionals[0];
            DateTimeFormat.Calendar = optionals[0];
            DateTimeFormat.MonthNames = new[] { "فروردین", "اردیبهشت", "خرداد", "تیر", "مرداد", "شهریور", "مهر", "آبان", "آذر", "دی", "بهمن", "اسفند", "" };
            DateTimeFormat.MonthGenitiveNames = new[] { "فروردین", "اردیبهشت", "خرداد", "تیر", "مرداد", "شهریور", "مهر", "آبان", "آذر", "دی", "بهمن", "اسفند", "" };
            DateTimeFormat.AbbreviatedMonthNames = new[] { "فروردین", "اردیبهشت", "خرداد", "تیر", "مرداد", "شهریور", "مهر", "آبان", "آذر", "دی", "بهمن", "اسفند", "" };
            DateTimeFormat.AbbreviatedMonthGenitiveNames = new[] { "فروردین", "اردیبهشت", "خرداد", "تیر", "مرداد", "شهریور", "مهر", "آبان", "آذر", "دی", "بهمن", "اسفند", "" };
            DateTimeFormat.AbbreviatedDayNames = new string[] { "ی", "د", "س", "چ", "پ", "ج", "ش" };
            DateTimeFormat.ShortestDayNames = new string[] { "ی", "د", "س", "چ", "پ", "ج", "ش" };
            DateTimeFormat.DayNames = new string[] { "یکشنبه", "دوشنبه", "ﺳﻪشنبه", "چهارشنبه", "پنجشنبه", "جمعه", "شنبه" };
            DateTimeFormat.AMDesignator = "ق.ظ";
            DateTimeFormat.PMDesignator = "ب.ظ";
            DateTimeFormat.ShortTimePattern = "HH:mm";



            /////////////////////////////////////////////////////////////////////////////////////

            DateTimeFormat.DateSeparator = "/";

            DateTimeFormat.FullDateTimePattern = "dd/MM/yyyy HH:mm";

            //////////////////////////////////////////////////////////////////////////////////
            DateTimeFormat.FirstDayOfWeek = DayOfWeek.Saturday;
            // DateTimeFormat.ShortDatePattern
            ///////////////////////////////////////////////////////////////////////////////////////////////
            DateTimeFormat.ShortDatePattern = "dd/MM/yyyy";

            DateTimeFormat.LongDatePattern = "dd/MM/yyyy HH:mm";
            DateTimeFormat.SetAllDateTimePatterns(new[] { "dd/MM/yyyy" }, 'd');
            DateTimeFormat.SetAllDateTimePatterns(new[] { "dddd, dd MMMM yyyy" }, 'D');

            DateTimeFormat.SetAllDateTimePatterns(new[] { "yyyy MMMM" }, 'y');
            DateTimeFormat.SetAllDateTimePatterns(new[] { "yyyy MMMM" }, 'Y');
            /////////////////////////////////////////////////////////////////////////////////////
            //System.Globalization.PersianCalendar mycal = new System.Globalization.PersianCalendar();

            //typeof(System.Globalization.DateTimeFormatInfo).GetField("calendar", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(DateTimeFormat, mycal);
            ////object obj = typeof(System.Globalization.DateTimeFormatInfo).GetField("m_cultureTableRecord", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).GetValue(info);
            ////obj.GetType().GetMethod("UseCurrentCalendar", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).Invoke(obj, new object[] { cal.GetType().GetProperty("ID", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).GetValue(cal, null) });
            //typeof(System.Globalization.CultureInfo).GetField("calendar", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(DateTimeFormat, mycal);
            //typeof(System.Globalization.CultureInfo).GetField("calendar", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(DateTimeFormat, mycal);
        }
        public override Calendar Calendar
        {
            get { return cal; }
        }
        public override Calendar[] OptionalCalendars
        {
            get { return optionals; }
        }


        public void SetMypersianCulture()
        {
            System.Globalization.CultureInfo newCulture = System.Globalization.CultureInfo.CreateSpecificCulture("fa-IR");
            PersianCulture MyPersianCulture = new PersianCulture();
            //myPersianCulture.DateTimeFormat.ShortDatePattern;
            System.Threading.Thread.CurrentThread.CurrentCulture = MyPersianCulture;
            System.Threading.Thread.CurrentThread.CurrentUICulture = MyPersianCulture;
            //
            //  System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern
        }



    }
}
