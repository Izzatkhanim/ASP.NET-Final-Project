﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace Repository.Models
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public bool Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        [MaxLength(50)]
        public string CreatedBy { get; set; }
        [MaxLength(50)]
        public string ModifiedBy { get; set; }

    }
}
