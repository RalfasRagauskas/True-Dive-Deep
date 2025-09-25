using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace True_Dive_Deep.Models
{
    public class Account : IdentityUser<int>
    {
        [Required]
        public string? FirstName { get; set; }
        public int PhoneNumber { get; set; }

        [Timestamp]
        public byte[]? RowVersion { get; set; }


    }
}
