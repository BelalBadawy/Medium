
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace MediumAPI.Data.Entites
{
   public class ApplicationUser : IdentityUser<int>
    {
        //[Required]
        [StringLength(200)]
        public string FullName { get; set; }
       

 
#region Custom
#endregion Custom


} }
