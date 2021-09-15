using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LasteaedERD_SergeiBubnov_TARpe20.CFM.Models
{
    public class ListOfEntering
    {
        [Key]
        public int LOEId { get; set; }
        public int PositionInList { get; set; }
        public int ChildId { get; set; }
        public IEnumerable <Child> Child { get; set; }
        public int wantedGroupId { get; set; }
        public IEnumerable <Group> wantedGroup { get; set; }
    }
}
