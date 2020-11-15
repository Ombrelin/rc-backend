using System;
using RencontreContemporainesAPI.Models.Base;

namespace RencontreContemporainesAPI.Models
{
    public class Atelier : BaseEntity
    {
        public DateTime Date { get; set; }
        public string Comment { get; set; }
    }
}