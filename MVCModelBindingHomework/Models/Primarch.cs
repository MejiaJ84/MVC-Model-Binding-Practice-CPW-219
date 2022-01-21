using System.ComponentModel.DataAnnotations;

namespace MVCModelBindingHomework.Models
{
    public class Primarch
    {
        /// <summary>
        /// Full Name of the Primarch
        /// </summary>
        [Required(ErrorMessage = "Please provide the Primarch's name")]
        [Display(Name = "Primarch's Full Name")]
        public string Name { get; set; }

        /// <summary>
        /// Order in which the Primarch was created
        /// </summary>
        [Range(1, 20, ErrorMessage = "Must be a number between 1 and 20")]
        [Display(Name = "Legion Number")]
        public int LegionNumber { get; set; }

        /// <summary>
        /// The legion that belongs to the Primarch
        /// </summary>
        [Required(ErrorMessage = "Provide the Legion under this Primarch's command")]
        [Display(Name = "Legion of Command")]
        public string Legion { get; set; }

        /// <summary>
        /// The planer where each Primarch was found
        /// and which he considers home
        /// </summary>
        [Required(ErrorMessage = "Enter the world Claimed by the Primarch and his legion")]
        [Display(Name = "Primarch's Home World")]
        public string HomeWorld { get; set; }
    }
}
