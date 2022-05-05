using System.Collections.Generic;

namespace UOW.Data.Entities
{
    public class League : BaseEntity
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public ICollection<Team> Teams { get; set; }
    }
}
