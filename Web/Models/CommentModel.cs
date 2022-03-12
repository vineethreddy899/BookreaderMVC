using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class CommentModel
    {
        
        [Key]
        public int Id { get; set; }

        [ForeignKey("Event")]
        public int EventId { get; set; }

        [Required(ErrorMessage = "Please write a comment before posting")]
        public string Comments { get; set; }

        public DateTime TimeStamp { get; set; }

        public EventModel Event { get; set; }

        public CommentModel()
        {
            TimeStamp = DateTime.Now;
        }
    }
}
