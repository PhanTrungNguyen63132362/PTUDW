﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MyClass.Model
{
    [Table("Categories")]
    public class Categories
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Slug { get; set; }

        public int ParentID { get; set; }

        public int? Order { get; set; }

        [Required]
        public string MetaDesc { get; set; }

        [Required]
        public string MetaKey { get; set; }

        public DateTime CreateAt { get; set; }

        public int CreateBy { get; set; }

        public DateTime UpdateAt { get; set; }

        public int UpdateBy { get; set; }

        public int Status { get; set; }
    }
}
