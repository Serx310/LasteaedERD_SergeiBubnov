using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace LasteaedERD_SergeiBubnov_TARpe20.CFM.Models
{
    public class Absence
    {
        [Key]
        public int AbsenceId { get; set; }
        public DateTime DateofAbsence { get; set; }
        public string Reason { get; set; }
    }
}
