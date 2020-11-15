using System;
using RencontreContemporainesAPI.Models.Base;

namespace RencontreContemporainesAPI.Models
{
    public class Atelier : BaseEntity
    {
        public DateTime Date { get; set; }
        public Boolean Sure { get; set; }
    }
}