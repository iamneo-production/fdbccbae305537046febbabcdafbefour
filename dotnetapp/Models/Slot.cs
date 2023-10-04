using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace dotnetapp.Models
{
    public class Slot
    {
        //write class here...
        [ForeignKey("Booking")]
        public int SlotID { get; set; }
        public DateTime Time { get; set; }    
        public double Duration { get; set; }    

        [System.ComponentModel.DataAnnotations.Range(1, 4, ErrorMessage = "Slot is full.")]
        public int Capacity { get; set; }
        
        public List<Booking> Bookings { get; set; }
    }
}