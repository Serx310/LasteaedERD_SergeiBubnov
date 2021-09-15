using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace LasteaedERD_SergeiBubnov_TARpe20.CFM.Models
{
    public class GroupHistory
    {
        [Key]
        public int GroupHistoryId { get; set; }
        public DateTime BeginningDay { get; set; }
        public DateTime EndDay { get; set; }
    }
}
