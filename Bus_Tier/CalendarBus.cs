using Connector_Tier;
using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus_Tier
{
    public class CalendarBus
    {
        public CalendarDbContext db = new CalendarDbContext();
        public List<User> GetAllUsers()
        {
            using (var db = new CalendarDbContext())
            {
                return db.Users.ToList();
            }
        }
        public List<EventsItem> GetEventsByDate (int userId, DateTime date)
        {
            var startOfDay = date.Date;
            var endOfDay = startOfDay.AddDays(1);

            // Sự kiện bắt đầu hoặc kết thúc nằm trong ngày đó, hoặc bao trùm cả ngày
            var personal = db.PersonalEvents
                .Where(e => e.UserId == userId &&
                    (
                        (e.Start < endOfDay && e.End > startOfDay) // giao với ngày được chọn
                    ))
                .Select(e => new EventsItem
                {
                    Type = "Personal",
                    Title = e.Title,
                    Location = e.Location,
                    Start = e.Start,
                    End = e.End
                })
                .ToList();

            var group = db.GroupMeetings
                .Where(g => g.Participants.Any(p => p.Id == userId) &&
                    (g.Start < endOfDay && g.End > startOfDay))
                .Select(g => new EventsItem
                {
                    Type = "Group",
                    Title = g.Title,
                    Location = null,
                    Start = g.Start,
                    End = g.End
                });

            return personal.Concat(group).ToList();
        }

        public List<EventsItem> GetEventsInMonth(int userId, DateTime month)
        {
            DateTime start = new DateTime(month.Year, month.Month, 1);
            DateTime end = start.AddMonths(1);

            var personalEvents = db.PersonalEvents
                .Where(e => e.UserId == userId && e.End > start && e.Start < end)
                .Select(e => new EventsItem
                {
                    Type = "Personal",
                    Title = e.Title,
                    Location = e.Location,
                    Start = e.Start,
                    End = e.End
                })
                .ToList();

            var groupEvents = db.GroupMeetings
                .Where(g => g.Participants.Any(p => p.Id == userId) && g.End > start && g.Start < end)
                .Select(g => new EventsItem
                {
                    Type = "Group",
                    Title = g.Title,
                    Location = null,
                    Start = g.Start,
                    End = g.End
                })
                .ToList();

            return personalEvents.Concat(groupEvents).ToList();
        }
        public HashSet<DateTime> GetEventDatesInMonth(int userId, DateTime month)
        {
            var events = GetEventsInMonth(userId, month);

            var eventDates = new HashSet<DateTime>();

            foreach (var ev in events)
            {
                for (var date = ev.Start.Date; date <= ev.End.Date; date = date.AddDays(1))
                {
                    eventDates.Add(date);
                }
            }

            return eventDates;
        }
            
            public void Dispose()
            {
                if (db != null)
                {
                    db.Dispose();
                    db = null;
                }
            }
        public void SaveAllChanges()
        {
            db.SaveChanges();
        }

        public PersonalEvent GetConflictingPersonalEvent(int userId, DateTime newStart, DateTime newEnd)
        {
            return db.PersonalEvents.FirstOrDefault(ev =>
                ev.UserId == userId &&
                (
                    (newStart >= ev.Start && newStart < ev.End) ||     // Bắt đầu nằm trong sự kiện cũ
                    (newEnd > ev.Start && newEnd <= ev.End) ||         // Kết thúc nằm trong sự kiện cũ
                    (newStart <= ev.Start && newEnd >= ev.End)         // Bao trùm toàn bộ sự kiện cũ
                )
            );
        }
        public GroupMeeting GetMatchingGroupMeeting(int userId, string title, TimeSpan duration)
        {
            return db.GroupMeetings
                .Where(g => g.Participants.Any(p => p.Id == userId))
                .FirstOrDefault(g =>
                    g.Title == title &&
                    DbFunctions.DiffMinutes(g.Start, g.End) == (int)duration.TotalMinutes
                );
        }
    }
}
