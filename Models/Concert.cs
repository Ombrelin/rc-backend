using System;
using RencontreContemporainesAPI.Models.Base;

namespace RencontreContemporainesAPI.Models
{
    public class Concert : BaseEntity
    {
        public string Title { get; set; }
        public DateTime? DateTime { get; set; }
        public string Location { get; set; }
        public string Artist { get; set; }
        public string Description { get; set; }
        public Guid Image { get; set; }
        public Guid Flyer { get; set; }
    }
}