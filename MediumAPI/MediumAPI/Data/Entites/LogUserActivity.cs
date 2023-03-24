
using System;
namespace MediumAPI.Data.Entites
{
  public class LogUserActivity
    {
        public long Id { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UrlData { get; set; }
        public string UserData { get; set; }
        public string IPAddress { get; set; }
        public string Browser { get; set; }
        public string HttpMethod { get; set; }
        public int? ImpersonatedBy { get; set; }


            

#region Custom
#endregion Custom


}
}
