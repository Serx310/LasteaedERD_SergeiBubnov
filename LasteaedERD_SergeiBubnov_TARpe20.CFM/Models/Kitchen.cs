using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace LasteaedERD_SergeiBubnov_TARpe20.CFM.Models
{
    public class Kitchen
    {
        [Key]
        public int KitchenId { get; set; }
        public int CookId { get; set; }
        public IEnumerable <Cook> Cook { get; set; }
        public int MenuId { get; set; }
        public IEnumerable <Menu> MenuOfTheWeek { get; set; }
    }
}
