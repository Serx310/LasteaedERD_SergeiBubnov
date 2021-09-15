using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LasteaedERD_SergeiBubnov_TARpe20.CFM.Models
{
    public class EatingHistory
    {
        [Key]
        public int EHId { get; set; }
        public DateTime DayOfEating { get; set; }
        public string Dish { get; set; }
        public int Portion { get; set; }
        public int EnergyValue { get; set; }
    }
}
