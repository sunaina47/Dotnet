using System.ComponentModel.DataAnnotations;

namespace Raptors.Models
{
    public class Player
    {
        [Required]
        [StringLength(100)]
        [Display (Name = "BasketBall Player name")]
        public string PlayerName { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3)]
        [Range(1, 100)]
        public string Position { get; set; }

        [Compare("MailAddressRepeated")]
        public string MailAddress { get; set;}

        public string MailAddressRepeated { get; set;}

 
    }
}
