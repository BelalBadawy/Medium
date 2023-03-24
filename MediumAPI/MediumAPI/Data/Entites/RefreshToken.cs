
namespace MediumAPI.Data.Entites
{
  public class RefreshToken
    {
        public int Id { get; set; }
        public string Token { get; set; }
        public DateTime Expires { get; set; }
        //public bool IsExpired => DateTime.UtcNow >= Expires;
        public bool IsExpired { get; set; }
        public DateTime Created { get; set; }
        public string CreatedByIp { get; set; }
        public DateTime? Revoked { get; set; }
        public string RevokedByIp { get; set; }
        public string ReplacedByToken { get; set; }
        // public bool IsActive => Revoked == null && !IsExpired ;
        public bool IsActive { get; set; }
        public int UserId { get; set; }


 
#region Custom
#endregion Custom


} }
