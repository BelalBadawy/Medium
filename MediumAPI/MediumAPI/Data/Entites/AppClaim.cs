using System.ComponentModel.DataAnnotations.Schema;
namespace MediumAPI.Data.Entites
{
    public class AppClaim
    {
        public int Id { get; set; }

        public int? ParentId { get; set; }

        public string ClaimTitle { get; set; }

        public string DisplayName { get; set; }

        public bool IsLink { get; set; }

        public string UrlLink { get; set; }

        public int DisplayOrder { get; set; }

        public bool IsActive { get; set; }

        [ForeignKey("ParentId")]
        [InverseProperty("AppClaims")]
        public virtual AppClaim Parent { get; set; }


        [InverseProperty("Parent")]
        public virtual ICollection<AppClaim> AppClaims { get; set; }


        #region Custom
        #endregion Custom


    }
}
