using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Model
{
    public class PersonalEvent
    {
        [Key] 
        public int Id {  get; set; }
        public string Title { get; set; }
        public string Location {  get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public ICollection<Reminder> Reminders { get; set; }
        

    }
}
