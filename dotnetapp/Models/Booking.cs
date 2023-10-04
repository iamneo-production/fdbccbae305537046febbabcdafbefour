
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace dotnetapp.Models

{
    public class Booking
    {
        //write class here...
        public int BookingID { get; set; }  
        public int SlotID { get; set; } 
        public int UserID { get; set; }  
        public Slot Slot { get; set; }
    }
}