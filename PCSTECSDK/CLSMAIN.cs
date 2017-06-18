using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace PCSTECSDK
{
    /// <summary>
    /// مجموعه توابع کاربردی جهت استفاده و ارتباط سایر نرم افزار ها با نرم افزارPCS
    /// </summary>
    public class SDK
    {
        /// <summary>
        /// بدست آوردن مدت زمان کارکرد و یا توقف یک دستگاه در یک بازه زمانی خاص
        /// </summary>
        /// <param name="ProductLineName">نام دستگاه و یا ماشینی مورد نظر</param>
        /// <param name="FromShamsiDate">تاریخ شروع - شمسی</param>
        /// <param name="FromTime">زمان شروع - "12:00:00"  </param>
        /// <param name="EndShamsiDate">تاریخ پایان - شمسی</param>
        /// <param name="EndTime">زمان پایان - 12:10:00</param>
        /// <returns></returns>
        //public DataTable GetSpecialProductLineWork(string ProductLineName, string FromShamsiDate, string FromTime, string EndShamsiDate, string EndTime)
        //{
        //    if (TryFormat("{####/##/##}", out FromShamsiDate))
        //    {
                 
        //    }

        //}
        public static bool TryFormat(string format, out string result  , params Object[] args)
        {
            result = "";
            try
            {
                result = String.Format(format, args);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }



    }
}
