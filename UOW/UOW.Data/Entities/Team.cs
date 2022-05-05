using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace UOW.Data.Entities
{
    public class Team : BaseEntity
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Country { get; set; }
        [ForeignKey("League")]
        public Guid LeagueID { get; set; }
        public ICollection<Player> Players { get; set; }
        public virtual League League { get; set; }
    }
}
