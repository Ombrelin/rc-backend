﻿﻿using RencontreContemporainesAPI.Models.Base;

 namespace RencontreContemporainesAPI.Models
{
    public class DbFile : BaseEntity
    {
        public string Name { get; set; }
        public byte[] FileData { get; set; }
    }
}