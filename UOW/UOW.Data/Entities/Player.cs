using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace UOW.Data.Entities
{
    public class Player : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Number { get; set; }
        public int YearOfBirth { get; set; }
        [ForeignKey("Team")]
        public Guid TeamID { get; set; }
        public virtual Team Team { get; set; }
    }
}
