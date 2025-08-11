using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRoomManagementProject_LayeredArchitecture.Models
{
    public class Guest
    {
        [Key]
        public int GuestId { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Name can only contain letters and spaces.")]
        public string GuestName { get; set; }
        [Required]
        [RegularExpression(@"^[0-9]\d{7}$", ErrorMessage = "Contact number must be 8 digits long and contain only numbers.")]
        public string ContactNumber { get; set; }

        // Navigation properties

        public ICollection<Booking> Bookings { get; set; }




    }
}
