using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LasteaedERD_SergeiBubnov_TARpe20.CFM.Models
{
    public class WorkingHistory
    {
        [Key]
        public int WHId { get; set; }
        public DateTime BeginningDate { get; set; }
        public DateTime EndDay { get; set; }
        public int PositionIds { get; set; }
        public IEnumerable <Position> Positions { get; set; }
    }
}
