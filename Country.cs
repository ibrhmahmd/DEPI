using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreTask.Ibrahimahmed
{
    public abstract class Country
    {
        [MaxLength(50)]
        public string CountryName { get; set; }

        public string TimeZone { get; set; }
    }
}
