using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRoomManagementProject_LayeredArchitecture.Models
{
    public class Review
    {
        [Key]
        public int ReviewId { get; set; }
        [ForeignKey("Guest")]
        public int GuestId { get; set; }
        [ForeignKey("Room")]
        public int RoomId { get; set; }

        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Comments can only contain letters and spaces.")]
        public string Comments { get; set; }

        [Required]
        [EnumDataType(typeof(Rate))]
        public int Rating { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)] // database insert today’s date automatically ( date and time when the review is created)
        public DateTime ReviewDate { get; set; }


        // Navigation properties

        public Room Room { get; set; } // Navigation property to the Room entity

    }
}
