using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;




namespace MediumAPI.Data.Entites
{
 
	public class PostCategory
	{

		public PostCategory()
		{

#region Custom Constructor
#endregion Custom Constructor

		}



public int CategoryId { get; set; }



public int PostId { get; set; }


[ForeignKey("CategoryId")]
		public virtual Category Categories { get; set; }
[ForeignKey("PostId")]
		public virtual Post Posts { get; set; }


#region Custom
#endregion Custom

	}
}
