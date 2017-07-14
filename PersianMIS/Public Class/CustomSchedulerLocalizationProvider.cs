﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telerik.WinControls.UI.Localization;
namespace PersianMIS.Public_Class
{
    public class CustomSchedulerLocalizationProvider : RadSchedulerLocalizationProvider
    {
        public override string GetLocalizedString(string id)
        {
            switch (id)
            {
                case RadSchedulerStringId.NextAppointment: return "آیتم بعدی";
                case RadSchedulerStringId.PreviousAppointment: return "آیتم قبلی";
                case RadSchedulerStringId.AppointmentDialogTitle: return "ویرایش";
                case RadSchedulerStringId.AppointmentDialogSubject: return "عنوان:";
                case RadSchedulerStringId.AppointmentDialogLocation: return "موقعیت:";
                case RadSchedulerStringId.AppointmentDialogBackground: return "زمینه:";
                case RadSchedulerStringId.AppointmentDialogDescription: return "توضیحات:";
                case RadSchedulerStringId.AppointmentDialogStartTime: return "زمان شروع:";
                case RadSchedulerStringId.AppointmentDialogEndTime: return "زمان پایان:";
                case RadSchedulerStringId.AppointmentDialogAllDay: return "تمام رخداد های روز";
                case RadSchedulerStringId.AppointmentDialogResource: return "منبع:";
                case RadSchedulerStringId.AppointmentDialogStatus: return "نمایش زمان از :";
                case RadSchedulerStringId.AppointmentDialogOK: return "تایید";
                case RadSchedulerStringId.AppointmentDialogCancel: return "انصراف";
                case RadSchedulerStringId.AppointmentDialogDelete: return "حذف";
                case RadSchedulerStringId.AppointmentDialogRecurrence: return "عودت";
                case RadSchedulerStringId.OpenRecurringDialogTitle: return "باز کردن آیتم تکراری";
                case RadSchedulerStringId.DeleteRecurrenceDialogOK: return "تایید";
                case RadSchedulerStringId.OpenRecurringDialogOK: return "تایید";
                case RadSchedulerStringId.DeleteRecurrenceDialogCancel: return "انصراف";
                case RadSchedulerStringId.OpenRecurringDialogCancel: return "انصراف";
                case RadSchedulerStringId.OpenRecurringDialogLabel: return "\"{0}\" تکرار می شود\nappointment.آیا میخواهید باز شود\nonly?";
                case RadSchedulerStringId.OpenRecurringDialogRadioOccurrence: return "باز کردن رخداد";
                case RadSchedulerStringId.OpenRecurringDialogRadioSeries: return "باز کردن سری";
                case RadSchedulerStringId.DeleteRecurrenceDialogTitle: return "تایید حذف";
                case RadSchedulerStringId.DeleteRecurrenceDialogRadioOccurrence: return "حذف رخداد";
                case RadSchedulerStringId.DeleteRecurrenceDialogRadioSeries: return "حذف سری";
                case RadSchedulerStringId.DeleteRecurrenceDialogLabel: return "آیا میخواهید همه رخداد ها را حذف کنید \"{0}\", یا فقط همین رخداد را؟?";
                case RadSchedulerStringId.RecurrenceDragDropCreateExceptionDialogText: return "You changed the date of a single occurrence of a recurring appointment. To change all the dates, open the series.\nDo you want to change just this one?";
                case RadSchedulerStringId.RecurrenceDragDropValidationSameDateText: return "Two occurrences of the same series cannot occur on the same day.";
                case RadSchedulerStringId.RecurrenceDragDropValidationSkipOccurrenceText: return "Cannot reschedule an occurrence of a recurring appointment if it skips over a later occurrence of the same appointment.";
                case RadSchedulerStringId.RecurrenceDialogMessageBoxText: return "Start date should be before EndBy date.";
                case RadSchedulerStringId.RecurrenceDialogMessageBoxWrongRecurrenceRuleText: return "The recurrence pattern is not valid.";
                case RadSchedulerStringId.RecurrenceDialogMessageBoxTitle: return "Validation error";
                case RadSchedulerStringId.RecurrenceDialogTitle: return "Edit Recurrence";
                case RadSchedulerStringId.RecurrenceDialogAppointmentTimeGroup: return "Appointment time";
                case RadSchedulerStringId.RecurrenceDialogDuration: return "Duration:";
                case RadSchedulerStringId.RecurrenceDialogAppointmentEnd: return "End:";
                case RadSchedulerStringId.RecurrenceDialogAppointmentStart: return "Start:";
                case RadSchedulerStringId.RecurrenceDialogRecurrenceGroup: return "Recurrence pattern";
                case RadSchedulerStringId.RecurrenceDialogRangeGroup: return "Range of recurrence";
                case RadSchedulerStringId.RecurrenceDialogOccurrences: return "occurrences";
                case RadSchedulerStringId.RecurrenceDialogRecurrenceStart: return "Start:";
                case RadSchedulerStringId.RecurrenceDialogYearly: return "Yearly";
                case RadSchedulerStringId.RecurrenceDialogHourly: return "Hourly";
                case RadSchedulerStringId.RecurrenceDialogMonthly: return "Monthly";
                case RadSchedulerStringId.RecurrenceDialogWeekly: return "Weekly";
                case RadSchedulerStringId.RecurrenceDialogDaily: return "Daily";
                case RadSchedulerStringId.RecurrenceDialogEndBy: return "End by:";
                case RadSchedulerStringId.RecurrenceDialogEndAfter: return "End after:";
                case RadSchedulerStringId.RecurrenceDialogNoEndDate: return "No end date";
                case RadSchedulerStringId.RecurrenceDialogAllDay: return "All day event";
                case RadSchedulerStringId.RecurrenceDialogDurationDropDown1Day: return "1 روز";
                case RadSchedulerStringId.RecurrenceDialogDurationDropDown2Days: return "2 روز";
                case RadSchedulerStringId.RecurrenceDialogDurationDropDown3Days: return "3 روز";
                case RadSchedulerStringId.RecurrenceDialogDurationDropDown4Days: return "4 روز";
                case RadSchedulerStringId.RecurrenceDialogDurationDropDown1Week: return "1 هفته";
                case RadSchedulerStringId.RecurrenceDialogDurationDropDown2Weeks: return "2 هفته";
                case RadSchedulerStringId.RecurrenceDialogOK: return "OK";
                case RadSchedulerStringId.RecurrenceDialogCancel: return "Cancel";
                case RadSchedulerStringId.RecurrenceDialogRemoveRecurrence: return "Remove Recurrence";
                case RadSchedulerStringId.HourlyRecurrenceEvery: return "Every";
                case RadSchedulerStringId.HourlyRecurrenceHours: return "hour(s)";
                case RadSchedulerStringId.DailyRecurrenceEveryDay: return "Every";
                case RadSchedulerStringId.DailyRecurrenceEveryWeekday: return "Every weekday";
                case RadSchedulerStringId.DailyRecurrenceDays: return "day(s)";
                case RadSchedulerStringId.WeeklyRecurrenceRecurEvery: return "Recur every";
                case RadSchedulerStringId.WeeklyRecurrenceWeeksOn: return "week(s) on:";
                case RadSchedulerStringId.WeeklyRecurrenceSunday: return "یکشنبه";
                case RadSchedulerStringId.WeeklyRecurrenceMonday: return "دوشنبه";
                case RadSchedulerStringId.WeeklyRecurrenceTuesday: return "سه شنبه";
                case RadSchedulerStringId.WeeklyRecurrenceWednesday: return "چهار شنبه";
                case RadSchedulerStringId.WeeklyRecurrenceThursday: return "پنج شنبه";
                case RadSchedulerStringId.WeeklyRecurrenceFriday: return "جمعه";
                case RadSchedulerStringId.WeeklyRecurrenceSaturday: return "شنبه";
                case RadSchedulerStringId.WeeklyRecurrenceDay: return "Day";
                case RadSchedulerStringId.WeeklyRecurrenceWeekday: return "Weekday";
                case RadSchedulerStringId.WeeklyRecurrenceWeekendDay: return "Weekend day";
                case RadSchedulerStringId.MonthlyRecurrenceDay: return "روز";
                case RadSchedulerStringId.MonthlyRecurrenceWeek: return "The";
                case RadSchedulerStringId.MonthlyRecurrenceDayOfMonth: return "of every";
                case RadSchedulerStringId.MonthlyRecurrenceMonths: return "month(s)";
                case RadSchedulerStringId.MonthlyRecurrenceWeekOfMonth: return "of every";
                case RadSchedulerStringId.MonthlyRecurrenceFirst: return "First";
                case RadSchedulerStringId.MonthlyRecurrenceSecond: return "Second";
                case RadSchedulerStringId.MonthlyRecurrenceThird: return "Third";
                case RadSchedulerStringId.MonthlyRecurrenceFourth: return "Fourth";
                case RadSchedulerStringId.MonthlyRecurrenceLast: return "آخر";
                case RadSchedulerStringId.YearlyRecurrenceDayOfMonth: return "هر";
                case RadSchedulerStringId.YearlyRecurrenceWeekOfMonth: return "The";
                case RadSchedulerStringId.YearlyRecurrenceOfMonth: return "of";
                case RadSchedulerStringId.YearlyRecurrenceJanuary: return "بهمن";
                case RadSchedulerStringId.YearlyRecurrenceFebruary: return "اسفند";
                case RadSchedulerStringId.YearlyRecurrenceMarch: return "فروردین";
                case RadSchedulerStringId.YearlyRecurrenceApril: return "اردبیهشت";
                case RadSchedulerStringId.YearlyRecurrenceMay: return "خرداد";
                case RadSchedulerStringId.YearlyRecurrenceJune: return "تیر";
                case RadSchedulerStringId.YearlyRecurrenceJuly: return "مرداد";
                case RadSchedulerStringId.YearlyRecurrenceAugust: return "شهریور";
                case RadSchedulerStringId.YearlyRecurrenceSeptember: return "مهر";
                case RadSchedulerStringId.YearlyRecurrenceOctober: return "آبان";
                case RadSchedulerStringId.YearlyRecurrenceNovember: return "آذر";
                case RadSchedulerStringId.YearlyRecurrenceDecember: return "دی";
                case RadSchedulerStringId.BackgroundNone: return "None";
                case RadSchedulerStringId.BackgroundImportant: return "Important";
                case RadSchedulerStringId.BackgroundBusiness: return "Business";
                case RadSchedulerStringId.BackgroundPersonal: return "Personal";
                case RadSchedulerStringId.BackgroundVacation: return "Vacation";
                case RadSchedulerStringId.BackgroundMustAttend: return "Must Attend";
                case RadSchedulerStringId.BackgroundTravelRequired: return "Travel Required";
                case RadSchedulerStringId.BackgroundNeedsPreparation: return "Needs Preparation";
                case RadSchedulerStringId.BackgroundBirthday: return "تاریخ تولد";
                case RadSchedulerStringId.BackgroundAnniversary: return "Anniversary";
                case RadSchedulerStringId.BackgroundPhoneCall: return "Phone Call";
                case RadSchedulerStringId.StatusBusy: return "Busy";
                case RadSchedulerStringId.StatusFree: return "رایگان";
                case RadSchedulerStringId.StatusTentative: return "Tentative";
                case RadSchedulerStringId.StatusUnavailable: return "غیر قابل دسترس";
                case RadSchedulerStringId.ReminderNone: return "پوچ";
                case RadSchedulerStringId.ReminderZeroMinutes: return "0 دقیقه";
                case RadSchedulerStringId.ReminderFiveMinutes: return "5 دقیقه";
                case RadSchedulerStringId.ReminderTenMinutes: return "10 دقیقه";
                case RadSchedulerStringId.ReminderFifteenMinutes: return "15 دقیقه";
                case RadSchedulerStringId.ReminderThirtyMinutes: return "30 دقیقه";
                case RadSchedulerStringId.ReminderOneHour: return "1 ساعت";
                case RadSchedulerStringId.ReminderTwoHours: return "2 ساعت";
                case RadSchedulerStringId.ReminderThreeHours: return "3 ساعت";
                case RadSchedulerStringId.ReminderFourHours: return "4 ساعت";
                case RadSchedulerStringId.ReminderFiveHours: return "5 ساعت";
                case RadSchedulerStringId.ReminderSixHours: return "6 ساعت";
                case RadSchedulerStringId.ReminderSevenHours: return "7 ساعت";
                case RadSchedulerStringId.ReminderEightHours: return "8 ساعت";
                case RadSchedulerStringId.ReminderNineHours: return "9 ساعت";
                case RadSchedulerStringId.ReminderTenHours: return "10 ساعت";
                case RadSchedulerStringId.ReminderElevenHours: return "11 ساعت";
                case RadSchedulerStringId.ReminderTwelveHours: return "12 ساعت";
                case RadSchedulerStringId.ReminderEighteenHours: return "18 ساعت";
                case RadSchedulerStringId.ReminderOneDay: return "1 روز";
                case RadSchedulerStringId.ReminderTwoDays: return "2 روز";
                case RadSchedulerStringId.ReminderThreeDays: return "3 روز";
                case RadSchedulerStringId.ReminderFourDays: return "4 روز";
                case RadSchedulerStringId.ReminderOneWeek: return "1 هفته";
                case RadSchedulerStringId.ReminderTwoWeeks: return "2 هفته";
                case RadSchedulerStringId.Reminder: return "یادآوری";
                case RadSchedulerStringId.ContextMenuNewAppointment: return "رخداد جدید";
                case RadSchedulerStringId.ContextMenuEditAppointment: return "ویرایش رخداد";
                case RadSchedulerStringId.ContextMenuNewRecurringAppointment: return "انتصاب جدید در دوره های زمانی معین";
                case RadSchedulerStringId.ContextMenu60Minutes: return "60 دقیقه";
                case RadSchedulerStringId.ContextMenu30Minutes: return "30 دقیقه";
                case RadSchedulerStringId.ContextMenu15Minutes: return "15 دقیقه";
                case RadSchedulerStringId.ContextMenu10Minutes: return "10 دقیقه";
                case RadSchedulerStringId.ContextMenu6Minutes: return "6 دقیقه";
                case RadSchedulerStringId.ContextMenu5Minutes: return "5 دقیقه";
                case RadSchedulerStringId.ContextMenuNavigateToNextView: return "نمایش بعدی";
                case RadSchedulerStringId.ContextMenuNavigateToPreviousView: return "نمایش قبلی";
                case RadSchedulerStringId.ContextMenuTimescales: return "مقیاس زمانی";
                case RadSchedulerStringId.ContextMenuTimescalesYear: return "سال";
                case RadSchedulerStringId.ContextMenuTimescalesMonth: return "ماه";
                case RadSchedulerStringId.ContextMenuTimescalesWeek: return "هفته";
                case RadSchedulerStringId.ContextMenuTimescalesDay: return "روز";
                case RadSchedulerStringId.ContextMenuTimescalesHour: return "ساعت";
                case RadSchedulerStringId.ContextMenuTimescalesHalfHour: return "30 دقیقه";
                case RadSchedulerStringId.ContextMenuTimescalesFifteenMinutes: return "15 minutes";
                case RadSchedulerStringId.ErrorProviderWrongAppointmentDates: return "Appointment end time is less or equal to start time!";
                case RadSchedulerStringId.ErrorProviderWrongExceptionDuration: return "Recurrence interval must be greater or equal to appointment duration!";
                case RadSchedulerStringId.ErrorProviderExceptionSameDate: return "Two occurrences of the same series cannot occur on the same day.";
                case RadSchedulerStringId.ErrorProviderExceptionSkipOverDate: return "Recurrence exception cannot skip over a later occurrence of the same appointment.";
                case RadSchedulerStringId.TimeZoneLocal: return "Local";
            }
            return string.Empty;
        }
    }
}