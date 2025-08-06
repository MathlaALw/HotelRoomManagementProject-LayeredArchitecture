using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRoomManagementProject_LayeredArchitecture.Models
{
    public class Review
    {

        public int ReviewId { get; set; }
        public int GuestId { get; set; }
        public int RoomId { get; set; }
        public string Comments { get; set; }
        public int Rating { get; set; } // Assuming rating is an integer (e.g., 1 to 5)
        public DateTime ReviewDate { get; set; }
        // Navigation properties
        public virtual Guest Guest { get; set; }
        public virtual Room Room { get; set; }
    }
}
