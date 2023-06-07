using System;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
	public class Cinema
	{
		[Key]
		public string Id { get; set; }

		public string Logo { set; get; }

		public string Description { set; get; }

		//Relationships
		public List<Movie> Movies {get; set;}
	}
}

