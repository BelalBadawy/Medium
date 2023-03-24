using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;




namespace MediumAPI.Data.Entites
{
 
	public class PostRelatedPost
	{

		public PostRelatedPost()
		{

#region Custom Constructor
#endregion Custom Constructor

		}



public int PostId { get; set; }



public int RelatedPostId { get; set; }


[ForeignKey("PostId")]
		public virtual Post Posts { get; set; }


#region Custom
#endregion Custom

	}
}
