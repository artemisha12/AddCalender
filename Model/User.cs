using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Phone]
        public string PhoneNumber {  get; set; }
        [Required]
        public string Password { get; set; }
        public  ICollection<PersonalEvent> PersonalEvents { get; set; }
        public ICollection<GroupMeeting> GroupMeetings { get;set; }
}
}
