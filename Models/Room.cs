using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRoomManagementProject_LayeredArchitecture.Models
{
    public class Room
    {
        [Key]
        public int RoomId { get; set; } // Unique identifier for the room
        [Required]
        public int RoomNumber { get; set; }
        [Required]
        [EnumDataType(typeof(roomType))]
        public string RoomType { get; set; } // Single, Double, Suite
        public decimal dailyRate { get; set; }
        public bool IsAvailable { get; set; } = true; // Default to available
       
    }
}
