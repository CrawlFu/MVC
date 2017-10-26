using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Mvc5FuLuA.Areas.LX07.Models
{
    [Table("Movie")]
    public class Movie
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        [StringLength(3, MinimumLength = 3)]
        [Display(Name = "电影编号")]
        public string ID { get; set; }


        [Required]
        [StringLength(10)]
        [Display(Name = "电影类型")]
        public string MovieType { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name = "电影名称")]
        public string MovieName { get; set; }
    }
}