namespace MVCModelBindingHomework.Models
{
    public class Primarch
    {
        /// <summary>
        /// Full Name of the Primarch
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Order in which the Primarch was created
        /// </summary>
        public int PrimarchNumber { get; set; }

        /// <summary>
        /// The legion that belongs to the Primarch
        /// </summary>
        public string Legion { get; set; }

        /// <summary>
        /// The planer where each Primarch was found
        /// and which he considers home
        /// </summary>
        public string HomeWorld { get; set; }
    }
}
