using System;
using System.Collections.Generic;
using RencontreContemporainesAPI.Models.Base;

namespace RencontreContemporainesAPI.Models
{
    public class Concert : BaseEntity
    {
        public string Title { get; set; }
        public DateTime? DateTime { get; set; }
        public List<TimeSpan> Hours { get; set; }
        public Boolean DateSure { get; set; }
        public string Location { get; set; }
        public Boolean LocationSure { get; set; }
        public string Artist { get; set; }
        public string Description { get; set; }
        public Guid Image { get; set; }
        public Guid Flyer { get; set; }
        public string DateFormat { get; set; }
    }
}