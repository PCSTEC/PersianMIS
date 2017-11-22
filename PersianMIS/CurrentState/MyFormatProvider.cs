using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersianMIS.CurrentState
{
    class MyFormatProvider : IFormatProvider, ICustomFormatter
    {
        private DateTime start;

        public DateTime Start
        {
            get { return start; }
            set { start = value; }
        }

        public object GetFormat(Type formatType)
        {
            if (formatType == typeof(ICustomFormatter))
            {
                return this;
            }

            return null;
        }

        public string Format(string format, object arg, IFormatProvider formatProvider)
        {
            int value = int.Parse(Convert.ToString(arg));

            DateTime date = this.Start.AddHours(value);

            return date.ToString("HH:mm");
        }
    }
}
