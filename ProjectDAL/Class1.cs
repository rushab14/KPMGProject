using System.ComponentModel.DataAnnotations;

namespace ProjectDAL
{
    public class Owner
    {
        [Key]
        public int FlatNumber { get; set; }

        [Required]
        public string Name { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }

        public int? gatePasses { get; set; }
        public string? facilities { get; set; }
    }

    public class Facility

    {
        [Key]
        public int FacilityId { get; set; }
        public bool  isAvailable { get; set; }

        public string  FacilityName { get; set; }   
    }

    public class GatePass

    {
        [Key]
        public int GatePassId { get; set; }
        public int? FlatNumber { get; set; }
        public string? VisitorsName { get; set; }
    }



}