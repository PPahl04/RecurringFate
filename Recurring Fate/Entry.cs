using System.ComponentModel;

namespace Recurring_Fate
{
	class Entry
	{
		private string _title;
		private string _description;

		private string _streakInDaysHours;
		private DateTime _createdOn;

		public Entry(string myTitle, string myDesc, DateTime myCreatedOn)
		{
			_title = myTitle;
			_description = myDesc;
			_createdOn = myCreatedOn;
			_streakInDaysHours = "0D, 0H";
		}

		public void SetSteak(DateTime myEndDate)
		{
			TimeSpan streak = _createdOn.Subtract(myEndDate);
			_streakInDaysHours = string.Concat(streak.Days,"D, ",streak.Hours,"H");
		}

		public void ResetStreak()
		{
			_streakInDaysHours = string.Concat("0D, 0H");
		}
		
		public string Title { get => _title; set => _title = value; }
		public string StreakDayHour { get => _streakInDaysHours; set => _streakInDaysHours = value; }
		public DateTime CreatedOn { get => _createdOn; set => _createdOn = value; }

		[Browsable(false)]
		public string Description { get => _description; set => _description = value; }
	}
}