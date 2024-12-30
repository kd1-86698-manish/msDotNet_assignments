using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeLib
{
    public class Date
    {
		private int _Day;
		private int _Month;
		private int _Year;



        public Date(){  }

        public Date(int day,int month,int year)
        {
			this._Day = day;
			this._Month = month;
			this._Year = year;
        }

		public void AcceptDate() {

			Console.WriteLine("Enter Day : ");
			_Day=Convert.ToInt32(Console.ReadLine());
			
			Console.WriteLine("Enter Month : ");
			_Month=Convert.ToInt32(Console.ReadLine());
			
			Console.WriteLine("Enter Year : ");
			_Year=Convert.ToInt32(Console.ReadLine());

		}


		public bool IsValid() 
		{

			if (_Month < 1 || _Month > 12)
			{ return false; }

			int[] daysMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };


			if ((_Year % 4 == 0 && _Year % 100 != 0) || (_Year % 400 == 0));
			{ daysMonth[1] = 29; }

			return _Day >= 1 && _Day <= daysMonth[_Month - 1];	
		}

			public void PrintDate() 
		{

            Console.WriteLine("Date : "+_Day +"/"+_Month+"/"+_Year);
		}

        public override string ToString()
        {
            return "Date : " + _Day + "/" + _Month + "/" + _Year;
        }

		public static int DiffrenceBetweenYears(Date date1 , Date date2) 
		{

            int diff= date1.Year-date2.Year;

            if (date2.Month < date1.Month || (date2.Month == date1.Month && date2.Day < date1.Day))
            {
                diff--; 
            
		
			}
			return Math.Abs(diff);
        }

		public static int operator -(Date date1,Date date2) {

			return DiffrenceBetweenYears(date1,	date2);
		}
		

			
        public int Year
		{
			get { return _Year; }
			set { _Year = value; }
		}
		public int Month
		{
			get { return _Month; }
			set { _Month = value; }
		}
		public int Day
		{
			get { return _Day; }
			set { _Day = value; }
		}

	}
}
