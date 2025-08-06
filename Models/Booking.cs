using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRoomManagementProject_LayeredArchitecture.Models
{
    public class Booking
    {
        [Key]
        public  int BookingId { get; set; } // Unique identifier for the booking
        [ForeignKey("room")]
        public int RoomId { get; set; } // Foreign key to the Room table

        [ForeignKey("Guest")]
        public int GuestId { get; set; } // Foreign key to the Guest table

        [Required]
        [DataType(DataType.Date)]
        public DateTime CheckInDate { get; set; } // Date of check-in

        [Required]
        [DataType(DataType.Date)]
        
        public DateTime CheckOutDate { get; set; } // Date of check-out

        [NotMapped] // This property is not mapped to the database
        // Represents the duration of the stay in days
        public int StayDurationDays => (CheckOutDate - CheckInDate).Days;


        public double TotalAmount { get; set; } // Total amount for the booking


        // Navigation properties
        // One -to-many relationship with Room
        
        public Room room { get; set; } // Navigation property to the Room entity


    }
}
