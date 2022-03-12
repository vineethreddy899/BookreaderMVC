using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Business.Entities
{
    public class Comment
    {
       
        [Key]
        public int Id { get; set; }

        [ForeignKey("Event")]
        public int EventId { get; set; }

        [Required(ErrorMessage = "Please write a comment before posting")]
        public string Comments { get; set; }

        public DateTime TimeStamp { get; set; }

        public Event Event { get; set; }

        public Comment()
        {
            TimeStamp = DateTime.Now;
        }
    }
}
