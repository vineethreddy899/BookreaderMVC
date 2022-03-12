using Business.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class EventModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = " Please Enter title of the book")]
        [Display(Name = "Title of the Book")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please Enter the Event Date")]
        [Display(Name = "Event Date and Time")]
        [DataType(DataType.DateTime)]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Please Enter the venue")]
        [Display(Name = "Venue Location")]
        public string Location { get; set; }

        [Display(Name = "Organiser")]
        [Required(ErrorMessage = "Please Enter your Username")]
        public string Organiser { get; set; }

        [Display(Name = "Description")]
        [StringLength(50)]
        public string Description { get; set; }

        [Range(1, 4, ErrorMessage = " Duration should be 1-4 hours only")]
        public int? Duration { get; set; }

        [Display(Name = "Other Details")]
        [StringLength(500)]
        public string OtherDetails { get; set; }

        public TypeEnum Type { get; set; }

        [Display(Name ="Invitees")]
        public string Invitees { get; set; }

        [ForeignKey("EventId")]
        public ICollection<CommentModel> Comments { get; set; }
    }
}
