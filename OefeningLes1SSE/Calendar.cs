using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Oefening8
{
    class Calendar
    {
        [Flags]
        public enum WeekDay
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 4,
            Thursday = 8,
            Friday = 16,
            Saturday = 32,
            Sunday = 64
        }

        public enum Show
        {
            Numbers,
            Names
        }

        public enum WeekPart
        {
            Weekend,
            Week,
            WorkDays
        }

        public Dictionary<string, WeekDay> Events { get; }

        public Calendar()
        {
            this.Events = new Dictionary<string, WeekDay>();
        }

        public void ShowDays(WeekPart weekpart)
        {
            ShowDays(weekpart, Show.Names);
        }

        public void ShowDays(WeekPart weekPart, Show show)
        {

            WeekDay days = GetDays(weekPart);
            Console.WriteLine(days);
        }

        public void ShowEvents()
        {
            foreach (string key in Events.Keys)
            {
                Console.WriteLine($"\nWAT: {key}\nWANNEER: {Events[key]}");
            }
        }

        private WeekDay GetDays(WeekPart weekPart)
        {
            switch (weekPart)
            {
                case WeekPart.WorkDays:
                    return GetWorkDays();
                case WeekPart.Weekend:
                    return GetWeekend();

            }
            return GetWorkDays() | GetWeekend();
        }

        private WeekDay GetWorkDays()
        {
            return WeekDay.Monday | WeekDay.Tuesday | WeekDay.Wednesday | WeekDay.Thursday | WeekDay.Friday;
        }

        private WeekDay GetWeekend()
        {
            return WeekDay.Saturday | WeekDay.Sunday;
        }

        public void AddEventDay(string desc, List<WeekDay> weekDays)
        {
            WeekDay days = weekDays.Aggregate((day1, day2) => day1 | day2);
            AddEventDay(desc, days);
        }

        public void AddEventDay(string desc, WeekDay weekDay)
        {
            Events.Add(desc, weekDay);
        }

        public void AddEventDay(string desc, WeekPart weekPart)
        {
            WeekDay days = GetDays(weekPart);
            AddEventDay(desc, days);
        }
    }
}
