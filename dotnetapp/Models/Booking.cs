
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace dotnetapp.Models

{
    public class Booking
    {
        //write class here...
        public int BookingID { get; set; }  

        [ForeignKey("Slot")]
        public int SlotID { get; set; } 
        public string UserID { get; set; }  
    }
}