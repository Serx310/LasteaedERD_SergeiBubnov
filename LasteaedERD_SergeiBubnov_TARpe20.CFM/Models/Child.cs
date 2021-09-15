using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;

namespace LasteaedERD_SergeiBubnov_TARpe20.CFM.Models
{
    public class Child
    {
        [Key]
        public int ChildId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public ICollection <GroupHistory> groupHistory { get; set; }
        public int GroupId { get; set; }
        public IEnumerable <Group> Group { get; set; }
        public int AbsenceId { get; set; }
        public IEnumerable<Absence> Absence { get; set; }
    }
}
