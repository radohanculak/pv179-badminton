using System.ComponentModel.DataAnnotations.Schema;

namespace Sprint.DAL.Models
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string PasswordHash { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string PhotoPath { get; set; }

        public virtual List<CourtReservation> CourtReservations { get; set; }
    }
}
