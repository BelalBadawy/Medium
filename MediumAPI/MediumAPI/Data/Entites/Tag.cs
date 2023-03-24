using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;




namespace MediumAPI.Data.Entites
{
 
	public class Tag  
	{

		public Tag()
		{

#region Custom Constructor
#endregion Custom Constructor

		}



public int Id { get; set; }



public string Title { get; set; }



public bool IsActive { get; set; }

public virtual List<PostTag> PostTags { get; set; }




#region Custom
#endregion Custom

	}
}
