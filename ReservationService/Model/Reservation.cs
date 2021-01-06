using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace ReservationService.Model
{
    public class Reservation
    {
        [Key]
        public int reservation_number { get; set; }

        public int room_number { get; set; }

        public DateTime res_start { get; set; }

        public DateTime res_end { get; set; }
    }
}
