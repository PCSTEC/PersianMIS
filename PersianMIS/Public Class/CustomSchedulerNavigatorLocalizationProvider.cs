using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telerik.WinControls.UI;

namespace PersianMIS.Public_Class
{
    public class CustomSchedulerNavigatorLocalizationProvider : SchedulerNavigatorLocalizationProvider
    {
        public override string GetLocalizedString(string id)
        {
            switch (id)
            {
                case SchedulerNavigatorStringId.DayViewButtonCaption:
                    {
                        return "روزانه";
                    }
                case SchedulerNavigatorStringId.WeekViewButtonCaption:
                    {
                        return "هفتگی";
                    }
                case SchedulerNavigatorStringId.MonthViewButtonCaption:
                    {
                        return "ماهیانه";
                    }
                case SchedulerNavigatorStringId.TimelineViewButtonCaption:
                    {
                        return "زمانی";
                    }
                case SchedulerNavigatorStringId.ShowWeekendCheckboxCaption:
                    {
                        return "هفتگی";
                    }
                case SchedulerNavigatorStringId.TodayButtonCaptionToday:
                    {
                        return "امروز";
                    }
                case SchedulerNavigatorStringId.TodayButtonCaptionThisWeek:
                    {
                        return "هفته جاری";
                    }
                case SchedulerNavigatorStringId.TodayButtonCaptionThisMonth:
                    {
                        return "ماه جاری";
                    }
            }
            return String.Empty;
        }
    }
}
