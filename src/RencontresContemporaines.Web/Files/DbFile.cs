﻿using System;
 using RencontreContemporainesAPI.Models.Base;

 namespace RencontresContemporaines.Core.Domain; 

 public class DbFile
 {
     public Guid Id { get; set; }
     public string Name { get; set; }
     public byte[] FileData { get; set; }
 }