using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LasteaedERD_SergeiBubnov_TARpe20.CFM.Models
{
    public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }
        public string FirstName { get; set; }
        public DateTime Birthday { get; set; }
        public int PositionId { get; set; }
        public IEnumerable <Position> Position { get; set; }
        public int WHId { get; set; }
        public IEnumerable <WorkingHistory> WH { get; set; }
    }
}
