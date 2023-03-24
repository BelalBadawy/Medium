using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;




namespace MediumAPI.Data.Entites
{
 
	public class PostTag
	{

		public PostTag()
		{

#region Custom Constructor
#endregion Custom Constructor

		}



public int TageId { get; set; }



public int PostId { get; set; }


[ForeignKey("PostId")]
		public virtual Post Posts { get; set; }
[ForeignKey("TageId")]
		public virtual Tag Tags { get; set; }


#region Custom
#endregion Custom

	}
}
