using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.DynamicData;

namespace WebApplication2.Models
{
    public class PrintPicsContext : DbContext
    {
        public PrintPicsContext() : base("printpics")
        {
        }

        public DbSet<Feedback> Feedback { get; set; }
    }

    public class Feedback
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email Address")]
        public string Email { get; set; }
        [Required]
        [StringLength(500)]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Comment")]
        public string Text { get; set; }
    }
}