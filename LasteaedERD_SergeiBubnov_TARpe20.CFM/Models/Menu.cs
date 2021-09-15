using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LasteaedERD_SergeiBubnov_TARpe20.CFM.Models
{
    public class Menu
    {
        [Key]
        public int MenuId { get; set; }
        public DateTime DatesofMenu { get; set; }
        public  string Dishes { get; set; }
        public int EnergyValue { get; set; }
    }
}
