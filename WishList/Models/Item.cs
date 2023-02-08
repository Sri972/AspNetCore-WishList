using System;
using System.ComponentModel.DataAnnotations;

namespace WishList.Models
{
	public class Item
	{
		public int Id
		{
			get;
			set;
		}

		[Required]
		[StringLength(50)]
		public string Description
		{
			get;
			set;
		}
	}
}

