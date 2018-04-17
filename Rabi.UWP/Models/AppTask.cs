using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabi.UWP.Models
{
   public  class AppTask
    {
        public Category Category { get; set; }
        public string ImageSource { get; set; }
        public string Task { get; set; }
        public string Description { get; set; }
    }
   public enum Category
    {
        Vision,
        Knowledge,
        Language,
        Speech,
        Search,
        Lab
    }
}
