using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Reminder
    {
        public int Id { get; set; }
        public DateTime NotifyAt { get; set; }
        public DayOfWeek? DayOfWeek { get; set; }

        public int PersonalEventId { get; set; }
        public PersonalEvent PersonalEvent { get; set; }
    }
}
