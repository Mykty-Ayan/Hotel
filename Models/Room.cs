using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Hotel.Models
{
    public class Room
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Capacity { get; set; }

        [Required]
        public int Price { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime DateFrom { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime DateTo { get; set; }


    }

    class RoomsDBcontext1 : DbContext
    {
        public RoomsDBcontext1()
        {

        }
        public DbSet<Room> Rooms { get; set; }
    }
}