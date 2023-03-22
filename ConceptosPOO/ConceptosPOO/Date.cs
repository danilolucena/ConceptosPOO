using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosPOO
{
    public class Date
    {
        private int _year;
        private int _month;
        private int _day;

        public Date(int year, int month, int day)
        {
            _year = year;
            _month = checkMonth(month);
            _day = checkDay(year, month,day);
        }

        private int checkDay(int year, int month, int day)
        {
            if(month == 2 && day==29 && IsleapYear(year))
            {
                return day;
            }
            int[] dayPerMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if(day >=1 && day <= dayPerMonth[month])
            {
                return day;
            }

            throw new DayException("Invalid Day");
        }

        private bool IsleapYear(int year)
        {
            return year % 400 == 0 || year % 4 == 0 && year % 100 != 0;
          
            throw new NotImplementedException();
        }

        private int checkMonth(int month)
        {
            if(month >=1 && month <= 12)
            {
                return month;
            }
            throw new MonthException("Invalid month");
        }

        public override string ToString()
        {
           // return _year + "/" + _month + "/" + _day;
            return $"{_year}/{_month:00}/{_day:00}";
        }
    }
}
