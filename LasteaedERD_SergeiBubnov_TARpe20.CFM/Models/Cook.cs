using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LasteaedERD_SergeiBubnov_TARpe20.CFM.Models
{
    public class Cook
    {
        [Key]
        public int CookId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public int PositionId { get; set; }
        public IEnumerable <Position> position { get; set; }
    }
}
