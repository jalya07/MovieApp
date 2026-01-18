using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieApp.DAL.Models
{
    [Table("Directors")]
    public class Director:BaseEntity
	{
		public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Adress { get; set; } = null!;
        public string? City { get; set; } = null!;
        public int Age { get; set; }
    }
}

