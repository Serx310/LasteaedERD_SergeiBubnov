using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace LasteaedERD_SergeiBubnov_TARpe20.CFM.Models
{
    public class Group
    {
        [Key]
        public int GroupId { get; set; }
        public string GroupType { get; set; }
        public int ChildrenIds { get; set ; }
        public ICollection<Child> Children { get; set; }
        public int EHId { get; set; }
        public IEnumerable<EatingHistory> EatingHistory { get; set; }


    }
}
