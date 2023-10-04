using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace dotnetapp.Models
{
    public class Slot
    {
        //write class here...
        public int SlotID { get; set; }
        public string Time { get; set; }    
        public double Duration { get; set; }    

        [System.ComponentModel.DataAnnotations.Range(1, 4, ErrorMessage = "Slot is full.")]
        public int Capacity { get; set; }
        public ICollection<Booking> bookings { get; set; }
    }
}