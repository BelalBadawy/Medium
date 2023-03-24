using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;




namespace MediumAPI.Data.Entites
{

    public class Post
    {

        public Post()
        {

            #region Custom Constructor
            #endregion Custom Constructor

        }



        public int Id { get; set; }



        public int UserId { get; set; }



        public string Slug { get; set; }



        public string Title { get; set; }



        public string Description { get; set; }



        [DataType(DataType.Html)]
        public string PostContent { get; set; }



        public string BannerImageUrl { get; set; }



        public bool IsActive { get; set; }



        public bool CommentsEnabled { get; set; }



        public int ViewCount { get; set; }



        [DataType(DataType.DateTime)]
        public DateTime CreatedDate { get; set; }

        public virtual List<PostCategory> PostCategories { get; set; }

        public virtual List<PostComment> PostComments { get; set; }

        public virtual List<PostRelatedPost> PostRelatedPosts { get; set; }

        public virtual List<PostTag> PostTags { get; set; }




        #region Custom
        #endregion Custom

    }
}
