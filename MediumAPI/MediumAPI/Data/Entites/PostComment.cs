using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;




namespace MediumAPI.Data.Entites
{

    public class PostComment
    {

        public PostComment()
        {

            #region Custom Constructor
            #endregion Custom Constructor

        }



        public int Id { get; set; }



        public int PostId { get; set; }



        public int UserId { get; set; }



        public int? ParentId { get; set; }



        public string Comment { get; set; }



        [DataType(DataType.DateTime)]
        public DateTime CreatedDate { get; set; }



        public bool IsActive { get; set; }


        [ForeignKey("PostId")]
        public virtual Post Posts { get; set; }


        #region Custom
        #endregion Custom

    }
}
