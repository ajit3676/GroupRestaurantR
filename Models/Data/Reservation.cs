using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HamroLibrary.Models.Data
{
    public class Reservation
    {
        public int ReservationID { get; set; }
        public string ReservationName { get; set;}
        public int NoOfGuests { get; set;}
        public string ReservationDate { get; set;}
        public string ReservationTime { get; set;}
    }
}