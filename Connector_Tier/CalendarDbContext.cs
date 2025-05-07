using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connector_Tier
{
    public class CalendarDbContext:DbContext
    {
        public CalendarDbContext() : base("name=CalendarDbConnection") { }

        public DbSet<User> Users { get; set; }
        public DbSet <PersonalEvent> PersonalEvents { get; set; }
        public DbSet<GroupMeeting> GroupMeetings { get; set; }
        public DbSet<Reminder> Reminders { get; set; }
    }
}
