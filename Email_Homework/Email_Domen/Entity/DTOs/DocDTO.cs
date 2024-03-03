﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Email_Domen.Entity.DTOs
{
    public class DocDTO
    {
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        [JsonIgnore]
        public DateTime Data { get; set; }
        public string Description { get; set; }
    }
}
